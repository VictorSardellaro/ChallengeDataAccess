using System.Collections.Generic;
using System.Linq;
using Blog.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace Blog.Repositories
{
    public class CategoryRepository : Repository<Category>
    {

        private readonly SqlConnection _connection;
        public CategoryRepository(SqlConnection connection)
        : base(connection)
            => _connection = connection;

        public List<Category> GetWithPosts()
        {
            var query = @"
            SELECT
                [Category].*,
                [Post].*
            FROM
                [Category]
                LEFT JOIN [CategoryPost] ON [CategoryPost].[CategoryId] = [Category].[Id]
                LEFT JOIN [Post] ON [CategoryPost].[PostId] = [Post].[Id]";

            var categorys = new List<Category>();
            var items = _connection.Query<Category, Post, Category>(
                query,
                (category, post) =>
                {
                    var usr = categorys.FirstOrDefault(x => x.Id == category.Id);
                    if (usr == null)
                    {
                        usr = category;
                        if (post != null)
                            usr.Posts.Add(post);

                        categorys.Add(usr);
                    }
                    else
                        usr.Posts.Add(post);

                    return category;
                }, splitOn: "Id");
            return categorys;
        }
    }


}
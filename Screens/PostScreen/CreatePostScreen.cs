using System;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.PostScreens
{
    public static class CreatePostScreen
    {
        public static void Load()
        {
            Console.Clear();

            System.Console.WriteLine("Novo Post");
            System.Console.WriteLine("------------------");

            System.Console.Write("Category ID: ");
            var categoryId = Console.ReadLine();

            System.Console.Write("Author ID: ");
            var authorId = Console.ReadLine();

            System.Console.Write("Title: ");
            var title = Console.ReadLine();

            System.Console.Write("Summary: ");
            var summary = Console.ReadLine();

            System.Console.Write("Body: ");
            var body = Console.ReadLine();

            System.Console.Write("Slug: ");
            var slug = Console.ReadLine();

            Create(new Post
            {
                CategoryId = int.Parse(categoryId),
                AuthorId = int.Parse(authorId),
                Title = title,
                Summary = summary,
                Body = body,
                Slug = slug,
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now
            });

            Console.ReadKey();
            MenuPostScreen.Load();
        }

        public static void Create(Post post)
        {
            try
            {
                var repository = new Repository<Post>(Database.Connection);
                repository.Create(post);
                System.Console.WriteLine("Post cadastrado com sucesso!");
            }

            catch (Exception ex)
            {
                System.Console.WriteLine("Não foi possível salvar post");
                System.Console.WriteLine(ex.Message);
            }
        }
    }
}
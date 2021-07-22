using System;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.PostTagScreens
{
    public static class DeletePostTagScreen
    {
        public static void Load()
        {
            Console.Clear();

            System.Console.WriteLine("Excluir um vinculo entre Post e TAG");
            System.Console.WriteLine("------------------");
            System.Console.Write("PostID: ");
            var postId = int.Parse(Console.ReadLine());

            System.Console.Write("TagID: ");
            var tagId = int.Parse(Console.ReadLine());

            Delete(new PostTag
            {
                PostId = postId,
                TagId = tagId
            });
            Console.ReadKey();
            MenuPostTagScreen.Load();
        }
        public static void Delete(PostTag postTag)
        {
            try
            {
                var repository = new Repository<PostTag>(Database.Connection);
                repository.Delete(postTag);
                System.Console.WriteLine("Vinculo excluido com sucesso!");
            }

            catch (Exception ex)
            {
                System.Console.WriteLine("Não foi possível excluir o Vinculo");
                System.Console.WriteLine(ex.Message);
            }
        }
    }
}
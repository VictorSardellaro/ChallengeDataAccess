using System;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.PostTagScreens
{
    public static class CreatePostTagScreen
    {
        public static void Load()
        {
            Console.Clear();

            System.Console.WriteLine("Novo vinculo de Post com TAG");
            System.Console.WriteLine("------------------");

            System.Console.Write("PostID: ");
            int postId = int.Parse(Console.ReadLine());

            System.Console.Write("TagID: ");
            int tagId = int.Parse(Console.ReadLine());



            Create(new PostTag
            {
                PostId = postId,
                TagId = tagId
            });
            Console.ReadKey();
            MenuPostTagScreen.Load();
        }

        public static void Create(PostTag postTag)
        {
            try
            {
                var repository = new Repository<PostTag>(Database.Connection);
                repository.Create(postTag);
                System.Console.WriteLine("Vinculo cadastrado com sucesso!");
            }

            catch (Exception ex)
            {
                System.Console.WriteLine("Não foi possível salvar o vinculo");
                System.Console.WriteLine(ex.Message);
            }
        }
    }
}
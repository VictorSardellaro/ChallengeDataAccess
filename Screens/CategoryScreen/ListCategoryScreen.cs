using System;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.CategoryScreens
{
    public static class ListCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            System.Console.WriteLine("Lista de categorias");
            System.Console.WriteLine("------------------");
            List();
            ReadWithPost();
            Console.ReadKey();
            MenuCategoryScreen.Load();
        }

        private static void List()
        {
            var respository = new Repository<Category>(Database.Connection);
            var categorys = respository.Get();
            foreach (var item in categorys)
            {
                System.Console.WriteLine($"{item.Id} - {item.Name} ({item.Slug})");
            }

        }

        private static void ReadWithPost()
        {
            System.Console.WriteLine("Lista de Categorias com quantidade de Posts");
            System.Console.WriteLine("------------------");

            var repository = new CategoryRepository(Database.Connection);
            var cats = repository.GetWithPosts();

            foreach (var cat in cats)
            {
                Console.Write(cat.Name);
                foreach (var post in cat.Posts)
                {
                    System.Console.WriteLine("01");

                }


                System.Console.WriteLine();
            }
        }


    }
}

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


    }
}

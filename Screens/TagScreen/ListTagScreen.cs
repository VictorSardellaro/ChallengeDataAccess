using System;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.TagScreens
{
    public static class ListTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            System.Console.WriteLine("Lista de tags");
            System.Console.WriteLine("------------------");
            List();
            Console.ReadKey();
        }

        private static void List()
        {
            var respository = new Repository<Tag>(Database.Connection);
            var tags = respository.Get();
            foreach (var item in tags)
            {
                System.Console.WriteLine($"{item.Id} - {item.Name} ({item.Slug})");
            }

        }


    }
}

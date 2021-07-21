using System;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.UserScreens
{
    public static class ListUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            System.Console.WriteLine("Lista de users");
            System.Console.WriteLine("------------------");
            List();
            Console.ReadKey();
            MenuUserScreen.Load();
        }

        private static void List()
        {
            var respository = new Repository<User>(Database.Connection);
            var users = respository.Get();
            foreach (var item in users)
            {
                System.Console.WriteLine($"{item.Id} - {item.Name} - {item.Email} - {item.Bio} - {item.Image} - ({item.Slug})");
            }

        }


    }
}

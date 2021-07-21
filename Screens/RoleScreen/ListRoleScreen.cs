using System;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.RoleScreens
{
    public static class ListRoleScreen
    {
        public static void Load()
        {
            Console.Clear();
            System.Console.WriteLine("Lista de perfis");
            System.Console.WriteLine("------------------");
            List();
            Console.ReadKey();
            MenuRoleScreen.Load();
        }

        private static void List()
        {
            var respository = new Repository<Role>(Database.Connection);
            var roles = respository.Get();
            foreach (var item in roles)
            {
                System.Console.WriteLine($"{item.Id} - {item.Name} ({item.Slug})");
            }

        }


    }
}

using System;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.UserRoleScreens
{
    public static class ListUserRoleScreen
    {
        public static void Load()
        {
            Console.Clear();
            System.Console.WriteLine("Lista vinculos de usuarios com roles");
            System.Console.WriteLine("------------------");
            List();
            Console.ReadKey();
            MenuUserRoleScreen.Load();
        }

        private static void List()
        {
            var respository = new Repository<UserRole>(Database.Connection);
            var userRoles = respository.Get();
            foreach (var item in userRoles)
            {
                System.Console.WriteLine($"{item.UserId} - {item.RoleId}");
            }

        }


    }
}

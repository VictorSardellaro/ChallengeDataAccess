using System;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.UserRoleScreens
{
    public static class CreateUserRoleScreen
    {
        public static void Load()
        {
            Console.Clear();

            System.Console.WriteLine("Novo vinculo");
            System.Console.WriteLine("------------------");

            System.Console.Write("UserID: ");
            int userId = int.Parse(Console.ReadLine());

            System.Console.Write("RoleID: ");
            int roleId = int.Parse(Console.ReadLine());



            Create(new UserRole
            {
                UserId = userId,
                RoleId = roleId
            });
            Console.ReadKey();
            MenuUserRoleScreen.Load();
        }

        public static void Create(UserRole userRole)
        {
            try
            {
                var repository = new Repository<UserRole>(Database.Connection);
                repository.Create(userRole);
                System.Console.WriteLine("User cadastrado com sucesso!");
            }

            catch (Exception ex)
            {
                System.Console.WriteLine("Não foi possível salvar o user");
                System.Console.WriteLine(ex.Message);
            }
        }
    }
}
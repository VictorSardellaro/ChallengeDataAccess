using System;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.UserRoleScreens
{
    public static class UpdateUserRoleScreen
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



            Update(new UserRole
            {
                UserId = userId,
                RoleId = roleId
            });
            Console.ReadKey();
            MenuUserRoleScreen.Load();
        }
        public static void Update(UserRole userRole)
        {
            try
            {
                var repository = new Repository<UserRole>(Database.Connection);
                repository.Update(userRole);
                System.Console.WriteLine("User atualizada com sucesso!");
            }

            catch (Exception ex)
            {
                System.Console.WriteLine("Não foi possível atualizar a user");
                System.Console.WriteLine(ex.Message);
            }
        }
    }
}

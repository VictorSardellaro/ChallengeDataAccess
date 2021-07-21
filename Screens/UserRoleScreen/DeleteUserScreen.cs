using System;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.UserRoleScreens
{
    public static class DeleteUserRoleScreen
    {
        public static void Load()
        {
            Console.Clear();

            System.Console.WriteLine("Excluir um vinculo entre usuario e role");
            System.Console.WriteLine("------------------");
            System.Console.Write("UserID: ");
            var userId = Console.ReadLine();

            System.Console.Write("RoleID: ");
            var roleId = Console.ReadLine();

            Delete(new UserRole
            {
                UserId = int.Parse(userId),
                RoleId = int.Parse(roleId)
            });
            Console.ReadKey();
            MenuUserRoleScreen.Load();
        }
        public static void Delete(UserRole userRole)
        {
            try
            {
                var repository = new Repository<UserRole>(Database.Connection);
                repository.Delete(userRole);
                System.Console.WriteLine("User excluida com sucesso!");
            }

            catch (Exception ex)
            {
                System.Console.WriteLine("Não foi possível excluir a user");
                System.Console.WriteLine(ex.Message);
            }
        }
    }
}
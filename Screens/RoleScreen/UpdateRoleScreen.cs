using System;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.RoleScreens
{
    public static class UpdateRoleScreen
    {
        public static void Load()
        {
            Console.Clear();

            System.Console.WriteLine("Atualizando uma role");
            System.Console.WriteLine("------------------");

            System.Console.Write("Id: ");
            var id = Console.ReadLine();

            System.Console.Write("Name: ");
            var name = Console.ReadLine();

            System.Console.Write("Slug: ");
            var slug = Console.ReadLine();

            Update(new Role
            {
                Id = int.Parse(id),
                Name = name,
                Slug = slug
            });
            Console.ReadKey();
            MenuRoleScreen.Load();
        }
        public static void Update(Role role)
        {
            try
            {
                var repository = new Repository<Role>(Database.Connection);
                repository.Update(role);
                System.Console.WriteLine("Perfil atualizado com sucesso!");
            }

            catch (Exception ex)
            {
                System.Console.WriteLine("Não foi possível atualizar o perfil");
                System.Console.WriteLine(ex.Message);
            }
        }
    }
}

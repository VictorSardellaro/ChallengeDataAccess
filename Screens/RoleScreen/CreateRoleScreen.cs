using System;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.RoleScreens
{
    public static class CreateRoleScreen
    {
        public static void Load()
        {
            Console.Clear();

            System.Console.WriteLine("Novo Perfil");
            System.Console.WriteLine("------------------");
            System.Console.Write("Name: ");
            var name = Console.ReadLine();
            System.Console.Write("Slug: ");
            var slug = Console.ReadLine();

            Create(new Role
            {
                Name = name,
                Slug = slug
            });
            Console.ReadKey();
            MenuRoleScreen.Load();
        }

        public static void Create(Role role)
        {
            try
            {
                var repository = new Repository<Role>(Database.Connection);
                repository.Create(role);
                System.Console.WriteLine("perfil cadastrado com sucesso!");
            }

            catch (Exception ex)
            {
                System.Console.WriteLine("Não foi possível salvar o perfil");
                System.Console.WriteLine(ex.Message);
            }
        }
    }
}
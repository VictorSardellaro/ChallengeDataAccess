using System;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.UserScreens
{
    public static class CreateUserScreen
    {
        public static void Load()
        {
            Console.Clear();

            System.Console.WriteLine("Novo user");
            System.Console.WriteLine("------------------");

            System.Console.Write("Name: ");
            var name = Console.ReadLine();

            System.Console.Write("Email: ");
            var email = Console.ReadLine();

            System.Console.Write("Password: ");
            var password = Console.ReadLine();

            System.Console.Write("Bio: ");
            var bio = Console.ReadLine();

            System.Console.Write("Image URL: ");
            var image = Console.ReadLine();

            System.Console.Write("Slug: ");
            var slug = Console.ReadLine();

            Create(new User
            {
                Name = name,
                Email = email,
                PasswordHash = password,
                Bio = bio,
                Image = image,
                Slug = slug
            });
            Console.ReadKey();
            MenuUserScreen.Load();
        }

        public static void Create(User user)
        {
            try
            {
                var repository = new Repository<User>(Database.Connection);
                repository.Create(user);
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
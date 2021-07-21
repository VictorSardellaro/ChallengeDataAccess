using System;
using Blog.Models;
using Blog.Repositories;
using Blog.Screens.UserScreen;

namespace Blog.Screens.UserScreens
{
    public static class UpdateUserScreen
    {
        public static void Load()
        {
            Console.Clear();

            System.Console.WriteLine("Atualizando uma user");
            System.Console.WriteLine("------------------");

            System.Console.Write("Id: ");
            var id = Console.ReadLine();

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


            Update(new User
            {
                Id = int.Parse(id),
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
        public static void Update(User user)
        {
            try
            {
                var repository = new Repository<User>(Database.Connection);
                repository.Update(user);
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

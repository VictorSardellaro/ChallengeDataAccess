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
            System.Console.WriteLine("O que deseja fazer?");
            System.Console.WriteLine();
            System.Console.WriteLine("1 - Listar usuários");
            System.Console.WriteLine("2 - Listar usuários com E-mail e Perfis");
            var option = short.Parse(Console.ReadLine()!);
            Console.Clear();

            switch (option)
            {
                case 1:
                    List();
                    break;

                case 2:
                    ReadWithRoles();
                    break;

                default: Load(); break;
            }
            //List();
            //ReadWithRoles();
            Console.ReadKey();
            MenuUserScreen.Load();
        }

        private static void List()
        {
            System.Console.WriteLine("Lista de Users");
            System.Console.WriteLine("------------------");

            var respository = new Repository<User>(Database.Connection);
            var users = respository.Get();
            foreach (var item in users)
            {
                System.Console.WriteLine($"{item.Id} - {item.Name} - {item.Email} - {item.Bio} - {item.Image} - ({item.Slug})");
            }

        }

        private static void ReadWithRoles()
        {
            System.Console.WriteLine("Lista de User com E-mail e Perfis");
            System.Console.WriteLine("------------------");

            var repository = new UserRepository(Database.Connection);
            var users = repository.GetWithRoles();

            foreach (var user in users)
            {
                Console.Write(user.Name + ", " + user.Email);
                foreach (var role in user.Roles) Console.Write($", {role.Name}");
                System.Console.WriteLine();
            }
        }

    }
}

using System;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.UserScreens
{
    public static class DeleteUserScreen
    {
        public static void Load()
        {
            Console.Clear();

            System.Console.WriteLine("Excluir um user");
            System.Console.WriteLine("------------------");
            System.Console.Write("Qual o Id do User que deve ser excluido: ");
            var id = Console.ReadLine();

            Delete(int.Parse(id));
            Console.ReadKey();
            MenuUserScreen.Load();
        }
        public static void Delete(int id)
        {
            try
            {
                var repository = new Repository<User>(Database.Connection);
                repository.Delete(id);
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
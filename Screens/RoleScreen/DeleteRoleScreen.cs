using System;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.RoleScreens
{
    public static class DeleteRoleScreen
    {
        public static void Load()
        {
            Console.Clear();

            System.Console.WriteLine("Excluir um perfil");
            System.Console.WriteLine("------------------");
            System.Console.Write("Qual o Id do perfil que deve ser excluido: ");
            var id = Console.ReadLine();

            Delete(int.Parse(id));
            Console.ReadKey();
            MenuRoleScreen.Load();
        }
        public static void Delete(int id)
        {
            try
            {
                var repository = new Repository<Role>(Database.Connection);
                repository.Delete(id);
                System.Console.WriteLine("Perfil excluido com sucesso!");
            }

            catch (Exception ex)
            {
                System.Console.WriteLine("Não foi possível excluir o perfil");
                System.Console.WriteLine(ex.Message);
            }
        }
    }
}
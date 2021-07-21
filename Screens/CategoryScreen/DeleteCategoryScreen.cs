using System;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.CategoryScreens
{
    public static class DeleteCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();

            System.Console.WriteLine("Excluir uma category");
            System.Console.WriteLine("------------------");
            System.Console.Write("Qual o Id da Category que deve ser excluida: ");
            var id = Console.ReadLine();

            Delete(int.Parse(id));
            Console.ReadKey();
            MenuCategoryScreen.Load();
        }
        public static void Delete(int id)
        {
            try
            {
                var repository = new Repository<Category>(Database.Connection);
                repository.Delete(id);
                System.Console.WriteLine("Category excluida com sucesso!");
            }

            catch (Exception ex)
            {
                System.Console.WriteLine("Não foi possível excluir a category");
                System.Console.WriteLine(ex.Message);
            }
        }
    }
}
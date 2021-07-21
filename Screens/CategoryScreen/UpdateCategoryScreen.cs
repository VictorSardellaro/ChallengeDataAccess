using System;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.CategoryScreens
{
    public static class UpdateCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();

            System.Console.WriteLine("Atualizando uma category");
            System.Console.WriteLine("------------------");

            System.Console.Write("Id: ");
            var id = Console.ReadLine();

            System.Console.Write("Name: ");
            var name = Console.ReadLine();

            System.Console.Write("Slug: ");
            var slug = Console.ReadLine();

            Update(new Category
            {
                Id = int.Parse(id),
                Name = name,
                Slug = slug
            });
            Console.ReadKey();
            MenuCategoryScreen.Load();
        }
        public static void Update(Category category)
        {
            try
            {
                var repository = new Repository<Category>(Database.Connection);
                repository.Update(category);
                System.Console.WriteLine("Category atualizada com sucesso!");
            }

            catch (Exception ex)
            {
                System.Console.WriteLine("Não foi possível atualizar a category");
                System.Console.WriteLine(ex.Message);
            }
        }
    }
}

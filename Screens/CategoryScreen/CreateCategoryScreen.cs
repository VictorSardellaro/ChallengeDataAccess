using System;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.CategoryScreens
{
    public static class CreateCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();

            System.Console.WriteLine("Nova category");
            System.Console.WriteLine("------------------");
            System.Console.Write("Name: ");
            var name = Console.ReadLine();
            System.Console.Write("Slug: ");
            var slug = Console.ReadLine();

            Create(new Category
            {
                Name = name,
                Slug = slug
            });
            Console.ReadKey();
            MenuCategoryScreen.Load();
        }

        public static void Create(Category category)
        {
            try
            {
                var repository = new Repository<Category>(Database.Connection);
                repository.Create(category);
                System.Console.WriteLine("Category cadastrada com sucesso!");
            }

            catch (Exception ex)
            {
                System.Console.WriteLine("Não foi possível salvar a category");
                System.Console.WriteLine(ex.Message);
            }
        }
    }
}
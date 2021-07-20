using System;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.TagScreens
{
    public static class UpdateTagScreen
    {
        public static void Load()
        {
            Console.Clear();

            System.Console.WriteLine("Atualizando uma tag");
            System.Console.WriteLine("------------------");

            System.Console.Write("Id: ");
            var id = Console.ReadLine();

            System.Console.Write("Name: ");
            var name = Console.ReadLine();

            System.Console.Write("Slug: ");
            var slug = Console.ReadLine();

            Update(new Tag
            {
                Id = int.Parse(id),
                Name = name,
                Slug = slug
            });
            Console.ReadKey();
            MenuTagScreen.Load();
        }
        public static void Update(Tag tag)
        {
            try
            {
                var repository = new Repository<Tag>(Database.Connection);
                repository.Update(tag);
                System.Console.WriteLine("Tag atualizada com sucesso!");
            }

            catch (Exception ex)
            {
                System.Console.WriteLine("Não foi possível atualizar a tag");
                System.Console.WriteLine(ex.Message);
            }
        }
    }
}

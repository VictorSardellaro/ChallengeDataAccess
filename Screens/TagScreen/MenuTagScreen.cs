using System;

namespace Blog.Screens.TagScreens
{
    public static class MenuTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            System.Console.WriteLine("Gestão de tags");
            System.Console.WriteLine("------------------");
            System.Console.WriteLine("O que deseja fazer?");
            System.Console.WriteLine();
            System.Console.WriteLine("1 - Listar tags");
            System.Console.WriteLine("2 - Cadastrar tags");
            System.Console.WriteLine("3 - Atualizar tags");
            System.Console.WriteLine("4 - Excluir tags");
            System.Console.WriteLine();
            System.Console.WriteLine();
            var option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    ListTagScreen.Load();
                    break;
                case 2:
                    CreateTagScreen.Load();
                    break;
                case 3:
                    UpdateTagScreen.Load();
                    break;
                case 4:
                    DeleteTagScreen.Load();
                    break;

                default: Load(); break;
            }


        }

    }
}
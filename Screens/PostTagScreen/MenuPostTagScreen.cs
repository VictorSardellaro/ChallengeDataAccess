using System;

namespace Blog.Screens.PostTagScreens
{
    public static class MenuPostTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            System.Console.WriteLine("Gestão de Users com Perfil");
            System.Console.WriteLine("------------------");
            System.Console.WriteLine("O que deseja fazer?");
            System.Console.WriteLine();
            System.Console.WriteLine("1 - Vincular User com Perfil");
            System.Console.WriteLine("2 - Excluir Vinculo de User com Perfil");
            System.Console.WriteLine();
            System.Console.WriteLine();
            var option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    CreatePostTagScreen.Load();
                    break;
                case 2:
                    DeletePostTagScreen.Load();
                    break;

                default: Load(); break;
            }


        }

    }
}
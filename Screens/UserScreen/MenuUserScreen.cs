using System;

namespace Blog.Screens.UserScreens
{
    public static class MenuUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            System.Console.WriteLine("Gestão de Users");
            System.Console.WriteLine("------------------");
            System.Console.WriteLine("O que deseja fazer?");
            System.Console.WriteLine();
            System.Console.WriteLine("1 - Listar Users");
            System.Console.WriteLine("2 - Cadastrar Users");
            System.Console.WriteLine("3 - Atualizar Users");
            System.Console.WriteLine("4 - Excluir Users");
            System.Console.WriteLine();
            System.Console.WriteLine();
            var option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    ListUserScreen.Load();
                    break;
                case 2:
                    CreateUserScreen.Load();
                    break;
                case 3:
                    UpdateUserScreen.Load();
                    break;
                case 4:
                    DeleteUserScreen.Load();
                    break;

                default: Load(); break;
            }


        }

    }
}
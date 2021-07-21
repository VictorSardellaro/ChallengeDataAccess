using System;

namespace Blog.Screens.UserRoleScreens
{
    public static class MenuUserRoleScreen
    {
        public static void Load()
        {
            Console.Clear();
            System.Console.WriteLine("Gestão de Users com Perfil");
            System.Console.WriteLine("------------------");
            System.Console.WriteLine("O que deseja fazer?");
            System.Console.WriteLine();
            System.Console.WriteLine("1 - Listar Users por Perfil");
            System.Console.WriteLine("2 - Vincular User com Perfil");
            System.Console.WriteLine("4 - Excluir Vinculo de User com Perfil");
            System.Console.WriteLine();
            System.Console.WriteLine();
            var option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    ListUserRoleScreen.Load();
                    break;
                case 2:
                    CreateUserRoleScreen.Load();
                    break;
                case 3:
                    //UpdateUserRoleScreen.Load();
                    break;
                case 4:
                    DeleteUserRoleScreen.Load();
                    break;

                default: Load(); break;
            }


        }

    }
}
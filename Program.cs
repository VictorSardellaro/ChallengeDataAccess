﻿using System;
using Microsoft.Data.SqlClient;

namespace Blog
{
    class Program
    {
        private const string CONNECTION_STRING = @"Server=localhost, 1433; Database=Blog;User ID=sa;Password=1q2w3e4r@#$";

        static void Main(string[] args)
        {
            Database.Connection = new SqlConnection(CONNECTION_STRING);
            Database.Connection.Open();

            Load();

            Console.ReadKey();
            Database.Connection.Close();
        }

        private static void Load()
        {
            Console.Clear();
            System.Console.WriteLine("Meu Blog");
            System.Console.WriteLine("------------------");
            System.Console.WriteLine("O que deseja fazer?");
            System.Console.WriteLine();
            System.Console.WriteLine("1 - Gestão de usuário");
            System.Console.WriteLine("2 - Gestão de perfil");
            System.Console.WriteLine("3 - Gestão de categoria");
            System.Console.WriteLine("4 - Gestão de tag");
            System.Console.WriteLine("5 - Criar Post");
            System.Console.WriteLine("6 - Vincular perfil/usuário");
            System.Console.WriteLine("7 - Vincular post/tag");
            System.Console.WriteLine("8 - Relatórios");
            System.Console.WriteLine();
            System.Console.WriteLine();
            var option = short.Parse(Console.ReadLine()!);

            switch (option)
            {
                case 1:
                    Screens.UserScreens.MenuUserScreen.Load();
                    break;
                case 2:
                    Screens.RoleScreens.MenuRoleScreen.Load();
                    break;
                case 3:
                    Screens.CategoryScreens.MenuCategoryScreen.Load();
                    break;
                case 4:
                    Screens.TagScreens.MenuTagScreen.Load();
                    break;
                case 5:
                    Screens.PostScreens.MenuPostScreen.Load();
                    break;
                case 6:
                    Screens.UserRoleScreens.MenuUserRoleScreen.Load();
                    break;

                default: Load(); break;
            }
        }
    }
}

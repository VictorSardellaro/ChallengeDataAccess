﻿using System;
using Microsoft.Data.SqlClient;

namespace Blog
{
    class Program
    {
        private const string CONNECTION_STRING = @"Server=localhost, 1433; Database=Blog;User ID=sa;Password=1q2w3e4r@#$";

        static void Main(string[] args)
        {
            var connection = new SqlConnection(CONNECTION_STRING);
            connection.Open();

            Load();

            Console.ReadKey();
            connection.Close();
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
            System.Console.WriteLine("5 - Vincular perfil/usuário");
            System.Console.WriteLine("6 - Vincular post/tag");
            System.Console.WriteLine("7 - Relatórios");
            System.Console.WriteLine();
            System.Console.WriteLine();
            var option = short.Parse(Console.ReadLine()!);

            switch (option)
            {
                case 4:
                    Screens.TagScreens.MenuTagScreen.Load();
                    break;
                default: Load(); break;
            }
        }
    }
}

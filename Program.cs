using System;
using System.Threading;
using EditorDeTags.Screens.TagScreens;
using Microsoft.Data.SqlClient;

namespace EditorDeTags
{
    class Program
    {
        private const string CONNECTION_STRING = @"Server=MATHEUS;Database=Blog;User ID=sa;Password=123456";

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
            Console.WriteLine("Meu Blog");
            Console.WriteLine("=====================");
            Console.WriteLine("O que deseja fazer?\n");
            Console.WriteLine("1 - Gestão de usuário");
            Console.WriteLine("2 - Gestão de perfil");
            Console.WriteLine("3 - Gestão de categoria");
            Console.WriteLine("4 - Gestão de tag");
            Console.WriteLine("5 - Vincular perfil/usuário");
            Console.WriteLine("6 - Vincular post/tag");
            Console.WriteLine("7 - Relatórios\n\n");
            var option = short.Parse(Console.ReadLine()!);

            switch (option)
            {
                case 4:
                    MenuTagScreen.Load();
                    break;
                default:
                    Console.WriteLine("Disponivel apenas opção 4\nAguarde para retorno ao menu principal");
                    Thread.Sleep(1500);
                    Load();
                    break;
            }
        }
    }
}
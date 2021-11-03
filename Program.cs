using System;

namespace Senha
{
    class Program
    {
        static void Main(string[] args)
        {

            string senha, acesso;

            Console.Write("Olá, usuário! Por favor, digite sua senha: ");
            senha = Console.ReadLine();
            Console.WriteLine();

            if(senha == "1234abcd"){
                Console.ForegroundColor = ConsoleColor.Green;
                acesso = "Acesso permitido";
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                acesso = "Acesso negado";
            }
            Console.WriteLine($"{acesso}!");
            Console.ResetColor();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    internal class EstruturaDoWhile
    {
        public static void Executar()
        {
            string entrada;

            do {
                Console.Write("Qual é o seu nome? ");
                entrada = Console.ReadLine();

                Console.WriteLine($"Seja bem vindo(a)! {entrada}");
                Console.Write("Deseja continuar?(S/N) ");
                entrada = Console.ReadLine();

                Console.Clear(); // método para limpar o console

            } while (entrada.ToLower().First() == 's');

            Console.WriteLine("Até mais");
        }
    }
}

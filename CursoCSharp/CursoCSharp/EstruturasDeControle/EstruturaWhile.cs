using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CursoCSharp.EstruturasDeControle
{
    internal class EstruturaWhile
    {
        public static void Executar()
        {
            int palpite = 0;
            Random random = new Random();

            int numeroSecreto = random.Next(1, 16);
            bool numeroEncontrado = false;
            int tentativasRestantes = 5;
            int tentativas = 0;
            bool decisao = false;

            Console.WriteLine("Você tem 5 tentativas de achar um número entre 1 e 15.");
            Console.Write("Quer jogar o jogo de advinha o número (S/N)? ");
            string entradaInicial = Console.ReadLine();

            if (decisao = entradaInicial.ToLower().First() == 's') {

                while (tentativasRestantes > 0 && !numeroEncontrado) {
                    Console.Write("Insira o seu palpite: ");
                    string entrada = Console.ReadLine();
                    int.TryParse(entrada, out palpite);

                    tentativas++;
                    tentativasRestantes--;

                    if (numeroSecreto == palpite) {
                        numeroEncontrado = true;
                        var corAnterior = Console.BackgroundColor;
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Acertou! o número é: {numeroSecreto}. Conseguiu em: {tentativas} tentativas!");
                        Console.BackgroundColor = corAnterior;
                    }
                    else if (palpite > numeroSecreto) {
                        var corAnterior = Console.BackgroundColor;
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Tente um número menor!");
                        Console.BackgroundColor = corAnterior;
                        Console.WriteLine($"Tentativas restantes: {tentativasRestantes} {numeroSecreto}");
                    }
                    else if (palpite < numeroSecreto) {
                        var corAnterior = Console.BackgroundColor;
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Tente um número maior!");
                        Console.BackgroundColor = corAnterior;
                        Console.WriteLine($"Tentativas restantes: {tentativasRestantes} {numeroSecreto}");
                    }
                }
                if (tentativasRestantes == 0 && !numeroEncontrado) {
                    Console.WriteLine($"O número secreto era: {numeroSecreto}");
                }
            }
            Console.WriteLine("Até mais");
        }
    }
}
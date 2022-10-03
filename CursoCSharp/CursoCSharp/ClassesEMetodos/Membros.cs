using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class Membros
    {
        public static void Executar()
        {
            Pessoa sicrano = new Pessoa();
            sicrano.Nome = "Aysha";
            sicrano.Idade = 21;

            //Console.WriteLine($"{sicrano.Nome} tem {sicrano.Idade} anos.");

            sicrano.ApresentarNoConsole();

            Pessoa fulano = new Pessoa();
            fulano.Nome = "Gabriel";
            fulano.Idade = 21;

            var apresentacaoDofulano = fulano.Apresentar();
            Console.WriteLine(apresentacaoDofulano.Length);
            Console.WriteLine(apresentacaoDofulano);
        }
    }
}

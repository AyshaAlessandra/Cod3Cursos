using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Encapsulamentos;


namespace CursoCSharp.OO
{
    public class FilhoNaoReconhecido : SubCelebridade
    {
        public new void MeusAcessos()
        {
            Console.WriteLine("FilhoNãoReconhecido...");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(JeitoDeFalar);
        }
    }

    public class AmigoDistante
    {
        public readonly SubCelebridade amiga = new SubCelebridade();

        public void MeusAcessos()
        {
            Console.WriteLine("AmigoDistante...");

            Console.WriteLine(amiga.InfoPublica);
        }
    }

    internal class Encapsulamento
    {
        public static void Executar()
        {
            SubCelebridade sub = new SubCelebridade();
            sub.MeusAcessos();
            Console.WriteLine("\n");

            new FilhoReconhecido().MeusAcessos();
            Console.WriteLine("\n");

            new AmigoProximo().MeusAcessos();
            Console.WriteLine("\n");

            new FilhoNaoReconhecido().MeusAcessos();
            Console.WriteLine("\n");

            new AmigoDistante().MeusAcessos();
            Console.WriteLine("\n");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public enum Genero {Acao, Aventura, Terro, Animacao, Comedia};

    public class Filme
    {
        public string Titulo;
        public Genero GeneroDoFilme;
    }

    internal class ExemploEnum
    {
        public static void Executar()
        {
            int id = (int)Genero.Animacao;
            Console.WriteLine(id);

            Filme filmeParaFamilia = new Filme();
            filmeParaFamilia.Titulo = "Sing 2";
            filmeParaFamilia.GeneroDoFilme = Genero.Animacao;
            Console.WriteLine($"O filme {filmeParaFamilia.Titulo} é" +
                $" {filmeParaFamilia.GeneroDoFilme}.");
        }
    }
}

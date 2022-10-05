using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    internal class ColecoesDictionary
    {
        /*Dictionary aceita repetição no valor mas não aceita repetição na chave.
         */
        public static void Executar()
        {
            var filmes = new Dictionary<int, string>();

            filmes.Add(2000, "Gladiadoor");
            filmes.Add(2002, "Homem-Aranha");
            filmes.Add(2004, "Os Incríveis");
            filmes.Add(2006, "O Grande Truque");

            if (filmes.ContainsKey(2004)) {
                Console.WriteLine("2004: " + filmes[2004]);
            }

            Console.WriteLine(filmes.ContainsValue("Amnésia"));

            Console.WriteLine($"Removeu? {filmes.Remove(2006)}");

            filmes.TryGetValue(2006, out string filme2006);
            Console.WriteLine($"Filme: {filme2006}");

            //Percorrer apenas chave
            foreach(var chave in filmes.Keys) {
                Console.WriteLine($"Chave: {chave}");
            }

            //Percorrer apenas valores
            foreach(var valor in filmes.Values) {
                Console.WriteLine($"Valor: {valor}");
            }

            //Percorrer chave e valor ao mesmo tempo
            foreach(KeyValuePair<int, string> filme in filmes) {
                Console.WriteLine($"{filme.Value} é de {filme.Key}.");
            }
            
            //Percorre a chave e o valor de modo mais simples
            foreach(var filme in filmes) {
                Console.WriteLine($"{filme.Value} é de {filme.Key}.");
            }
        }
    }
}

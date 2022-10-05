using System;
using System.Collections;

namespace CursoCSharp.Colecoes
{
    internal class ColecoesArrayList
    {/*ArrayList é uma estrutura Heteroneo, aceita multiplos tipos de valores dentro dela.
      */
        public static void Executar()
        {
            var arraylist = new ArrayList {
                "Palavra",
                3,
                true
            };

            arraylist.Add(3.14);

            foreach (object item in arraylist) {
                Console.WriteLine("{0} => {1}",item, item.GetType());
            }
        }
    }
}

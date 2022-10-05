using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    internal class Igualdade
    {

        /*Para não comparar mais endereço de memória, deve fazer um override em produto
         */
        public static void Executar()
        {
            Produto p1 = new Produto("Caneta", 1.89);
            Produto p2 = new Produto("Caneta", 1.89);
            var p3 = p2;

            //aqui estão apontando para espaço de memória diferente
            Console.WriteLine(p1 == p2);
            //aqui está apontando para o mesmo espaço na memória
            Console.WriteLine(p3 == p2);

            Console.WriteLine(p1.Equals(p2));
        }
    }
}

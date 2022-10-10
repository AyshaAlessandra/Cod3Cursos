using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{/*Delegate é quando define um tipo que armazena uma assinatura de uma função e esta assinatura
  uma vez sendo respeitada, consegue criar uma variável do tipo do delegate e colocar uma funçao 
  que repeite a assinatura*/
    //da para colocar o delegate dentro da classe ou fora dela. Ele é um tipo

    delegate double Operacao(double x, double y);

    internal class LambdasDelegate
    {
        public static void Executar()
        {
            Operacao sum = (x, y) => x + y;
            Operacao sub = (x, y) => x - y;
            Operacao mult = (x, y) => x * y;

            Console.WriteLine(sum(3,3));
            Console.WriteLine(sub(5,2));
            Console.WriteLine(mult(12,8));
        }
    }
}

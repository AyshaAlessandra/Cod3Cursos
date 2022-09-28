using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OperadoresAtribuicao
    {
        public static void Executar()
        {
            int num1 = 3;
            num1 += 10; //num1 = num1 + 10;
            num1 -= 3; //num1 = num1 - 3;
            num1 *= 5; // num1 = num1 * 5;
            num1 /= 2; // num1 = num1 / 2;

            Console.WriteLine(num1);
            
            //Atricuiçao feita por valor
            int a = 1;
            int b = a;

            a++; // a = a + 1; (incremento)
            b--; // b = b - 1; (decremento)

            Console.WriteLine($"{a} {b}");

            //atribuição feita por referência
            dynamic c = new System.Dynamic.ExpandoObject();
            c.nome = "João";

            dynamic d = c;
            d.nome = "Maria";

            Console.WriteLine(c.nome);
        }
    }
}

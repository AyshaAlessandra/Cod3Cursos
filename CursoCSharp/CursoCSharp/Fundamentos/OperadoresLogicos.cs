using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OperadoresLogicos
    {
        public static void Executar()
        {
            var executouTrabalho1 = true;
            var executouTrabalho2 = false;

            var comprouTv50 = executouTrabalho1 && executouTrabalho2;
            Console.WriteLine($"Comprou a TV de 50 polegadas? {comprouTv50}");

            bool comprouSorvete = executouTrabalho1 || executouTrabalho2;
            Console.WriteLine($"Comprou o sorvete? {comprouSorvete}");

            bool comprouTv32 = executouTrabalho1 ^ executouTrabalho2;
            Console.WriteLine($"Comprou TV 32 polegadas? {comprouTv32}");

            Console.WriteLine($"Mais saudável? {!comprouSorvete}");

            /*
             Operadores binários são operadores que trabalham em cima de dois operando.
             Operadores unário são operadores que trabalham em cima de um operando.
             Operadores ternário são operadores que trablham em cima de três operando.
             */
        }
    }
}

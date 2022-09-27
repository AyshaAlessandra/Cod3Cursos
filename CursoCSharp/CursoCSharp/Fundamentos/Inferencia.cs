using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class Inferencia
    {
        public static void Executar()
        {
          /* É obrigatório inicializar uma várivavel do tipo implicita 'var', se eu apenas declarar
           * da erro. Isso acontece porque o C# vai identificar por d'baixo dos panos, qual tipo
           * é a variável e irá atribuir o tipo certo.
           */

            var nome = "Aysha";
            //nome = 123
            Console.WriteLine($"Nome: {nome}");

            //int idade;
            var idade = 21;
            Console.WriteLine($"Idade: {idade}");

            int a;
            a = 7;

            int b = 4;
            Console.WriteLine($"Soma: {a + b}");
        }
    }
}

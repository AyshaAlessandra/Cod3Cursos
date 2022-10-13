using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados
{
    internal class Nullables
    {
        public static void Executar()
        {
            //há essas duas possibilidades de criar um nullable
            Nullable<int> num1 = null;
            int? num2 = null;

            if (num1.HasValue) {
                Console.WriteLine($"Valor de num: {num1}");
            }
            else {
                Console.WriteLine("A variável não possui valor.");
            }

            //Quando eu quiser setar um num dentro de um valor inteiro e ele estiver nulo, vai usar o valor padrão no qual eu colocar.
            int valor = num1 ?? 1000;
            Console.WriteLine(valor);

            bool? booleana = null;
            bool resultado = booleana.GetValueOrDefault();
            Console.WriteLine(resultado);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    internal class ExemploLambda
    {//lambda é uma função anonima. E esta função, esta sendo armazenada na variável algoNoConsole
     //Action é uma função que não tem retorno(void).
        public static void Executar()
        {
            Action algoNoConsole = () => {
                Console.WriteLine("Lambda com C#!");
            };

            algoNoConsole();

            Func<int> jogarDado = () => {
                Random random = new Random();
                return random.Next(1, 7);
            };

            Console.WriteLine(jogarDado());

            Func<int, string> conversorHex = (numero) => numero.ToString("X");
            Console.WriteLine(conversorHex(1234));

            //ele recebe 3 parâmetros e retorna uma string
            Func<int, int, int, string> formatarData = (dia, mes, ano) =>
                String.Format("{0:D2}/{1:D2}/{2:D4}", dia, mes, ano);
            Console.WriteLine(formatarData(1,5,2022));

        }
    }
}

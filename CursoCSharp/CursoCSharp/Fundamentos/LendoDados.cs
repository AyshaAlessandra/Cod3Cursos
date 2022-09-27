using System;
using System.Globalization;


namespace CursoCSharp.Fundamentos
{
    internal class LendoDados
    {
        public static void Executar()
        {
            Console.Write("Qual é o seu nome? ");
            string nome = Console.ReadLine();

            Console.Write("Me informe sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Qual é o seu salário? ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
           
            /* CultureInfo.InvariantCulture, serve para trocar o ponto por vírgula na hora
             * da digitação. Para usar ele, precisa por o System.Globalization.
             */

            Console.WriteLine($"{nome} tem {idade} anos e recebe {salario} reais.");
        }
    }
}

using System;
using System.Globalization;


namespace CursoCSharp.Fundamentos
{
    internal class FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F2"));//formatar com apenas uma ou mais casas decimais.
            Console.WriteLine(valor.ToString("C"));//formatar em valor monetário de acordo com o sistema que usa.
            Console.WriteLine(valor.ToString("P"));//Percentual, multiplicou o valor por 100.
            Console.WriteLine(valor.ToString("#.##"));//Defini um formato com duas casas decimais.
            
            CultureInfo cultura = new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("C0", cultura));
            /*C0 - formata em dinheiro sem nenhuma casa decimal e depois disse a cultura no qual
             * o programa vai se comportar.
             */

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10"));//completa com zeros na esquerda até
            //completar a quantidade de caracteres necessárias para que o número fique com 10 posições.
        }
    }
}

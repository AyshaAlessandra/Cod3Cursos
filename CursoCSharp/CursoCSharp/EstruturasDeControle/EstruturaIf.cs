using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    internal class EstruturaIf
    {
        public static void Executar()
        {
            bool bomComportamento = false;
            string entrada;

            Console.WriteLine("Digite a nota do aluno: ");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            Console.WriteLine("Possui bom comportamento (S/N): ");
            entrada = Console.ReadLine();

            //if (entrada == "S" || entrada == "s")
            //    bomComportamento = true;

            //bomComportamento = entrada == "S" || entrada == "s";

            bomComportamento = entrada.ToLower().First() == 's';

            if (nota > 10.0 || nota < 0) {
                Console.WriteLine("A nota não pode ser maior que 10 e negativa!");
            };

            if (nota >= 9.0 && bomComportamento) {
                Console.WriteLine("Quadro de honra!");
            };
        }
    }
}

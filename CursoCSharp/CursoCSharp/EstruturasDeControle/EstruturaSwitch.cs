using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    internal class EstruturaSwitch
    {
        public static void Executar()
        {
            Console.Write("Avalie o atendimento com nota de 0 a 5: ");
            int.TryParse(Console.ReadLine(), out int nota);

            switch (nota) {
                case 0:
                    Console.WriteLine("Péssimo");
                    break;
                case 1:
                    Console.WriteLine("Ruim");
                    break;
                case 2:
                    Console.WriteLine("Regular");
                    break;
                case 3:
                    Console.WriteLine("Bom");
                    break;
                case 4:
                    Console.WriteLine("Ótimo");
                    break;
                case 5:
                    Console.WriteLine("Exelente");
                    break;
                default: 
                    Console.WriteLine("Nota inválida");
                    break;
            }

            Console.WriteLine("Obrigada por responder!");
        }
    }
}

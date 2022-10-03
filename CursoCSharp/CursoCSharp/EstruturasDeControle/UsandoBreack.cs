using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    internal class UsandoBreack
    {
        public static void Executar()
        {
            Random random = new Random();
            int numero = random.Next(1, 51);

            Console.WriteLine($"O número que queremos é {numero}.");

            for (int i = 1; i <= 50; i++) {
                Console.Write($"{i} é o número que queremos? ");
                if (i== numero) {
                    Console.WriteLine("Sim!");
                    break;
                }
                else {
                    Console.WriteLine("Não!");
                }
            }

            Console.WriteLine("Fim!");
        }
    }
}
// breack está associado ao swich ou a um laço de repetição e não ao um bloco if.
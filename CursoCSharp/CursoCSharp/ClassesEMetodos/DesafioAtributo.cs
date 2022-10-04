using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class DesafioAtributo
    {
        //atributo de instancia
        int a = 10;

        //atributo de classe 
        public static void Executar()
        {
            DesafioAtributo desafioAtributo = new DesafioAtributo();

            Console.WriteLine(desafioAtributo.a);
        }
    }
}
/*Um método que pertence a classe não consegue acessar um atributo de instancia.
 * Então precisisei criar uma instancia do da classe na qual estava.
 */
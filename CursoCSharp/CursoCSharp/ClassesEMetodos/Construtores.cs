using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{   
    class Carro
    {
        public string Modelo;
        public string Fabricante;
        public int Ano;

        //construtor com parametro
        public Carro (string modelo, string fabricante, int ano)
        {
            Modelo = modelo;
            Fabricante = fabricante;
            Ano = ano;
        }
        //construtor padrão
        public Carro()
        {

        }
    }
    internal class Construtores
    {
        public static void Executar()
        {
            //construtor padrão
            Carro carro1 = new Carro();
            carro1.Fabricante = "BMW";
            carro1.Modelo = "325i";
            carro1.Ano = 2017;
            Console.WriteLine($"{carro1.Fabricante} {carro1.Modelo} {carro1.Ano}");

            //construtor com parametro
            Carro carro2 = new Carro("Ka", "Ford", 2018);
            Console.WriteLine($"{carro2.Fabricante} {carro2.Modelo} {carro2.Ano}");

        }
    }
}
/*construtor padrão só existe em duas situações, quando não há nenhum contrutor 
 * ou quando define ele de forma explicita, o que não recebe nenhum parametro
 */

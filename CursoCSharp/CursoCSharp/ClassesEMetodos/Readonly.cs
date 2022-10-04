using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class Cliente
    {/*Para usar a const, precisa inicializa -lá. Como estou inicializando no construtor
      * usei o readonly, ele é imutável assim que setar algo. A const é avaliado no tempo de
      * compilação do programa por isso precisa inicializa-la com algum valor. 
      * A readonly é avaliado no tempo de execução do programa, então não precisa inicializar
      * com um valor.
      */

        public string Nome;
        readonly DateTime Nascimento;

        public Cliente(string nome, DateTime nascimento)
        {
            Nome = nome;
            Nascimento = nascimento;
        }

        public string GetDataDeNascimento()
        {
            return String.Format("{0}/{1}/{2}", Nascimento.Day,
                Nascimento.Month, Nascimento.Year);
        }
    }

    internal class Readonly
    {
        public static void Executar()
        {
            Cliente novoCliente = new Cliente("Ana Silva", new DateTime(1987, 5, 22));
            Console.WriteLine(novoCliente.Nome);
            Console.WriteLine(novoCliente.GetDataDeNascimento());
        }
    }
}

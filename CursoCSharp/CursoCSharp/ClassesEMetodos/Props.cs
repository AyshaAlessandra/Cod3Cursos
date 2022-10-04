using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class CarroOpcional
    {//quando não coloca o public na frente, ele por padrão já é private.

        double desconto = 0.1;
        string nome;
        public string Nome {
            get {
                return "Opcional: " + nome;
            }
            set {
                nome = value;
            }
        }

        //Propriedade autoimplementada
        public double Preco { get; set; }

        //Somente leitura
        public double PrecoComDesconto {
            //get {
            //    return Preco - (desconto * Preco);
            //}

            get => Preco - (desconto * Preco); // lambida
        }

        public CarroOpcional(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public CarroOpcional()
        {

        }
    }

    internal class Props
    {
        public static void Executar()
        {
            CarroOpcional op1 = new CarroOpcional("Ar Condicionado", 3499.9);
            Console.WriteLine(op1.Nome);
            Console.WriteLine("Preço: " + op1.Preco);
            Console.WriteLine("Preço com desconto: " + op1.PrecoComDesconto);

            CarroOpcional op2 = new CarroOpcional("Direção Elétrica", 2349.9);
            Console.WriteLine(op2.Nome);
            Console.WriteLine("Preço: " + op2.Preco);
            Console.WriteLine("Preço com desconto: " + op2.PrecoComDesconto);
        }
    }
}

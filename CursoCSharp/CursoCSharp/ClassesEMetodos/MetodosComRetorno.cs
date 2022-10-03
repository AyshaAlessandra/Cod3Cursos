using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class CalculadordaComum
    {
        public int Somar(int a, int b)
        {
            return a + b;
        }

        public int Subtrair(int a, int b)
        {
            return a - b;
        }

        public int Multiplicar(int a, int b)
        {
            return a * b;
        }

        public double Divisao(double a, double b)
        {
            return a / b;
        }
    }
    internal class MetodosComRetorno
    {
        public static void Executar()
        {
            CalculadordaComum calculadoraComum = new CalculadordaComum();
            int resultado = calculadoraComum.Somar(5, 5);
            Console.WriteLine("Soma: " +resultado);

            Console.WriteLine("Subtração: " + calculadoraComum.Subtrair(2,7));
            Console.WriteLine("Multiplicação: " + calculadoraComum.Multiplicar(4,4));
            Console.WriteLine("Divisão: " + calculadoraComum.Divisao(10,2));
        }
    }
}

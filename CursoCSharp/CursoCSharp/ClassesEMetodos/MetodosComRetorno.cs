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

    class CalculadoraCadeia
    {
        int memoria;

        public CalculadoraCadeia Somar(int a)
        {
            memoria += a;
            return this;
        }

        public CalculadoraCadeia Subtrair(int a)
        {
            memoria -= a;
            return this;
        }

        public CalculadoraCadeia Multiplicar(int a)
        {
            memoria *= a;
            return this;
        }

        public CalculadoraCadeia Limpar()
        {
            memoria = 0;
            return this;
        }

        public CalculadoraCadeia Imprimir()
        {
            Console.WriteLine(memoria);
            return this;
        }

        public int Resultado()
        {
            return memoria;
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

            //calculadora Cadeia
            var calculadoraCadeia = new CalculadoraCadeia();
            Console.WriteLine("calculadora cadeia");
            calculadoraCadeia.Somar(3).Multiplicar(3).Imprimir().Limpar().Imprimir();
        }
    }
}

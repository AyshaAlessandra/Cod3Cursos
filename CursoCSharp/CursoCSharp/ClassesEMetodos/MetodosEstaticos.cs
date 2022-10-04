using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class CalculadoraEstatica
    {
        //se o atributo for transformado em estático,em vez dele pertencer a cada uma das
        //instâncias ou objeto, ele irá pertencer a classe, com isso, ele vai ter uma única cópia,
        //ou seja, ele vai ter um único valor compartilhado na memória.

        //Método de instância
        public int Somar(int a, int b)
        {
            return a + b;
        }
        //Método de Classe ou Método estático
        public static int Multiplicar(int a, int b)
        {
            return a * b;
        }
    }
    internal class MetodosEstaticos
    {
        public static void Executar()
        {
            var resultado = CalculadoraEstatica.Multiplicar(2, 2);
            Console.WriteLine($"Resultado Multiplicação: {resultado}");

            CalculadoraEstatica calc = new CalculadoraEstatica();
            Console.WriteLine($"Resultado Soma: {calc.Somar(5,2)}");
        }
    }
}
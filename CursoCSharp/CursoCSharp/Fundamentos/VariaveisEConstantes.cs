using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class VariaveisEConstantes
    {
        public static void Executar()
        {
            // area da circunferencia
            double raio = 4.5;
            const double PI = 3.14;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine($"A área é: {area}. [Modo de interpolação]");
            Console.WriteLine("A área é: " + area + ". [Modo de concatenação]");

            //Tipos internos

            bool estaChovendo = false;
            Console.WriteLine("Está chovendo? " + estaChovendo);

            byte idade = 45; // byte sem sinal
            Console.WriteLine($"idade: {idade}. ");

            sbyte saldoDeGols = sbyte.MinValue; // byte com sinal
            Console.WriteLine($"O saldo de gols é: {saldoDeGols}");

            short salario = short.MinValue;
            Console.WriteLine($"Salario: {salario}");

            int maiorValorDeInt = int.MaxValue; // Tipo mais usado dos inteiros. Int com sinal.
            Console.WriteLine($"Maior valor de int: {maiorValorDeInt}");

            uint populacaoBrasileira = 207_600_987; // aqui eu posso usar o anderline para "separar" e ter uma clareza dos números.
            //int  sem sinal
            Console.WriteLine($"A populaçao brasileira é de: {populacaoBrasileira}");

            long menorValorDeLong = long.MinValue; // long com sinal
            Console.WriteLine($"Menor valor de long: {menorValorDeLong}");

            ulong populacaoMundial = 7_543_234_089; // long sem sinal
            Console.WriteLine($"População mundial: {populacaoMundial}");

            float precoComputador = 1299.99f;
            Console.WriteLine($"Preço do computador: {precoComputador}");

            double valorDoMonitor = 14_568_721_568_578;
            Console.WriteLine($"Valor do monitor: {valorDoMonitor}");

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine($"Distancia entre as estrelas: {distanciaEntreEstrelas}");

            char letra = 'f';
            Console.WriteLine($"Letra: {letra}");

            string texto = "Esses são os tipos de variáveis no c#!";
            Console.WriteLine($"Texto: {texto}");
        }
    }
}

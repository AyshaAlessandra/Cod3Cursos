using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class Dependente
    {
        public string Nome;
        public int Idade;
    }

    internal class ValorVsReferencia
    {
        public static void Executar()
        {
            int numero = 3;
            int copiaNumero = numero;
            Console.WriteLine($"Numero: {numero}, Copia: {copiaNumero}");

            numero++;
            Console.WriteLine($"Numero: {numero}, Copia: {copiaNumero}");

            Dependente dependente = new Dependente {
                Nome = "Beto",
                Idade = 20
            };

            Dependente copiaDependente = dependente;

            Console.WriteLine($"Nome: {dependente.Nome}, Copia: {copiaDependente.Nome}");
            Console.WriteLine($"Idade: {dependente.Idade}, Copia: {copiaDependente.Idade}");

            copiaDependente.Nome = "Renan";
            dependente.Idade = 21;

            Console.WriteLine($"Nome: {dependente.Nome}, Copia: {copiaDependente.Nome}");
            Console.WriteLine($"Idade: {dependente.Idade}, Copia: {copiaDependente.Idade}");
        }
    }
}

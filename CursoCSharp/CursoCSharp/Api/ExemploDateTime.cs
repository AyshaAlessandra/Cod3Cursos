using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Api
{
    internal class ExemploDateTime
    {
        public static void Executar()
        {
            var dateTime = new DateTime(year: 2023, month: 2, day: 6);

            Console.WriteLine(dateTime.Day);
            Console.WriteLine(dateTime.Month);
            Console.WriteLine(dateTime.Year);

            //sem horas
            var hoje = DateTime.Today;
            Console.WriteLine(hoje);

            // com hora
            var diaAtual = DateTime.Now;
            Console.WriteLine(diaAtual);
            Console.WriteLine("Hora: " + diaAtual.Hour);
            Console.WriteLine("Minute: " + diaAtual.Minute);
            Console.WriteLine("Second: " + diaAtual.Second);

            //mostrar outro dia 
            var amanha = diaAtual.AddDays(1);
            Console.WriteLine("\nAmanhã: " + amanha);

            // dia anterior
            var ontem = diaAtual.AddDays(-1);
            Console.WriteLine("Ontem: " + ontem);

            //Formando a data em formatos diferentes
            Console.WriteLine("\n" + diaAtual.ToString("dd"));
            Console.WriteLine( diaAtual.ToString("d"));
            Console.WriteLine( diaAtual.ToString("D"));
            //dia atual com a hora e segundos
            Console.WriteLine(diaAtual.ToString("g"));
            Console.WriteLine(diaAtual.ToString("G"));
            Console.WriteLine("Modificando "+ diaAtual.ToString("dd-MM-yyyy HH:mm"));

        }
    }
}

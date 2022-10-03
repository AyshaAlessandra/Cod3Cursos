using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    internal class EstruturaForEach
    {
        public static void Executar()
        {
           
            var palavra = "Opa!";
            
            //aqui ele está percorrendo todas as letras dessa palavra
            foreach (var letra in palavra) {
                Console.WriteLine(letra);
            }

            //aqui percorre o array todo
            var alunos = new string[] { "Ana", "Bia", "Carlos" };
           
            foreach (string aluno in alunos) {
                Console.WriteLine(aluno);
            }
        }
    }
}

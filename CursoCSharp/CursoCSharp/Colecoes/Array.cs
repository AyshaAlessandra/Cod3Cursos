using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    internal class Array
    {/*Array é uma estrutura homogênia, ou seja, os dados serão sempre do mesmo tipo.
      * Também é estática, o array não cresce conforme colocamos algo dentro dele. Vai ter apenas
      * o tamanho que pré-determinamos (Tamanho fixo). Array é uma estrutura indexada, acessa 
      * os elementos a partir do índice.
      */
        public static void Executar()
        {
            string[] alunos = new string[5];
            alunos[0] = "Aysha";
            alunos[1] = "Carlos";
            alunos[2] = "Daniela";
            alunos[3] = "Rafaela";
            alunos[4] = "Luiz";
            
            foreach(var aluno in alunos) {
                Console.WriteLine(aluno);
            }

            //nesta caso, o tamanho dos elemetos está defindo o tamanho do array. Mas este tamanho continua sendo fixo, ele não muda.
            double somatorio = 0;
            double[] notas = { 9.7, 4.8, 8.4, 8.2, 6.8 }; 

            foreach(var nota in notas) {
                somatorio += nota;
            }

            //varrendo com for
            //for(int i = 0; i < notas.Length; i++) {
            //    somatorio += notas[i];
            //}

            double media = somatorio / notas.Length;
            Console.WriteLine($"A média do somatório é: {media}");

            char[] letras = { 'A', 'r', 'r', 'a', 'y' };
            string palavra = new string(letras);
            Console.WriteLine(palavra);
        }
    }
}

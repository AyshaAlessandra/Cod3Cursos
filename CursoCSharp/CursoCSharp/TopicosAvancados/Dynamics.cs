using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados
{
    internal class Dynamics
    {
        public static void Executar()
        {
            //com dynamic, não precisa amarrar um tipo por ser dinamico, com isso pode atribuir varios outros tipos na mesma variável
            dynamic meuObjeto = "teste";
            meuObjeto = 3;

            meuObjeto++;
            Console.WriteLine(meuObjeto);

            //adiciona dinamicamente os valores a um objeto
            dynamic aluno = new System.Dynamic.ExpandoObject();
            aluno.nome = "Maria Clara";
            aluno.nota = 8.4;
            aluno.idade = 24;

            Console.WriteLine($"Nome: {aluno.nome}, Nota: {aluno.nota}, idade: {aluno.idade}");
        }
    }
}

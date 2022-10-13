using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.Excecoes;
using CursoCSharp.Api;
using CursoCSharp.TopicosAvancados;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
               
                //Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentarios - Fundamentos", Comentarios.Executar},
                {"Váriaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferência - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Número - Fundamentos", FormatandoNumero.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores Aritméticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores de Atribuição - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar},
                {"Operadores Ternario - Fundamentos", OperadorTernario.Executar},
                
                //Estruturas de Controle
                {"Estrutura IF - Estruturas de Controle", EstruturaIf.Executar},
                {"Estrutura IF/ElSE - Estruturas de Controle", EstruturaIfElse.Executar},
                {"Estrutura IF/ElSE/IF - Estruturas de Controle", EstruturaIfElseIf.Executar},
                {"Estrutura Switch - Estruturas de Controle", EstruturaSwitch.Executar},
                {"Estrutura While - Estruturas de Controle", EstruturaWhile.Executar},
                {"Estrutura Do While - Estruturas de Controle", EstruturaDoWhile.Executar},
                {"Estrutura For - Estruturas de Controle", EstruturaFor.Executar},
                {"Estrutura ForEach - Estruturas de Controle", EstruturaForEach.Executar},
                {"Usando Breack - Estruturas de Controle", UsandoBreack.Executar},
                {"Usando Continue - Estruturas de Controle", UsandoContinue.Executar},

                //Classes e Metodos
                 {"Membros - Classes e Metodos", Membros.Executar},
                 {"Construtores - Classes e Métodos", Construtores.Executar},
                 {"Métodos com Retorno - Classes e Métodos", MetodosComRetorno.Executar},
                 {"Métodos Estáticos - Classes e Métodos", MetodosEstaticos.Executar},
                 {"Atributos Estáticos - Classes e Métodos", AtributosEstaticos.Executar},
                 {"Desafio Atributo - Classes e Métodos", DesafioAtributo.Executar},
                 {"Params - Classes e Métodos", Params.Executar},
                 {"Parametros Nomeados - Classes e Métodos", ParametrosNomeados.Executar},
                 {"Get Set - Classes e Métodos", GetSet.Executar},
                 {"Props - Classes e Métodos", Props.Executar},
                 {"Readonly - Classes e Métodos", Readonly.Executar},
                 {"Enum - Classes e Métodos", ExemploEnum.Executar},
                 {"Struct - Classes e Métodos", ExemploStruct.Executar},
                 {"Struct VS Classe - Classes e Métodos", StructVsClasse.Executar},
                 {"Valor VS Referência - Classes e Métodos", ValorVsReferencia.Executar},
                 {"Parâmetros Por Referência(Ref/Out) - Classes e Métodos", ParametrosPorReferencia.Executar},
                 {"Parâmetro com Valor Padrão - Classes e Métodos", ParametroPadrao.Executar},

                //Coleções
                {"Array - Coleções", Colecoes.Array.Executar},
                {"List - Coleções", ColecoesList.Executar},
                {"ArrayList - Coleções", ColecoesArrayList.Executar},
                {"Set - Coleções", ColecoesSet.Executar},
                {"Queue - Coleções", ColecoesQueue.Executar},
                {"Igualdade - Coleções", Igualdade.Executar},
                {"Stack - Coleções", ColecaesStack.Executar},
                {"Dictionary - Coleções", ColecoesDictionary.Executar},

                //OO
                {"Herança - OO", Heranca.Executar},
                {"Construtor This - OO", ConstrutorThis.Executar},
                {"Encapsulamento - OO", Encapsulamento.Executar},
                {"Polimorfismo - OO", Polimorfismo.Executar},
                {"Abstract - OO", Abstract.Executar},
                {"Interface - OO", Interface.Executar},
                {"Sealed - OO", Sealed.Executar},

                //Métodos & Funções
                {"Exemplo lambda - Métodos & Funções", ExemploLambda.Executar},
                {"Lambdas Como Delegates - Métodos & Funções", LambdasDelegate.Executar},
                {"Usando Delegates - Métodos & Funções", UsandoDelegates.Executar},
                {"Delegates Como Função Anonima - Métodos & Funções", DelegateFunAnonima.Executar},
                {"Delegates Como Parâmetros - Métodos & Funções", DelegatesComoParametros.Executar},
                {"Métodos de Extensão - Métodos & Funções", MetodosDeExtensao.Executar},

                //Exeções
                {"Primeira Exceção - Exceções", PrimieraExcecao.Executar},
                {"Exceções Personalizadas - Exceções", ExcecoesPersonalizadas.Executar},

                //Explorando API
                {"Primeiro Arquivo - Api", PrimeiroArquivo.Executar},
                {"Lendo Arquivos - Api", LendoArquivos.Executar},
                {"Exemplo FileInfo - Api", ExemploFileInfo.Executar},
                {"Diretórios - Api", Diretorios.Executar},
                {"Exemplo DirectoryInfo - Api", ExemploDirectoryInfo.Executar},
                {"Exemplo Path - Api", ExemploPath.Executar},
                {"Exemplo DateTime - Api", ExemploDateTime.Executar},
                {"Exemplo TimeSpan - Api", ExemploTimeSpan.Executar},

                //Tópicos avançados
                {"LINQ1 - Tópicos avançados", LINQ1.Executar},
                {"LINQ2 - Tópicos avançados", LINQ2.Executar},
                {"Nullable - Tópicos avançados", Nullables.Executar},
                {"Dynamic - Tópicos avançados", Dynamics.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}
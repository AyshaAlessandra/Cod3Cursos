using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Excecoes
{
    public class Conta
    {
        private double Saldo;
       
        public Conta(double saldo)
        {
            Saldo = saldo;
        }

        public void Sacar(double valor)
        {
            if (valor > Saldo) {
                throw new ArgumentException("Saldo insufuciente.");
            }

            Saldo -= valor;
        }
    }

    internal class PrimieraExcecao
    {
        public static void Executar()
        {
            var conta = new Conta(1_223.45);

            try {
                conta.Sacar(1600);
                Console.WriteLine("Retirada com sucesso!");
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
                //posso ver o nome da execao usando essa função.
                Console.WriteLine(ex.GetType().Name);
            }
            //esse vai executar independente se o try ou catch tenha dado certo ou errado.
            finally {
                Console.WriteLine("Volte sempre!");
            }
        }
    }
}

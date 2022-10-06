using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    /*Quando não há um construtor padrão na classe pai, quando outra classe herdar, irá
     * precisar por um construtor base.
     */

    public class Carro
    {
        protected readonly int VelocidadeMaxima;
        private int VelocidadeAtual;

        public Carro(int velocidadeMaxima)
        {
            VelocidadeMaxima = velocidadeMaxima;
        }

        protected int AlterarVelocidade(int delta)
        {
            int novaVelocidade = VelocidadeAtual + delta;

            if (novaVelocidade < 0) {
                VelocidadeAtual = 0;
            }
            else if (novaVelocidade > VelocidadeMaxima) {
                VelocidadeAtual = VelocidadeMaxima;
            }
            else {
                VelocidadeAtual = novaVelocidade;
            }
            return VelocidadeAtual;
        }
        //Quando coloco o modificador virtual, quero dizer que o método pode ser sobrescrito.
        //Se não colocar, o método não poderá ser sobrescrito (override).
        public virtual int Acelerar()
        {
            return AlterarVelocidade(5);
        }

        public int Frear()
        {
            return AlterarVelocidade(-5);
        }
    }

    public class Uno : Carro
    {
        public  Uno() : base(200)
        {

        }
    }

    public class Ferrari : Carro
    {
        public Ferrari() : base(350)
        {

        }

        public override int Acelerar()
        {
            return AlterarVelocidade(15);
        }

        //Ocultar o método da classe Pai com o 'new', ou seja, não precisa usar o virtual para fazer a sobreescrita
        public new int Frear()
        {
            return AlterarVelocidade(-15);
        }
    }

    internal class Heranca
    {
        public static void Executar()
        {
            Console.WriteLine("Uno...");
            Uno carro1 = new Uno();
            
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());

            Console.WriteLine("Ferrari...");
            Ferrari carro2 = new Ferrari();

            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Frear());

            Console.WriteLine("Ferrari com o tipo carro...");
            Carro carro3 = new Ferrari();
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());

            Console.WriteLine("Uno com o tipo carro...");
            carro3 = new Uno(); // Polimorfismo. Uma mesma variável assumindo multiplas formas.
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
        }
    }
}
/*Diferença entre sobreescrita e ocultamento:
 * O método sobreescrita de fato é chamado quando acesso a ferrari a partir da variável tipo carro.
 * Entretando, o método frear que ocultou inicialmente quando tinha uma instância do tipo ferrari,
 * ele funcionou. Mas quando instanciou ferrari do tipo carro, ele chamou o método de carro e não 
 * de ferrari com isso, não funcionou da maneira que deveria funcionar.
 */
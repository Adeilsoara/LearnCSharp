using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO {

    public class Carro {
        protected readonly int VelocidadeMaxima;
        int VelocidadeAtual;

        public Carro(int velocidadeMaxima) {
            VelocidadeMaxima = velocidadeMaxima;
        }

        protected int AlterarVelocidade(int delta) {
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
        //virtual - permite que um método seja sobrescrito
        public virtual int Acelerar() {
            return AlterarVelocidade(5);
        }

        public int Frear() {
            return AlterarVelocidade(-5);
        }
    }
    public class Uno : Carro {
        public Uno() : base(200) {

        }

    public class Ferrari : Carro {
            public Ferrari() : base(350) {

            }

            public override int Acelerar() {
                return AlterarVelocidade(15);
            }

            //oculta o método da classe pai 
            public new int Frear() {
                return AlterarVelocidade(-15);
            }
        }
    }
    class Heranca {
        public static void Executar() {
            Console.WriteLine("Uno...");
            Uno carro1 = new Uno();
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Frear());

            Console.WriteLine("Ferrari...");
          
        }
    }
}

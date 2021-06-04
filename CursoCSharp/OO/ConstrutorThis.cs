using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO {
    public class Animal {
        public string Nome { get; set; }

        public Animal(string nome) {
            Nome = nome;
        }
    }
    public class Cachorro : Animal {
        public double Altura { get; set; }

        public Cachorro(string nome) : base(nome) {
            Console.WriteLine($"Cachorro {nome} instanciado...");
        }

        public Cachorro(string nome, double altura) : this(nome) {
            Altura = altura;
        }
        public override string ToString() {
            return $"{Nome} tem {Altura} cm de Altura";
        }
    }
    class ConstrutorThis {
        public static void Executar() {
            var leao = new Cachorro("Leão");
            var joli = new Cachorro("Joli",30.0);

            Console.WriteLine(leao);
            Console.WriteLine(joli);
        }
    }
}

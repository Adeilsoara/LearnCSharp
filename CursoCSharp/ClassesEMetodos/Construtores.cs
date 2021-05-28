using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {

    class Carro {
        public string Modelo;
        public string Fabricante;
        public int Ano;

        public Carro (string modelo, string fabricante, int ano) {
            Modelo = modelo;
            Fabricante = fabricante;
            Ano = ano;
        }
    }
    class Construtores {
        public static void Executar() {

            var carro = new Carro("Hb20", "Hyunday", 2016);
            Console.WriteLine($"{carro.Modelo}, {carro.Fabricante}, {carro.Ano}");
        }
    }
}

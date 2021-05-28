using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    class Membros {
        public static void Executar() {
            Pessoa sicrano = new Pessoa();
            sicrano.Nome = "Roberval";
            sicrano.Idade = 45;

           // Console.WriteLine($"{sicrano.Nome} tem {sicrano.Idade} anos");

            sicrano.ApresentarNoConsole();

            var fulano = new Pessoa();
            fulano.Nome = "Joberclayson";
            fulano.Idade = 34;

            var apresentarFaluno = fulano.Apresentar();
            Console.WriteLine(apresentarFaluno);
        }
    }
}

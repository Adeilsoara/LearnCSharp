using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {

    class CalculadoraComum {
        public int Somar(int a, int b) {
            return a + b;
        }
        public int Subtrair(int a, int b) {
            return a + b;
        }
        public int Multiplicar(int a, int b) {
            return a * b;
        }
    }

    class CalculadorCadeia {
        int memoria;

        public CalculadorCadeia Somar(int a) {
            memoria += a;
            return this;
        }
        public CalculadorCadeia Multiplicar(int a) {
            memoria *= a;
            return this;
        }

        public CalculadorCadeia Limpar() {
            memoria = 0;
            return this;
        }

        public CalculadorCadeia Imprimir() {
            Console.WriteLine(memoria);
            return this;
        }

        public int Resultado() {
            return memoria;
        }
    }

    class MetodosComRetorno {
        public static void Executar() {
            var calculadoraComum = new CalculadoraComum();
            var resultado = calculadoraComum.Somar(3, 4);

            Console.WriteLine(resultado);
            Console.WriteLine(calculadoraComum.Subtrair(5, 8));
            Console.WriteLine(calculadoraComum.Multiplicar(6,7));

            var calculadoraEncadeada = new CalculadorCadeia();
            calculadoraEncadeada.Somar(4).Multiplicar(6).Imprimir().Limpar().Resultado();

        }
    }
}

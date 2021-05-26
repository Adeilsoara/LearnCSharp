using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    class EstruturaIfElseIf {
        public static void Executar() {

            Console.Write("Digite a nota do aluno: ");
            string entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            if (nota >= 9.0) {
                Console.WriteLine("Aprovado Bichão");
            } else if (nota >= 7.0) {
                Console.WriteLine("Aprovado ");
            } else if (nota >= 5.0) {
                Console.WriteLine("Recuperação ");
            }
            else {
                Console.WriteLine("Até a próxima ");
            }

            Console.WriteLine("FIM");
        }
    }
}

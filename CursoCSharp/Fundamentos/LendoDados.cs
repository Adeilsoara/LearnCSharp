using System;
using System.Globalization;


namespace CursoCSharp.Fundamentos {
    class LendoDados {
        public static void Executar() {
            Console.WriteLine("Qual o seu nome?: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual é a sua idade?: ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual seu salário?: ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"{nome} {idade} R$ {salario}");
        }
    }
}

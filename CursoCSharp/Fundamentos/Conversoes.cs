using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class Conversoes {
        public static void Executar() {
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);

            double nota = 8.9;
            //conversão explícita, casting
            int notaTruncada = (int)nota;
            Console.WriteLine($"Nota truncada: {notaTruncada}");

            Console.Write("Digite sua idade: ");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine("Idade Inserida: {0}", idadeInteiro);

            idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine("Resultado: {0}", idadeInteiro);

            Console.Write("Digite o primeiro número: ");
            string palavra = Console.ReadLine();
            int numero;
            int.TryParse(palavra, out numero);
            Console.WriteLine("Resultado: {0}", numero);

            Console.Write("Digite o segundo número: ");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine("Resultado: {0}", numero2);


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class VariaveisEConstantes {
        public static void Executar() {

            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("A area é: " + area);

            bool estaChovendo = true;
            Console.WriteLine("Está chovendo? " + estaChovendo);

            byte idade = 28;
            Console.WriteLine("A idade é: " + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("O saldo de Gols: " +saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salário: " +salario);

            int menorValorInt = int.MinValue;
            Console.WriteLine("Valor Int: " + menorValorInt);

            uint populacaoBrasileira = 207456789;
            Console.WriteLine("População Brasileira: "+populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor Valor Long: "+menorValorLong);

            ulong populacaoMundial = 7600000000;
            Console.WriteLine("Populção Mundial: " +populacaoMundial);

            float precoComputador = 1299.99f;
            Console.WriteLine("Preço Computador: "+precoComputador);

            double valorDeMercadoApple = 10000000000;
            Console.WriteLine("Valor Apple: ");

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Distância entre estrelas: "+distanciaEntreEstrelas);

            char letra = 'a';
            Console.WriteLine("Caracter: "+letra);

            string texto = "Bora aprender C#!!";
            Console.WriteLine("String: " + texto);
        } 
    }
}

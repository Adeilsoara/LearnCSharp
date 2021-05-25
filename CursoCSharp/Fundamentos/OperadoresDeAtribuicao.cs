using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class OperadoresDeAtribuicao {

        public static void Executar() {
            var num = 3;
            num = 7;
            num += 10;
            num -= 10;
            num *= 10;
            num /= 10;

            Console.WriteLine(num);

            int a = 1;
            int b = a;

            a++;
            b--;

        }
    }
}

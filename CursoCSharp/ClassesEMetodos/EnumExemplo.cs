using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    public enum Genero {Acao, Comedia, Drama, Suspense, Terror };

    public class Filme {
        public string Titulo;
        public Genero GeneroDoFilme;
    }
    class EnumExemplo {
        public static void Executar() {
            int id = (int)Genero.Acao;
            Console.WriteLine(id);

            var filmeFamilia = new Filme();
            filmeFamilia.Titulo = "Zerinaite";
            filmeFamilia.GeneroDoFilme = Genero.Comedia;

            Console.WriteLine("{0} é {1}", filmeFamilia.Titulo, filmeFamilia.GeneroDoFilme);

        }
    }
}

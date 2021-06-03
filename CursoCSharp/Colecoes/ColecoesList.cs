using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    class ColecoesList {
        public class Produto {
            public string Nome;
            public double Preco;

            public Produto(string nome, double preco) {
                Nome = nome;
                Preco = preco;
            }
        }
        public static void Executar() {
            var livro = new Produto("Python Novatec", 159.9);

            var carrinho = new List<Produto>();
            carrinho.Add(livro);
        }
    }
}

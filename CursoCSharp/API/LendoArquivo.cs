using System;
using System.IO;

namespace CursoCSharp.API {
    class LendoArquivo {

        public static void Executar() {
            var path = @"~/lendo_arquivo.txt".ParseHome();
            if (!File.Exists(path)) {
                using (StreamWriter sw = File.AppendText(path)) {
                    sw.WriteLine("Produto;Preço;Qtd;");
                    sw.WriteLine("Livro;150.9;2;");
                    sw.WriteLine("Caderno;12.4;5;");
                }
            }
            try {
                using (StreamReader rd = new StreamReader(path)) {
                    var texto = rd.ReadToEnd();
                    Console.WriteLine(texto);
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

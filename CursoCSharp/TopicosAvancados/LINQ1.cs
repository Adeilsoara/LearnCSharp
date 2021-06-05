using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados {
    public class Aluno {
        public string Nome;
        public int Idade;
        public double Nota;
    }
    class LINQ1 {
        public static void Executar() {
            var alunos = new List<Aluno> {
                new Aluno() {Nome = "Adeilson", Idade = 28, Nota=7.9},
                new Aluno() {Nome = "Jefesons", Idade = 17, Nota=9.9},
                new Aluno() {Nome = "Jofrey", Idade = 20, Nota=8.9},
                new Aluno() {Nome = "Adeilson", Idade = 18, Nota=7.9},
                new Aluno() {Nome = "Elena", Idade = 22, Nota=4.9},

            };
            Console.WriteLine("----- Alunos AProvados-----");
            var aprovados = alunos.Where(a => a.Nota > 7.0).OrderBy(a => a.Nome);
            foreach (var aluno in aprovados) {
                Console.WriteLine(aluno.Nome);
            }

            Console.WriteLine("----- Chamada ---------");
            var chamada = alunos.OrderBy(a => a.Nome).Select(a => a.Nome);
            foreach (var aluno in chamada) {
                Console.WriteLine(aluno);
            }

            Console.WriteLine("-----Aprovados por Idade-----");
            var alunosAprovados =
                from aluno in alunos
                where aluno.Nota >= 7.0
                orderby aluno.Idade
                select aluno.Nome;
            foreach (var aluno in alunosAprovados) {
                Console.WriteLine(aluno);
            }

        }
    }
}

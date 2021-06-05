using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados {
    class LINQ2 {
        public static void Executar() {
            var alunos = new List<Aluno> {
                new Aluno() {Nome = "Adeilson", Idade = 28, Nota=7.9},
                new Aluno() {Nome = "Jefesons", Idade = 17, Nota=9.9},
                new Aluno() {Nome = "Jofrey", Idade = 20, Nota=8.9},
                new Aluno() {Nome = "Adeilson", Idade = 18, Nota=7.9},
                new Aluno() {Nome = "Elena", Idade = 22, Nota=4.9},
            };
            var elena = alunos.Single(aluno => aluno.Nome.Equals("Elena"));
            Console.WriteLine($"{elena.Nome} {elena.Nota}");
        }
    }
}

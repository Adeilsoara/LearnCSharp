using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;
using CursoCSharp.Excecoes;
namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                //Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários CSharp - Fundamentos", Comentarios.Executar},
                {"Variáveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferência - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Números - Fundamentos", FormatandoNumero.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores Aritméticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores de Atribuição - Fundamentos", OperadoresDeAtribuicao.Executar},
                {"Operador Ternário - Fundamentos", OperadorTernario.Executar},

                //Estruras de Controle
                {"Estrutura IF - Estruturas de Controle", EstruturaIf.Executar},
                {"Estrutura IF/ELSE - Estruturas de Controle", EstruturaIfElse.Executar},
                {"Estrutura IF/ELSE/IF - Estruturas de Controle", EstruturaIfElseIf.Executar},
                {"Estrutura Switch - Estruturas de Controle", EstruturaSwitch.Executar},
                {"Estrutura While - Estruturas de Controle", EstruturaWhile.Executar},
                {"Estrutura For - Estruturas de Controle", EstruturaFor.Executar},
                {"Estrutura ForEach - Estruturas de Controle", EstruturaForEach.Executar},

                //Classes e Métodos
                 {"Membros - Classes e Métodos", Membros.Executar},
                 {"Construtores -  Classes e Métodos ", Construtores.Executar},
                 {"Metodos com Retorno -  Classes e Métodos ", MetodosComRetorno.Executar},
                 {"Metodos Estaticos -  Classes e Métodos ", MetodosEstaticos.Executar},
                 {"Atributos Estaticos -  Classes e Métodos ", AtributosEstaticos.Executar},
                 {"Desafio -  Classes e Métodos ", Desafio.Executar},
                 {"Parametros Variavei -  Classes e Métodos ", Params.Executar},
                 {"Parametros Nomeados -  Classes e Métodos ", ParametrosNomeados.Executar},
                 {"Getters e Setters -  Classes e Métodos ", GettersESetters.Executar},
                 {"Readonly -  Classes e Métodos ", Readonly.Executar},
                 {"Enum -  Classes e Métodos ", EnumExemplo.Executar},
                 
                  //Coleções
                 {"Array -  Coleções ", ArrayExe.Executar},
                 {"List -  Coleções ", ColecoesList.Executar},
                 {"ArrayList -  Coleções ", ColecoesArrayList.Executar},
                 {"Igualdade -  Coleções ", Igualdade.Executar},
                
                  //Orientação a Objetos
                 {"Herança -  OO ", Heranca.Executar},
                 {"Construtor This -  OO ", ConstrutorThis.Executar},

                 //Exceções
                 {"Excecoes -  Excecoes ", PrimeiraExcecoes.Executar},

            });

            central.SelecionarEExecutar();
        }
    }
}
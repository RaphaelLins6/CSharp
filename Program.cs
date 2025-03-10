using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Váriaveis e Constatntes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferencias de tipo - Fundamentos", Inferencia.Executar},
                {"Interpolação de strings - Fundamentos", Interpolacao.Executar},
                {"Notação de ponto - Fundamentos", Notacao.Executar},
                {"Lendo Dados Do Console - Fundamentos", LendoDadosDoConsole.Executar},
                {"Formatando números - Fundamentos", FormatandoNumeros.Executar},
                {"Operadores aritiméticos - Fundamentos", OperadoresAritimeticos.Executar},
                {"Operadores relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores logicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores de atribuição - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores unários - Fundamentos", OperadoresUnarios.Executar},
                {"Operadores ternários - Fundamentos", OperadoresTernarios.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}
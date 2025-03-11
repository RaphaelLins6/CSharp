using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Váriaveis e Constatntes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferencias de Tipo - Fundamentos", Inferencia.Executar},
                {"Interpolação de Strings - Fundamentos", Interpolacao.Executar},
                {"Notação de Ponto - Fundamentos", Notacao.Executar},
                {"Lendo Dados Do Console - Fundamentos", LendoDadosDoConsole.Executar},
                {"Formatando Números - Fundamentos", FormatandoNumeros.Executar},
                {"Operadores Aritiméticos - Fundamentos", OperadoresAritimeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores de Atribuição - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar},
                {"Operadores Ternários - Fundamentos", OperadoresTernarios.Executar},
                {"Estrutura IF - Estruturas de controle", Estruturaif.Executar},
                {"Estrutura IF-ELSE - Estruturas de controle", Estruturaifelse.Executar},
                {"Estrutura IF-ELSEIF - Estruturas de controle", Estruturaifelseif.Executar},
                {"Estrutura Switch - Estruturas de controle", Estruturaswitch.Executar},
                {"Estrutura While - Estruturas de controle", Estruturawhile.Executar},
                {"Estrutura Do While - Estruturas de controle", Estruturadowhile.Executar},
                {"Estrutura For - Estruturas de controle", Estruturafor.Executar},
                {"Estrutura For Each - Estruturas de controle", Estruturaforeach.Executar},
                {"Estrutura Break - Estruturas de controle", Estruturabreak.Executar},
                {"Estrutura Continue - Estruturas de controle", Estruturacontinue.Executar},

            });

            central.SelecionarEExecutar();
        }
    }
}
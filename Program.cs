using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {

                // Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Váriaveis e Constatntes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferencias de Tipo - Fundamentos", Inferencia.Executar},
                {"Interpolação de Strings - Fundamentos", Interpolacao.Executar},
                {"Notação de Ponto - Fundamentos", Notacao.Executar},
                {"Lendo Dados Do Console - Fundamentos", LendoDadosDoConsole.Executar},
                {"Formatando Números - Fundamentos", FormatandoNumeros.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores Aritiméticos - Fundamentos", OperadoresAritimeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores de Atribuição - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar},
                {"Operadores Ternários - Fundamentos", OperadoresTernarios.Executar},

                // Estruturas de Controle
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

                // Classes e métodos
                {"Membros - Classes e métodos", Membros.Executar},
                {"Construtores - Classes e métodos", Construtores.Executar},
                {"Métodos com Retorno - Classes e métodos", MetodosComRetorno.Executar},
                {"Métodos Estáticos - Classes e métodos", MetodosEstaticos.Executar},
                {"Atributos Estáticos - Classes e métodos", AtributosEstaticos.Executar},
                {"Desafio Atributo - Classes e métodos", DesafioAtributo.Executar},
                {"Params - Classes e métodos", Params.Executar},
                {"Parâmetros Nomeados - Classes e métodos", ParametrosNomeados.Executar},
                {"Get Set - Classes e métodos", GetSet.Executar},
                {"Propriedades - Classes e métodos", Props.Executar},
                //{"Atributos Readonly - Classes e métodos", AtributosReadonly.Executar},
                //{"Enum - Classes e métodos", Enumeracoes.Executar},
                //{"Struct - Classes e métodos", Struct.Executar},
                //{"Struct Vs Classe - Classes e métodos", StructVsClasse.Executar},
                //{"Valor Vs Referência - Classes e métodos", ValorVsReferencia.Executar},
                //{"Parâmetros por Referência - Classes e métodos", ParametrosPorReferencia.Executar},
                //{"Parâmetros com Valor Padrão - Classes e métodos", ParametrosComValorPadrao.Executar},
                //{"Delegates - Classes e métodos", Delegates.Executar},
                //{"Lambda - Classes e métodos", Lambdas.Executar},
                //{"Linq #01 - Classes e métodos", Linq1.Executar},
                //{"Linq #02 - Classes e métodos", Linq2.Executar},
                //{"Nullables - Classes e métodos", Nullables.Executar},
                //{"Dynamics - Classes e métodos", Dynamics.Executar},
                //{"Generics - Classes e métodos", Genericos.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar() {
            // Variáveis
            // Variáveis são locais de armazenamento que podem conter valores diferentes ao longo da execução de um programa.
            // O tipo de uma variável determina o tipo de dado que ela pode armazenar.

            // Tipos de dados comuns:
            // int: Números inteiros (ex: 10, -5, 0)
            // double: Números de ponto flutuante (ex: 3.14, -2.5, 0.0)
            // string: Texto (ex: "Olá, mundo!", "C#")
            // bool: Valores booleanos (verdadeiro ou falso)

            // Declaração de variáveis:
            int idade = 30;
            double altura = 1.75;
            string nome = "João";
            bool ehEstudante = true;

            // Exibição de valores de variáveis:
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Altura: " + altura);
            Console.WriteLine("É estudante? " + ehEstudante);

            // Alteração de valores de variáveis:
            idade = 31;
            altura = 1.76;
            nome = "Maria";
            ehEstudante = false;

            // Exibição de valores de variáveis após alteração:
            Console.WriteLine("\nValores após alteração:");
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Altura: " + altura);
            Console.WriteLine("É estudante? " + ehEstudante);

            // Constantes
            // Constantes são locais de armazenamento que contêm valores fixos que não podem ser alterados durante a execução de um programa.
            // O valor de uma constante deve ser atribuído no momento da declaração.

            // Declaração de constantes:
            const double PI = 3.14159;
            const int DIAS_DA_SEMANA = 7;
            const string NOME_APLICACAO = "Minha Aplicação";

            // Exibição de valores de constantes:
            Console.WriteLine("\nConstantes:");
            Console.WriteLine("PI: " + PI);
            Console.WriteLine("Dias da semana: " + DIAS_DA_SEMANA);
            Console.WriteLine("Nome da aplicação: " + NOME_APLICACAO);

            // Tentativa de alteração de valor de constante (resultará em erro de compilação):
            // PI = 3.14; // Erro! Constantes não podem ser alteradas.
        }
    }
}

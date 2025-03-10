using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class LendoDadosDoConsole
    {
        public static void Executar() {
            // Lendo uma string do console
            // O método 'Console.ReadLine()' lê uma linha de texto do console e retorna uma string.

            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine($"Olá, {nome}!");

            // Lendo um número inteiro do console
            // O método 'int.Parse()' converte uma string em um número inteiro.
            // É importante tratar possíveis erros de conversão usando 'try-catch'.

            try {
                Console.Write("Digite sua idade: ");
                int idade = int.Parse(Console.ReadLine());

                Console.WriteLine($"Você tem {idade} anos.");
            } catch (FormatException) {
                Console.WriteLine("Idade inválida. Digite um número inteiro.");
            }

            // Lendo um número de ponto flutuante do console
            // O método 'double.Parse()' converte uma string em um número de ponto flutuante.
            // É importante tratar possíveis erros de conversão usando 'try-catch'.

            try {
                Console.Write("Digite sua altura: ");
                double altura = double.Parse(Console.ReadLine());

                Console.WriteLine($"Sua altura é {altura:F2} metros."); // :F2 formata a altura com 2 casas decimais
            } catch (FormatException) {
                Console.WriteLine("Altura inválida. Digite um número.");
            }

            // Lendo um valor booleano do console
            // O método 'bool.Parse()' converte uma string em um valor booleano.
            // É importante tratar possíveis erros de conversão usando 'try-catch'.

            try {
                Console.Write("Você é estudante? (true/false): ");
                bool ehEstudante = bool.Parse(Console.ReadLine());

                Console.WriteLine($"É estudante: {ehEstudante}");
            } catch (FormatException) {
                Console.WriteLine("Valor booleano inválido. Digite 'true' ou 'false'.");
                Console.WriteLine("Pressione Enter para continuar...");
                Console.ReadLine();
            }
        }
    }
}

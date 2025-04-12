using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    public class Dictionary
    {
        public static void Executar()
        {
            // Dictionary é uma coleção que armazena pares de chave-valor, onde cada chave é única e mapeia para um valor.
            // É uma coleção que permite acessar os valores associados a uma chave específica.
            // O Dictionary é uma coleção que pode ser usada para armazenar dados em um formato de tabela, onde cada linha tem uma chave e um valor associado.

            var filmes = new Dictionary<int, string>();
            filmes.Add(1, "O Senhor dos Anéis");
            filmes.Add(2, "Harry Potter");
            filmes.Add(3, "Star Wars");

            Console.WriteLine(filmes[1]); // acessa o valor associado à chave 1
            Console.WriteLine(filmes[2]); // acessa o valor associado à chave 2
            Console.WriteLine(filmes[3]); // acessa o valor associado à chave 3

            foreach (var item in filmes)
            {
                Console.WriteLine($"{item.Key} - {item.Value}"); // percorre o dicionário e imprime a chave e o valor
            }

            Console.WriteLine("Pressione Enter para continuar...");
            Console.ReadLine();
        }
    }
}
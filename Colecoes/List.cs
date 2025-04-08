using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    // Coleções - List
    // List é uma coleção que armazena elementos de forma ordenada e permite acesso rápido a eles.
    // Ela é semelhante a um array, mas com mais funcionalidades e flexibilidade.
    // List é uma classe genérica, o que significa que você pode especificar o tipo de dados que ela irá armazenar.
    // Você pode adicionar, remover e acessar elementos de forma dinâmica, sem precisar se preocupar com o tamanho da lista.
    // List também possui métodos úteis para manipulação de dados, como ordenação, busca e filtragem.
    // List é uma das coleções mais utilizadas em C# devido à sua simplicidade e eficiência.
    public class List
    {
        public class Produto {
            public string Nome;
            public double Preco;

            public Produto(string nome, double preco)
            {
                Nome = nome;
                Preco = preco;
            }

            public override bool Equals(object? obj)
            // Sobrescrevendo o método Equals para comparar dois objetos Produto
            {
                if (obj == null || GetType() != obj.GetType())
                    return false;

                Produto outro = (Produto)obj;
                return Nome == outro.Nome && Preco == outro.Preco;
            }

            public override int GetHashCode()
            {
                // Combine hash codes of Nome and Preco for a unique hash
                return Nome.GetHashCode() ^ Preco.GetHashCode();
            }
        }
        public static void Executar(){
            
            var jogo = new Produto("Assassins Creed 4: Black Flag", 150.00);

            // Adicionando o jogo a uma lista de produtos
            var carrinho = new List<Produto>(); // Cria uma lista de produtos
            carrinho.Add(jogo); // Adiciona o jogo ao carrinho
            carrinho.Add(new Produto("GTA 5", 120.00)); // Adiciona outro produto ao carrinho
            carrinho.Add(new Produto("Far Cry 4", 130.00)); // Adiciona mais um produto ao carrinho

            int PrecoTotal = 0; // Inicializa o preço total como 0
            foreach (var item in carrinho) // Percorre cada item no carrinho
            {
                PrecoTotal += (int)item.Preco; // Adiciona o preço do item ao preço total
            }

            Console.WriteLine($"Total de produtos no carrinho: {carrinho.Count}"); // Exibe o total de produtos no carrinho
            Console.WriteLine($"Primeiro produto: {carrinho[0].Nome}"); // Exibe o nome do primeiro produto no carrinho
            Console.WriteLine($"O segundo produto é: {carrinho[1].Nome}"); // Exibe o nome do segundo produto no carrinho
            Console.WriteLine($"O terceiro produto é: {carrinho[2].Nome}"); // Exibe o nome do terceiro produto no carrinho
            Console.WriteLine($"O preço total dos produtos é: {PrecoTotal}"); // Exibe o preço total dos produtos no carrinho
            
            Console.WriteLine("Pressione Enter para continuar...");
            Console.ReadLine();
        }
    }
}
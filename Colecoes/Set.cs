using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static CursoCSharp.Colecoes.List; // Importando a classe List para evitar o uso do namespace completo

namespace CursoCSharp.Colecoes
{
    public class Set
    {
        // HashSet é uma coleção que não permite elementos duplicados e não mantém a ordem dos elementos.
        // É uma coleção que é otimizada para operações de busca e inserção, mas não é recomendada para uso em código moderno.
        // O HashSet é mais rápido que o List para operações de busca, mas mais lento para operações de inserção e remoção.
        // O HashSet é uma coleção que é otimizada para operações de busca e inserção, mas não é recomendada para uso em código moderno.
        // O HashSet não permite elementos duplicados, então se você tentar adicionar um produto que já existe, ele não será adicionado novamente.
        // Por exemplo, se você tentar adicionar o mesmo produto novamente, ele não será adicionado.

        public static void Executar(){
            
            var jogo = new Produto("Assassins Creed 4: Black Flag", 150.00);

            var carrinho = new HashSet<Produto>(); // Criando um HashSet de produtos
            carrinho.Add(jogo); // Adicionando o produto ao HashSet
            carrinho.Add(new Produto("GTA 5", 120.00)); 
            carrinho.Add(new Produto("Far Cry 4", 130.00)); 

            int PrecoTotal = 0; 

            foreach (var item in carrinho) 
            {
                PrecoTotal += (int)item.Preco; 
            }

            Console.WriteLine($"Total de produtos no carrinho: {carrinho.Count}"); 

            // Para imprimir os produtos no carrinho, você pode usar um loop foreach para iterar sobre o HashSet e imprimir cada produto.
            // O HashSet não garante a ordem dos elementos, então a ordem pode ser diferente da ordem em que os produtos foram adicionados.

            foreach (var produto in carrinho)
            {
                Console.WriteLine($"Produto: {produto.Nome} - Preço: {produto.Preco}"); 
            }

            Console.WriteLine($"O preço total dos produtos é: {PrecoTotal}"); 

            Console.WriteLine("Pressione Enter para continuar...");
            Console.ReadLine();
        }
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    public class Stack
    {
        // Stack é uma coleção do tipo LIFO (Last In First Out), ou seja, o último a entrar é o primeiro a sair.
        // É uma coleção que armazena elementos em uma pilha, onde o último elemento adicionado é o primeiro a ser removido.
        // A pilha é uma estrutura de dados que permite adicionar e remover elementos apenas do topo da pilha.
        // A pilha é uma coleção que pode ser usada para armazenar elementos temporariamente, como em algoritmos de busca em profundidade ou em expressões matemáticas.
        public static void Executar(){
            var pilha = new Stack<string>();

            pilha.Push("Primeiro");
            pilha.Push("Segundo");
            pilha.Push("Terceiro");

            Console.WriteLine(pilha.Count); // quantidade de elementos na pilha
            Console.WriteLine(pilha.Peek()); // retorna o elemento do topo da pilha, mas não remove

            foreach (var item in pilha)
            {
                Console.WriteLine($"{item}"); // percorre a pilha do topo para o fundo
            }

            Console.WriteLine(pilha.Pop()); // remove o elemento do topo da pilha
            Console.WriteLine(pilha.Peek()); // retorna o elemento do topo da pilha, mas não remove

            Console.WriteLine(pilha.Count); // quantidade de elementos na pilha

            Console.WriteLine("Pressione Enter para continuar...");
            Console.ReadLine();
        }
    }
}
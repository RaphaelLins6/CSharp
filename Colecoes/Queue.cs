using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    public class Queue
    {
        // Queue é uma coleção do tipo FIFO (First In First Out), ou seja, o primeiro a entrar é o primeiro a sair.
        // É uma fila, onde o primeiro elemento adicionado é o primeiro a ser removido.
        // A fila é uma coleção que permite adicionar e remover elementos de forma ordenada.
        public static void Executar(){
            
            var fila = new Queue<string>();
            fila.Enqueue("Raphael");
            fila.Enqueue("Milena");

            Console.WriteLine(fila.Peek());
            Console.WriteLine(fila.Count);

            // Usando o Queue com tipos diferentes
            // Queue é uma coleção que pode armazenar elementos de tipos diferentes, mas não é recomendada.
            var jogos = new System.Collections.Queue();
            jogos.Enqueue("Fifa 25");
            jogos.Enqueue("Nba 2k25");
            jogos.Enqueue(6);
            jogos.Enqueue(3.14);
            jogos.Enqueue(true);
            jogos.Dequeue(); // Remove o primeiro elemento da fila

            Console.WriteLine(jogos.Count);
            Console.WriteLine(jogos.Peek()); // Retorna o primeiro elemento da fila sem removê-lo

            Console.WriteLine("Pressione Enter para continuar...");
            Console.ReadLine();
        }
    }
}
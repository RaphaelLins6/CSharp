using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    public class ArrayList
    {
        public static void Executar(){
           
            // ArrayList é uma coleção que pode armazenar qualquer tipo de dado
            // e não é tipada, ou seja, não tem um tipo específico definido.
            // É uma coleção dinâmica, ou seja, pode crescer e diminuir de tamanho conforme necessário.
            // É uma coleção que pode armazenar qualquer tipo de dado, incluindo tipos primitivos e objetos.
            // É uma coleção que pode armazenar dados de diferentes tipos, mas não é recomendada para uso em código moderno.

            var arraylist = new System.Collections.ArrayList();
            arraylist.Add("Olá");
            arraylist.Add(6);
            arraylist.Add(true);
            arraylist.Add(3.14);

            foreach (var item in arraylist)
            {
                Console.WriteLine($"Tipo: {item.GetType()} - Valor: {item}");
            }

            Console.WriteLine("Pressione Enter para continuar...");
            Console.ReadLine();
        }
    }
}
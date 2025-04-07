using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class StructVsClasse
    {   
        public struct Mercadoria{
            public string Nome;
            public double Preco;
            public double Desconto;
        }

        public class Produto{
            public string ?Nome;
            public double Preco;
            public double Desconto;
        }

        public static void Executar(){
            // Struct
            Mercadoria mercadoria1 = new Mercadoria();
            mercadoria1.Nome = "Bola de Basquete";
            mercadoria1.Preco = 100;
            mercadoria1.Desconto = 10;

            Mercadoria mercadoria2 = mercadoria1; // Cópia da estrutura
            mercadoria2.Nome = "Bola de Futebol";

            Console.WriteLine($"Mercadoria 1: {mercadoria1.Nome}, valor: {mercadoria1.Preco} com desconto de {mercadoria1.Desconto}%.");
            Console.WriteLine($"Mercadoria 2: {mercadoria2.Nome}, valor: {mercadoria2.Preco} com desconto de {mercadoria2.Desconto}%.");

            // Classe
            Produto produto1 = new Produto();
            produto1.Nome = "Bola de Basquete";
            produto1.Preco = 100;
            produto1.Desconto = 10;

            Produto produto2 = produto1; // Referência para o mesmo objeto
            produto2.Nome = "Bola de Futebol";

            Console.WriteLine($"Produto 1: {produto1.Nome}, valor: {produto1.Preco} com desconto de {produto1.Desconto}%.");
            Console.WriteLine($"Produto 2: {produto2.Nome}, valor: {produto2.Preco} com desconto de {produto2.Desconto}%.");  

            Console.WriteLine("Pressione Enter para continuar...");
            Console.ReadLine();
        }
    }
}
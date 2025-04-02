using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class AtributosReadonly
    {   
        // Atributos readonly são atributos que podem ser inicializados apenas no construtor da classe ou na declaração do atributo.
        // Eles não podem ser alterados depois de inicializados, o que os torna úteis para representar valores constantes ou imutáveis.
        public class Cliente
        {
            public string Nome;
            public readonly DateTime Nascimento; // Atributo somente leitura

            public Cliente(string nome, DateTime nascimento)
            {
                Nome = nome;
                Nascimento = nascimento;
            }

            public string GetDataDeNascimento()
            {
                return Nascimento.ToString("dd/MM/yyyy");
            }
        }
        public static void Executar()
        {
            var cliente = new Cliente("Raphael Lins", new DateTime(1998, 6, 6));
            Console.WriteLine(cliente.Nome);
            Console.WriteLine(cliente.GetDataDeNascimento());
            // cliente.Nascimento = new DateTime(1999, 6, 6); // Isso causaria um erro de compilação, pois Nascimento é readonly
            // cliente.Nome = "Novo Nome"; // Isso é permitido, pois Nome não é readonly

            Console.WriteLine("Pressione Enter para continuar...");
            Console.ReadLine();
        }
    }
}
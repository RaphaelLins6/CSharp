using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class ValorVsReferencia
    {   
        public class Pessoa{
            public string ?Nome;
            public int Idade;
        }
        public static void Executar(){
            // Valor
            // Tipos primitivos são passados por valor, ou seja, o valor é copiado para a variável
            // e não a referência para o objeto na memória.
            // Tipos de valor: int, float, double, decimal, char, bool, struct, enum
            int numero = 6;
            int copiaNumero = numero; // valor
            Console.WriteLine($"Número: {numero}");
            Console.WriteLine($"Copia Número: {copiaNumero}");
            numero++;
            Console.WriteLine("Número depois de alterar:");
            Console.WriteLine($"{numero}");
            Console.WriteLine("Cópia do número depois de alterar:");
            Console.WriteLine($"{copiaNumero}");
            Console.WriteLine("");

            // Referência   
            // Objetos são passados por referência, ou seja, a referência para o objeto na memória é copiada.
            // e não o objeto em si.
            // Tipos de referência: string, array, class, delegate, interface
            // string é um tipo de referência, mas é imutável, ou seja, não pode ser alterada.
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = "Raphael";
            pessoa.Idade = 26;
            Pessoa copiaPessoa = pessoa; // referência
            Console.WriteLine("Dados da Pessoa:");
            Console.WriteLine($"Nome: {pessoa.Nome}");
            Console.WriteLine($"Idade: {pessoa.Idade}");
            Console.WriteLine("Dados da Copia:");
            Console.WriteLine($"Copia Nome: {copiaPessoa.Nome}");
            Console.WriteLine($"Copia Idade: {copiaPessoa.Idade}");
            Console.WriteLine("");
            pessoa.Nome = "Shai";
            pessoa.Idade = 25;
            Console.WriteLine("Dados da Pessoa depois de alterar:");
            Console.WriteLine($"Nome: {pessoa.Nome}");
            Console.WriteLine($"Idade: {pessoa.Idade}");
            Console.WriteLine("Dados da Copia depois de alterar:");
            // Como a copiaPessoa é uma referência para o mesmo objeto, os dados também são alterados.
            Console.WriteLine($"Copia Nome: {copiaPessoa.Nome}");
            Console.WriteLine($"Copia Idade: {copiaPessoa.Idade}");

            Console.WriteLine("Pressione Enter para continuar...");
            Console.ReadLine();
        }
    }
}
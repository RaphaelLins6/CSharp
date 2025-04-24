using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    public class Lambda
    {
        // Lambda é uma expressão que pode ser usada para criar funções anônimas
        // ou expressões lambda. Elas são frequentemente usadas em LINQ e em outras operações de manipulação de dados.
        // Uma expressão lambda é composta por uma lista de parâmetros, o operador "=>" e uma expressão ou bloco de código.
        // A sintaxe básica de uma expressão lambda é a seguinte:
        // (parametros) => { bloco de código }
        // ou
        // (parametros) => expressao
        public static void Executar(){

            // Action é um delegate que não retorna valor
            Action outputNoConsole = () => {
                Console.WriteLine("Olá Mundo com Lambda! Esse é sem parâmetro.");
            };
            Console.WriteLine("-------------------------------------------------");
            outputNoConsole();
            Console.WriteLine("-------------------------------------------------");

            // Func é um delegate que retorna valor
            Func<int> numeroDaSorte = () => new Random().Next(1, 1000);
            Console.WriteLine("Função com Lambda: Esse é com parâmetro.");
            Console.WriteLine($"Número da sorte: {numeroDaSorte()}");

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Pressione Enter para continuar...");
            Console.ReadLine();
        }
    }
}
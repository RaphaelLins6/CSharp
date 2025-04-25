using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    // Delegates são tipos que representam referências a métodos com uma assinatura específica.
    // Eles permitem que você passe métodos como parâmetros, armazene referências a métodos em variáveis e crie eventos.
    public class UsandoDelegates
    {
        delegate void TextoDelegate(string texto); // Delegate que recebe uma string e não retorna nada
        delegate int CalculadoraDelegate(int a, int b); // Delegate que recebe dois inteiros e retorna um inteiro

        static int Multiplicar(int a, int b) // Método que multiplica dois inteiros
        {
            return a * b;
        }

        static void EscreverTexto(string texto) // Método que escreve um texto na tela
        {
            Console.WriteLine(texto);
        }

        public static void Executar(){
            
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Usando Delegates");
            Console.WriteLine("-------------------------------------------------");
            CalculadoraDelegate calc1 = Multiplicar; // Atribui o método Multiplicar ao delegate calc1
            Console.WriteLine(calc1(2, 3)); // Chama o método Multiplicar através do delegate calc1

            TextoDelegate texto1 = EscreverTexto; // Atribui o método EscreverTexto ao delegate texto1
            texto1("Olá, Mundo!"); // Chama o método EscreverTexto através do delegate texto1
            Console.WriteLine(texto1); // Exibe o delegate texto1, que contém a referência ao método EscreverTexto
            
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Pressione Enter para continuar...");
            Console.ReadLine();
        }
    }
}
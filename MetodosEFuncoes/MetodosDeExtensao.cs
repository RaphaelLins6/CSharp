using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    public static class ExtensoesInteiro
        {
            public static int Somar(this int numero, int outroNumero)
            {
                return numero + outroNumero;
            }

            public static int Multiplicar(this int numero, int outroNumero)
            {
                return numero * outroNumero;
            }
        }

        public static class ExtensoesString
        {
            public static string RemoverEspacos(this string texto)
            {
                return texto.Replace(" ", "");
            }
        }
    public class MetodosDeExtensao
    {
        public static void Executar()
        {
            // Métodos de extensão são métodos que permitem adicionar novos comportamentos a tipos existentes sem modificar o tipo original.
            // Eles são definidos como métodos estáticos em uma classe estática e usam a palavra-chave "this" para indicar o tipo que estão estendendo.
             Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Métodos de extensão para inteiros:");
            // Exemplo de uso de métodos de extensão para inteiros
            int numero1 = 10;
            int numero2 = 20;
            Console.WriteLine($"Soma: {numero1.Somar(numero2)}"); // Saída: Soma: 30
            Console.WriteLine($"Multiplicação: {numero1.Multiplicar(numero2)}"); // Saída: Multiplicação: 200            
            Console.WriteLine("-------------------------------------------------");
            // Exemplo de uso de métodos de extensão para strings
            Console.WriteLine("Métodos de extensão para strings:");
            string texto = "Olá Mundo!";
            Console.WriteLine($"Texto original: {texto}"); // Saída: Texto original: Olá Mundo!
            Console.WriteLine($"Texto sem espaços: {texto.RemoverEspacos()}"); // Saída: Texto sem espaços: OláMundo!
            Console.WriteLine($"Texto em maiúsculas: {texto.ToUpper()}"); // Saída: Texto em maiúsculas: OLÁ MUNDO!
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Pressione Enter para continuar...");
            Console.ReadLine();
        }
    }
}
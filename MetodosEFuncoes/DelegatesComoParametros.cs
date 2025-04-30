using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    // Delegates passados como parâmetros para métodos
    // Como parametro de um método, o delegate pode ser usado para passar uma função como argumento.
    // Isso é útil para criar métodos que podem ser personalizados com diferentes comportamentos.
    public class DelegatesComoParametros
    {
        public delegate int Operacao(int x, int y);
        
        public static int Somar(int x, int y)
        {
            return x + y;
        }

        public static string Calculadora(int x, int y, Operacao operacao)
        {
            int resultado = operacao(x, y);
            return $"O resultado da operação é: {resultado}";
        }
        public static void Executar(){

            Operacao subtracao = (x, y) => x - y;

            Console.WriteLine("Calculadora com Delegates como Parâmetros");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine(Calculadora(10, 5, Somar));
            Console.WriteLine(Calculadora(10, 5, subtracao));

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Pressione Enter para continuar...");
            Console.ReadLine();
        }
    }
}
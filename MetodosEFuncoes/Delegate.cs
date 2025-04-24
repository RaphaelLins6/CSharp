using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    delegate double Operacao(double x, double y);
    public class LambdasDelegate
    {
        public static void Executar(){
            Operacao soma = (x, y) => x + y;
            Operacao subtracao = (x, y) => x - y;
            Operacao multiplicacao = (x, y) => x * y;
            Operacao divisao = (x, y) => x / y;

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Operações com Delegates");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Resultado da soma: " + soma(10, 5));
            Console.WriteLine("Resultado da subtração: " + subtracao(10, 5));
            Console.WriteLine("Resultado da multiplicação: " + multiplicacao(10, 5));
            Console.WriteLine("Resultado da divisão: " + divisao(10, 5));

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Pressione Enter para continuar...");
            Console.ReadLine();
        }
    }
}
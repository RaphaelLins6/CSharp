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

            Console.WriteLine(soma(10, 5));
            Console.WriteLine(subtracao(10, 5));
            Console.WriteLine(multiplicacao(10, 5));
            Console.WriteLine(divisao(10, 5));
        }
    }
}
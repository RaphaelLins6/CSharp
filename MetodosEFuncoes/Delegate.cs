using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    // Delegate é um tipo que referencia um método.
    // É como se fosse um ponteiro para um método, mas com segurança de tipo.
    // Ele pode ser usado para passar métodos como parâmetros, ou para armazenar métodos em variáveis.
    // O delegate é definido com a palavra-chave "delegate", seguida do tipo de retorno e dos parâmetros do método.
    // O delegate pode ser usado para criar métodos anônimos, que são métodos sem nome.
    // O delegate pode ser usado para criar lambdas, que são expressões que representam um método anônimo.
    // O delegate pode ser usado para criar eventos, que são uma forma de notificar outras classes quando algo acontece.
    // O delegate pode ser usado para criar callbacks, que são métodos que são chamados quando uma operação assíncrona é concluída.
    // O delegate pode ser usado para criar funções de ordem superior, que são funções que recebem outras funções como 
    // parâmetros ou retornam funções como resultado.
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
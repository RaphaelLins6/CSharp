using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    public class DelegateFuncAnonima
    {
        // Delegate pode conter funções anônimas que não possuem nome
        // e não precisam ser declaradas em uma classe separada.
        // O delegate é uma referência para um método, e pode ser usado para
        // passar métodos como parâmetros para outros métodos.
        delegate string OperacaoString(string texto);

        public static void Executar(){
            // Função anônima que inverte uma string
            OperacaoString inverter = delegate (string texto) {
                char[] letras = texto.ToCharArray();
                Array.Reverse(letras);
                return new string(letras);
            };

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Inversão de string com delegate:");
            Console.WriteLine(inverter("Teste de string"));
            
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Pressione Enter para continuar...");
            Console.ReadLine();
        }
    }
}
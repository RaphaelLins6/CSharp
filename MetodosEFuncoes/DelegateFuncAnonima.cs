using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    public class DelegateFuncAnonima
    {
        delegate string OperacaoString(string texto);

        public static void Executar(){

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
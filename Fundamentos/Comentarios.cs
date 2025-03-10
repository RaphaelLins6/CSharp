using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class Comentarios
    {
        public static void Executar() {
            // Cuidado com os comentários desnecessários
            Console.WriteLine("Código claro é sempre melhor!");
            /*
             * Esse é um comentário
             * de múltiplas linhas...
             */
            Console.WriteLine("O C# tem o XML Comments");
            Console.WriteLine("Para se comentar em C# se utiliza a sintaxe da sehuinte forma: \"// Comentário\" ");
            Console.WriteLine("Comentários de múltiplas linhas: Ctrl + K + C");
            Console.WriteLine("Descomentar: Ctrl + K + U");
            Console.WriteLine("Pressione Enter para continuar...");
            Console.ReadLine();
        }
    }
}

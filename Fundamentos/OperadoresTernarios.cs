using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class OperadoresTernarios
    {
        public static void Executar() {
            // Operador Ternário ( ? | : )
            double nota = 7.0;
            string resultado = nota >= 7.0 ? "Aprovado" : "Reprovado"; // A linha 3 é o conceito do operador ternário
            Console.WriteLine(resultado);
            Console.WriteLine("Pressione Enter para continuar...");
            Console.ReadLine();
        }
        }
}

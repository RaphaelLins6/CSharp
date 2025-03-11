using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    class Estruturaforeach {
        public static void Executar() {

            // Exemplo da estrutura For Each:

            // var palavra = "Raphael";

            // foreach (var letra in palavra) {
            //     Console.WriteLine("" + letra);
            // }

            var alunos = new string[] { "Raphael", "Milena", "Fulano", "Ciclano" };
            foreach (var aluno in alunos) {
                Console.WriteLine(aluno);
            }

            Console.WriteLine("Pressione Enter para continuar...");
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    class Estruturacontinue {
        public static void Executar() {
            int intervalo = 10;
            Console.WriteLine("Números pares entre 1 e {0}", intervalo);

            for (int i = 1; i <= intervalo; i++) {
                if (i % 2 == 1) {
                    continue;
                }
                Console.WriteLine(i + ": É par!");
            }
            Console.WriteLine("Pressione Enter para continuar...");
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    class Params {

        public static void Recepcionar(params string[] pessoas) {
            foreach (var pessoa in pessoas) {
                Console.WriteLine($"Olá {pessoa}");
            }
        }
        public static void Executar() {
            Recepcionar("Raphael", "Manu", "Roger", "Ana", "Bia");

            Console.WriteLine("Pressione Enter para continuar...");
            Console.ReadLine();
        }
    }
}

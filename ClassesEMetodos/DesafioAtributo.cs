using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    class DesafioAtributo {
        static int R = 6;
        public static void Executar() {

            // Acessar a variável 'a' dentro do método Executar!
            Console.WriteLine("Desafio Atributo!");
            Console.Write("Resposta: ");
            Console.WriteLine(DesafioAtributo.R);

            Console.WriteLine("Pressione Enter para continuar...");
            Console.ReadLine();
        }
    }
}

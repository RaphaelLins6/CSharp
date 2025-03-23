using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {

    class CalculadoraEstatica {
        // Método de Classe ou Método Estático
        public static int Multiplicar(int a, int b) {
            return a * b;
        }
        // Método de Instância
        public int Somar(int a, int b) {
            return a + b;
        }
    }

    class MetodosEstaticos {

        public static void Executar() {
            // Método de Classe ou Método Estático
            var resultado = CalculadoraEstatica.Multiplicar(2, 2);
            Console.WriteLine("Resultado: {0}", resultado);
            // Método de Instância
            CalculadoraEstatica calc = new CalculadoraEstatica();
            Console.Write("Resultado: ");
            Console.WriteLine(calc.Somar(2, 2));

            Console.WriteLine("Pressione Enter para continuar...");
            Console.ReadLine();
        }
    }
}

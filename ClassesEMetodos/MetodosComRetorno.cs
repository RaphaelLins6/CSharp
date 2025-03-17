using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {

    // Cria uma classe com os métodos de retorno
    class CalculadoraComum {
        public int Somar(int a, int b) {
            return a + b;
        }
        public int Subtrair(int a, int b) {
            return a - b;
        }
        public int Multiplicar(int a, int b) {
            return a * b;
        }
        public int Dividir(int a, int b) {
            return a / b;
        }
    }

    // Cria uma classe que chama os métodos da classe CalculadoraComum
    class MetodosComRetorno{

        public static void Executar() {
            
            var calculadoraComum = new CalculadoraComum();

            Console.Write("Resultado da soma é: ");
            Console.WriteLine(calculadoraComum.Somar(15, 10));
            Console.Write("Resultado da subtração é: ");
            Console.WriteLine(calculadoraComum.Subtrair(15, 2));
            Console.Write("Resultado da multiplicação é: ");
            Console.WriteLine(calculadoraComum.Multiplicar(30, 6));
            Console.Write("Resultado da divisão é: ");
            Console.WriteLine(calculadoraComum.Dividir(70, 7));
            
            Console.WriteLine("Pressione Enter para continuar...");
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    class Params {
        // O parâmetro params permite que você passe um número variável de argumentos para um método.
        // Ele é útil quando você não sabe quantos argumentos serão passados antecipadamente.
        // O parâmetro params deve ser o último parâmetro na lista de parâmetros do método.
        // Ele é declarado usando a palavra-chave params seguida por um tipo de array.
        // Você pode passar um array do tipo especificado ou uma lista de argumentos separados por vírgulas.
        // O compilador C# transforma a lista de argumentos em um array do tipo especificado.
        // Exemplo:
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

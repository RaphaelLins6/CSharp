using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    class Estruturabreak {
        public static void Executar() {
            // Exemplo da estrutura Break:

            // Criar um numero aleatório entre 1 e 50
            Random numAle = new Random();
            int numero = numAle.Next(1, 51);

            Console.WriteLine("O número que queremos é {0}", numero);

            // Usar o for até achar algum número pré-determinado
            for (int i = 1; i <= 50; i++) {
                Console.Write("{0} é o número que queremos ? ", i);

                if (i == numero) {
                    Console.WriteLine("Sim!");
                    break; // O break serve para sair do laço quando o número for encontrado, se não continuaria printando todos os números
                } else {
                    Console.WriteLine("Não.");
                }
            }

            Console.WriteLine("Pressione Enter para continuar...");
            Console.ReadLine();
        }
    }
}

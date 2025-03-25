using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    class ParametrosNomeados {

        // Os parâmetros nomeados permitem que você passe argumentos
        // para um método especificando o nome do parâmetro, em vez de
        // depender da ordem posicional.
        // Isso melhora a legibilidade do código, especialmente quando um método tem muitos parâmetros.
        // Ao chamar um método, você especifica o nome do parâmetro seguido por dois pontos (:) e o valor do argumento.
        public static void Formatar(int dia, int mes, int ano) {
            Console.WriteLine("{0:D2}/{1:D2}/{2}", dia, mes, ano);
        }

        public static void Executar() {

            Formatar(6, 6, 1998);

            Console.WriteLine("Pressione Enter para continuar...");
            Console.ReadLine();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    class Estruturafor
    {
        public static void Executar() {

            // Exemplo da estrutura For:
            // for (int i = 1; i <= 10; i++) {
            //     Console.WriteLine($"O valor de i é {i}.");
            // }

            double somatoria = 0;
            string entrada;

            Console.WriteLine("Informe o tamanho da turma: ");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out int tamanhoTurma);

            for (int i = 1; i <= tamanhoTurma; i++) {
                Console.WriteLine("Informe a nota do aluno {0}:", i);
                entrada = Console.ReadLine();
                double.TryParse(entrada, out double notaAtual);

                somatoria += notaAtual;
            }

            double media = tamanhoTurma > 0 ? somatoria / tamanhoTurma : 0;
            Console.WriteLine("Média da turma é: {0}", media);

            Console.WriteLine("Pressione Enter para continuar...");
            Console.ReadLine();
        }
    }
}

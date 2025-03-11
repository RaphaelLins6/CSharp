using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    class Estruturaif
    {
        public static void Executar() {
            // Estrutura IF

            bool bomComportamento;
            string entrada;

            Console.WriteLine("Digite a nota do aluno: ");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            Console.WriteLine("Possui bom comportamento (S|N): ");
            entrada = Console.ReadLine();

            //if (entrada == "S" || entrada == "s"){
            //    bomComportamento = true;}     

            bomComportamento = entrada.ToLower() == "s";

            if (nota >= 9.0 && bomComportamento) {
                Console.WriteLine("Quador de honra!");
            }

            Console.WriteLine("Pressione Enter para continuar...");
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAritimeticos
    {
        public static void Executar() {
            // Preço Desconto
            double preco = 1000;
            double imposto = 355;
            double desconto = 0.1;
            double total = preco + imposto;
            double totalComDesconto = total - total * desconto;
            Console.WriteLine("O preço final é {0}", totalComDesconto);
            // IMC
            double peso = 91.2;
            double altura = 1.82;
            double imc = peso / Math.Pow(altura, 2);
            Console.WriteLine($"IMC é {imc}");
            // Número Par/Impar
            int par = 24;
            int impar = 55;
            Console.WriteLine("{0}/2 tem resto {1}", par, par % 2);
            Console.WriteLine("{0}/2 tem resto {1}", impar, impar % 2);
            Console.WriteLine("Pressione Enter para continuar...");
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAtribuicao
    {
        public static void Executar() {
            // Atribuição de mais
            int numMais = 7;
            numMais += 10;
            Console.WriteLine("O operador de atribuição do mais é = " + numMais);

            // Atribuição de menos
            int numMenos = 7;
            numMenos -= 3;
            Console.WriteLine("O operador de atribuição do menos é = " + numMenos);

            // Atribuição de multipilcação
            int numMult = 7;
            numMult *= 5;
            Console.WriteLine("O operador de atribuição da multipilcação é = " + numMult);

            // Atribuição de divisão
            int numDiv = 7;
            numDiv /= 2;
            Console.WriteLine("O operador de atribuição da divisão é = " + numDiv);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class OperadoresUnarios {

        public static void Executar() {
            int valorNegativo = -6;
            int numero1 = 10;
            int numero2 = 20;
            bool booleano = false;

            // Operador de inversão de valores númericos
            Console.WriteLine(-valorNegativo);

            // Operador de inversão de valores booleanos
            Console.WriteLine(!booleano);

            // Operador de adição (pós-fixado)
            numero1++;
            Console.WriteLine(numero1);

            // Operador de subtração (pré-fixado)
            --numero2;
            Console.WriteLine(numero2);
        }
    }
 }

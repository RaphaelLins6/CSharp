﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    class Estruturadowhile
    {
        public static void Executar() {
            string entrada;

            do {
                Console.WriteLine("Qaul o seu nome?");
                entrada = Console.ReadLine();

                Console.WriteLine("Seja bem-vindo {0}", entrada);
                Console.WriteLine("Deseja continuar? (S|N)");
                entrada = Console.ReadLine();
            } while (entrada.ToLower() == "s");
            Console.WriteLine("Pressione Enter para continuar...");
            Console.ReadLine();
        }
    }
}

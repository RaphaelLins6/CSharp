﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class FormatandoNumeros
    {
        public static void Executar() {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1"));
            Console.WriteLine(valor.ToString("C"));
            Console.WriteLine(valor.ToString("P"));
            Console.WriteLine(valor.ToString("#.##"));

            CultureInfo cultura = new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("c3", cultura));

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10"));
            Console.WriteLine("Pressione Enter para continuar...");
            Console.ReadLine();
        }
    }
}

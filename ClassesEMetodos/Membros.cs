﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Membros
    {
        public static void Executar() {
            Pessoa sicrano = new Pessoa();
            sicrano.Nome = "Raphael";
            sicrano.Idade = 26;
            Console.WriteLine($"{sicrano.Nome} tem {sicrano.Idade} anos.");
        } 
    }
}

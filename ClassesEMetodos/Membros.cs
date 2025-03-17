using System;
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
            // Console.WriteLine($"{sicrano.Nome} tem {sicrano.Idade} anos.");

            sicrano.ApresentarNoConsole();
            sicrano.Zerar();
            sicrano.ApresentarNoConsole();

            var fulano = new Pessoa();
            fulano.Nome = "Fulano";
            fulano.Idade = 27;

            var apresentacaoDoFulano = fulano.Apresentar();
            Console.WriteLine(apresentacaoDoFulano);
            Console.WriteLine(apresentacaoDoFulano.Length);


            Console.WriteLine("Pressione Enter para continuar...");
            Console.ReadLine();
        } 
    }
}

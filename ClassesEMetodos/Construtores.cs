using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos 
{
	class Carro {
        public string Modelo;
        public string Fabricante;
        public int Ano;
    }

    class Construtores {
        public static void Executar() {
            var carro1 = new Carro();
            carro1.Modelo = "Fusca";
            Console.WriteLine(carro1.Modelo);
            var carro2 = new Carro();
            carro2.Modelo = "Brasília";
            Console.WriteLine(carro2.Modelo);
            Console.WriteLine("Pressione Enter para continuar...");
            Console.ReadLine();
        }
    }
}
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

        public Carro(string modelo, string fabricante, int ano) {
            Modelo = modelo;
            Fabricante = fabricante;
            Ano = ano;
        }

        public Carro() {

        }
    }

    class Construtores {
        public static void Executar() {
            
            // Método 1
            var carro1 = new Carro();
            carro1.Modelo = "Fusca";
            carro1.Fabricante = "Volkswagen";
            carro1.Ano = 1980;
            Console.WriteLine($"Modelo: {carro1.Modelo}, Fabricante: {carro1.Fabricante}, Ano: {carro1.Ano}");

            // Método 2
            var carro2 = new Carro() {
                Modelo = "Brasília",
                Fabricante = "Volkswagen",
                Ano = 1973
            };
            Console.WriteLine($"Modelo: {carro2.Modelo}, Fabricante: {carro2.Fabricante}, Ano: {carro2.Ano}");

            // Método 3
            var carro3 = new Carro("Uno", "Fiat", 2019);
            Console.WriteLine($"Modelo: {carro3.Modelo}, Fabricante: {carro3.Fabricante}, Ano: {carro3.Ano}");
            


            Console.WriteLine("Pressione Enter para continuar...");
            Console.ReadLine();
        }
    }
}
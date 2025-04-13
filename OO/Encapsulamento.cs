using Encapsulamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO {
    class EncapsulamentO 
    {
        public class Peladeiro : Jogadores {
            public Peladeiro(string nome, int idade, string posicao, int numeroCamisa) : base(nome, idade, posicao, numeroCamisa) {
            }
            public new void MostrarDados() {
                Console.WriteLine(" ");
                Console.WriteLine("Dados do Peladeiro:");
                Console.WriteLine($"Nome: {Nome}");
                Console.WriteLine($"Idade: {Idade}");
                Console.WriteLine($"Posição: {Posicao}");
                Console.WriteLine($"Número da Camisa: {NumeroCamisa}");
                //Console.WriteLine($"CPF: {CPF}"); // Não pode ser acessado
                Console.WriteLine($"Time: {Time}");
                // Console.WriteLine($"Endereço: {Endereco}"); // Não pode ser acessado
                Console.WriteLine($"Características: {Caracteristicas}");
                //Console.WriteLine($"Destreza: {Destreza}"); // Não pode ser acessado
                Console.WriteLine(" ");
            }
        }

        public class semiProfissional {
            public readonly Jogadores jogador = new Jogadores("Raphael", 26, "Armador", 66);

            public void MostrarDados() {
                Console.WriteLine(" ");
                Console.WriteLine("Dados do Peladeiro:");
                Console.WriteLine($"Nome: {jogador.Nome}");
                Console.WriteLine($"Idade: {jogador.Idade}");
                Console.WriteLine($"Posição: {jogador.Posicao}");
                Console.WriteLine($"Número da Camisa: {jogador.NumeroCamisa}");
                //Console.WriteLine($"CPF: {jogador.CPF}"); 
                //Console.WriteLine($"Time: {jogador.Time}");
                //Console.WriteLine($"Endereço: {jogador.Endereco}"); 
                //Console.WriteLine($"Características: {jogador.Caracteristicas}");
                //Console.WriteLine($"Destreza: {jogador.Destreza}"); 
                Console.WriteLine(" ");
            }
        }
        public static void Executar() 
        {
            Console.WriteLine("Encapsulamento");

            Jogadores jogador = new Jogadores("Samuel", 25, "Armador", 30);
            jogador.MostrarDados();
            Console.WriteLine(" ");

            Jogadores Raphael = new semiProfissional().jogador;
            Raphael.MostrarDados();
            Console.WriteLine(" ");

            Jogadores Peladeiro = new Peladeiro("Nicholas", 26, "Ala-Armador", 6);
            Peladeiro.MostrarDados();
            Console.WriteLine(" ");
        }
    }
}

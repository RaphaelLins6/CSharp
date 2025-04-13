using Encapsulamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO {
    class Encapsulamento 
    {
        /// Encapsulamento:
        /// O encapsulamento é um dos pilares da programação orientada a objetos. Ele se refere à prática de restringir o acesso a certos componentes de um objeto, permitindo que apenas 
        /// métodos específicos possam interagir com esses componentes. Isso ajuda a proteger os dados e a manter a integridade do objeto.
        /// No C#, o encapsulamento é implementado usando modificadores de acesso, como `private`, `protected`, `internal` e `public`. Esses modificadores controlam a visibilidade 
        /// dos membros de uma classe (atributos e métodos) em relação a outras classes.
        /// O modificador `private` indica que o membro só pode ser acessado dentro da própria classe. O modificador `protected` permite o acesso apenas dentro da classe e em classes 
        /// derivadas. O modificador `internal` permite o acesso dentro do mesmo assembly, enquanto o modificador `public` permite o acesso de qualquer lugar.
        /// O encapsulamento é importante porque ajuda a proteger os dados de um objeto, garantindo que eles só possam ser acessados e modificados de maneiras controladas. Isso reduz o 
        /// risco de erros e torna o código mais fácil de entender e manter.
        /// Além disso, o encapsulamento permite que os desenvolvedores alterem a implementação interna de uma classe sem afetar o código que a utiliza, desde que a interface pública 
        /// permaneça a mesma. Isso facilita a manutenção e a evolução do software ao longo do tempo.
        /// O encapsulamento é um conceito fundamental na programação orientada a objetos e é amplamente utilizado em linguagens como C#.
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

            Jogadores Prospecto = new Prospecto("Dois mil", 25, "Armador", 24);
            Prospecto.MostrarDados();
            Console.WriteLine(" ");

            Console.WriteLine("Pressione Enter para continuar...");
            Console.ReadLine();
        }
    }
}

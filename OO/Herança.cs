using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    public class Herança
    {
        // Herança é um recurso que permite criar uma nova classe a partir de uma classe já existente.
        // A nova classe herda os membros (atributos e métodos) da classe pai, podendo adicionar novos membros ou sobrescrever os existentes.
        // Isso promove a reutilização de código e a criação de hierarquias de classes.
        // A classe que herda é chamada de classe filha ou subclasse, enquanto a classe da qual ela herda é chamada de classe pai ou superclasse.
        public class Herói // Classe base
        // A classe Herói representa um personagem com vida e habilidades de dano e cura.
        {
            // Atributos
            protected readonly int vidaCheia = 6000;
            public int vidaAtual;
            
            public Herói(int vidaCheia)
            {
                vidaAtual = vidaCheia;
            }

            // Métodos
            protected int AlterarVida(int dano) // Método protegido que altera a vida do herói, reduzindo-a pelo valor do dano recebido.
            {
                if (vidaAtual - dano < 0)
                {
                    vidaAtual = 0;
                }
                else
                {
                    vidaAtual -= dano;
                }
                return vidaAtual;
            }

            public int Dano() // Método público que aplica dano ao herói, reduzindo sua vida em 200.
            {
                return AlterarVida(200);
            }

            public virtual int Curar() // Método público que cura o herói, aumentando sua vida em 50.
            {
                return AlterarVida(-50);
            }
        }

        // A classe Guerreiro herda da classe Herói, representando um tipo específico de herói com vida inicial de 5000.
        // Ela pode ter suas próprias características e comportamentos, além dos herdados da classe Herói.
        // A classe Guerreiro é uma subclasse da classe Herói, representando um tipo específico de herói.
        public class Guerreiro : Herói // Classe derivada
        // A classe Guerreiro herda os membros da classe Herói e pode adicionar novos membros ou sobrescrever os existentes.
        {
            public Guerreiro() : base(8000) // Construtor da classe Guerreiro que chama o construtor da classe base Herói com vida inicial alterada para 8000.
            {
                
            }

            public string Gritar() // Método público que representa uma ação específica do Guerreiro, como gritar.
            {
               return "aaaorghhhhhh!!!"; // Retorna uma string representando o grito do Guerreiro.
            }
        }

        public class Curandeiro : Herói // Classe derivada
        // A classe Curandeiro herda os membros da classe Herói e pode adicionar novos membros ou sobrescrever os existentes.
        {
            public Curandeiro() : base(4000) // Construtor da classe Curandeiro que chama o construtor da classe base Herói com vida inicial alterada para 5000.
            {
                
            }

            public override int Curar() // Sobrescreve o método Curar da classe base Herói, aumentando a ação de cura para 150.
            {
                return AlterarVida(-150);
            }

            public  string curar() // Método público que representa uma ação específica do Curandeiro, como curar.
            {
                return "Curando..."; // Retorna uma string representando a ação de cura do Curandeiro.
            }
        }
        public static void Executar()
        {
            Console.WriteLine("Estatísticas do Guerreiro: ");
            Guerreiro guerreiro = new Guerreiro();
            Console.WriteLine($"Vida Cheia: {guerreiro.vidaAtual}");
            Console.WriteLine($"O guerreiro levou um ataque e agora sua vida é: ");
            Console.WriteLine($"Vida atual = {guerreiro.Dano()}");
            Console.WriteLine($"O guerreiro se curou e agora sua vida é: ");
            Console.WriteLine($"Vida atual: {guerreiro.Curar()}");
            Console.WriteLine(guerreiro.Gritar());
            Console.WriteLine($" ");

            Console.WriteLine("Estatísticas do Curandeiro: ");
            Curandeiro curandeiro = new Curandeiro();
            Console.WriteLine($"Vida Cheia: {curandeiro.vidaAtual}");
            Console.WriteLine($"O curandeiro levou um ataque e agora sua vida é: ");
            Console.WriteLine($"Vida atual = {curandeiro.Dano()}");
            Console.WriteLine($"O curandeiro se curou e agora sua vida é: ");
            Console.WriteLine($"Vida atual: {curandeiro.Curar()}");
            Console.WriteLine(curandeiro.curar());
            Console.WriteLine($" ");

            Console.WriteLine("Pressione Enter para continuar...");
            Console.ReadLine();
        }
    }
}
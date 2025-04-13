using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// O construtor this é uma forma de chamar outro construtor da mesma classe, permitindo reutilizar código e evitar duplicação.
// Ele é útil quando você tem múltiplos construtores com diferentes parâmetros e deseja inicializar os atributos comuns de forma consistente.
// O construtor this deve ser a primeira linha do construtor que o chama.

namespace CursoCSharp.OO
{
    public class ConstrutorThis
    {
        public class Racas {
            public string Nome { get; set; }
            public float Altura { get; set; }
            public float Peso { get; set; }
            public string Cor { get; set; }

            public Racas(string nome, float altura, float peso, string cor)
            {
                Nome = nome;
                Altura = altura;
                Peso = peso;
                Cor = cor;
            }
        }

        public class Ogro : Racas
        {
            public int presas { get; set; }

            // O construtor Ogro chama o construtor da classe base Racas usando "base", passando os parâmetros necessários.
            public Ogro(string nome, float altura, float peso, string cor) : base(nome, altura, peso, cor)
            {
                Nome = nome;
                Altura = altura;
                Peso = peso;
                Cor = cor;
            }

            // O construtor Ogro também pode ter parâmetros adicionais, como "presas", que são específicos para a classe Ogro.
            // Ele chama o construtor base usando "this" e, em seguida, inicializa o atributo "presas".
            public Ogro(string nome, float altura, float peso, string cor, int presas) : this(nome, altura, peso, cor)
            {
                this.presas = presas; // "this" refere-se ao objeto atual da classe Ogro, permitindo acessar seus atributos e métodos.
            }

            public override string ToString() // O método ToString() é sobrescrito para fornecer uma representação em string do objeto Ogro.
            {
                return $"Informações sobre o {Nome}: Altura: {Altura}, Peso: {Peso}, Cor: {Cor}, Presas: {presas}";
            }
        }
        public static void Executar()
        {   
            var Karaxes = new Ogro("Karaxes", 2.5f, 150f, "Verde", 4); // Cria um objeto Ogro com os parâmetros fornecidos.
            var Gorath = new Ogro("Gorath", 2.0f, 120f, "Laranja esverdeado", 3); // Cria outro objeto Ogro.
            var Grom = new Ogro("Grom", 2.2f, 130f, "Verde Musgo", 5); // Cria mais um objeto Ogro.

            Console.WriteLine(Karaxes); // Imprime as informações do objeto Karaxes.
            Console.WriteLine(Gorath); // Imprime as informações do objeto Gorath.
            Console.WriteLine(Grom); // Imprime as informações do objeto Grom.

            Console.WriteLine("Pressione Enter para continuar...");
            Console.ReadLine();
        }
    }
}
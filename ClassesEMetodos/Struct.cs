using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class Struct
    {
        // Structs são tipos de valor, ou seja, são armazenados na pilha (stack) e não no heap.
        // Isso significa que eles são mais rápidos e eficientes em termos de memória do que classes, que são tipos de referência.
        // No entanto, structs têm algumas limitações em comparação com classes. Por exemplo, structs não podem ter herança e 
        // não podem ser nulas (a menos que sejam declaradas como Nullable).
        // Além disso, structs são copiados por valor, o que significa que quando você passa uma struct como argumento para um método,
        // uma cópia da struct é criada. Isso pode levar a comportamentos inesperados se você não estiver ciente disso.
        struct Jogos {
                public string Nome;
                public int Ano;
                public string Genero;
                public string Plataforma;
            }

        public static void Executar(){

            Jogos jogo1;
            jogo1.Nome = "Fortnite";
            jogo1.Ano = 2017;
            jogo1.Genero = "Battle Royale";
            jogo1.Plataforma = "PlayStation 4, Xbox One, Nintendo Switch, PC, iOS e Android";
            Console.WriteLine("");
            Console.WriteLine($"O {jogo1.Nome} é um jogo de {jogo1.Genero} lançado em {jogo1.Ano} para {jogo1.Plataforma}.");

            Jogos jogo2;
            jogo2.Nome = "Assasins Creed Valhalla";
            jogo2.Ano = 2020;
            jogo2.Genero = "Ação/Aventura";
            jogo2.Plataforma = "PlayStation 4, Xbox One, PC";
            Console.WriteLine($"O {jogo2.Nome} é um jogo de {jogo2.Genero} lançado em {jogo2.Ano} para {jogo2.Plataforma}.");
            Console.WriteLine("");

            Console.WriteLine("Pressione Enter para continuar...");
            Console.ReadLine();
        }
    }
}
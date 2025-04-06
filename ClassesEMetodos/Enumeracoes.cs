using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public enum TipoJogador { Armador, AlaArmador, Ala, AlaPivô, Pivô };

    public class Jogador
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public TipoJogador Tipo { get; set; }

        public Jogador(string nome, int idade, TipoJogador tipo)
        {
            Nome = nome;
            Idade = idade;
            Tipo = tipo;
        }

        public override string ToString()
        {
            return $"{Nome} - {Idade} - {Tipo}";
        }
    }
    public class Enumeracoes
    {
        public static void Executar()
        {
           int id = (int)TipoJogador.Armador;
            Console.WriteLine($"O ID do enum é {id}");

            var jogador1 = new Jogador("Russell Westbrook", 36, TipoJogador.Armador);
            var jogador2 = new Jogador("Shai Gilgeous-Alexander", 26, TipoJogador.Armador);
            var jogador3 = new Jogador("Jalen Williams", 22, TipoJogador.AlaArmador);
            var jogador4 = new Jogador("Chet Homlgrem", 22, TipoJogador.AlaPivô);
           
            Console.WriteLine($"O maior jogador da história do time do oklahoma city thunder é o {jogador1.Nome}, hoje com {jogador1.Idade} anos, ele joga de {jogador1.Tipo}.");
            Console.WriteLine($"O melhor jogador atualmente do time do oklahoma city thunder é o {jogador2.Nome}, hoje com {jogador2.Idade} anos, ele joga de {jogador2.Tipo}.");
            Console.WriteLine($"O {jogador3.Nome} do oklahoma city thunder é um dos melhores prospectos da liga, hoje com {jogador3.Idade} anos, ele joga de {jogador3.Tipo}.");
            Console.WriteLine($"O {jogador4.Nome} do oklahoma city thunder é um dos bigs mais promissores da liga , hoje com {jogador4.Idade} anos, ele joga de {jogador4.Tipo}.");

            Console.WriteLine("Pressione Enter para continuar...");
            Console.ReadLine();
        }
    }
}
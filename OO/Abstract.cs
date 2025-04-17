using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    // A classe abstrata não pode ser instanciada, mas pode ser herdada.
    // A classe abstrata pode ter métodos abstratos (sem implementação) e métodos concretos (com implementação).
    // A classe que herda a classe abstrata deve implementar os métodos abstratos.
    // A classe abstrata pode ter construtores, propriedades e campos.
    // A classe abstrata pode ter métodos virtuais (com implementação) que podem ser sobrescritos na classe derivada.
    // A classe abstrata pode ter métodos não virtuais (sem implementação) que não podem ser sobrescritos na classe derivada.
    public class Abstract
    {
        // Classe abstrata
        public abstract class Org
        {
            public abstract string Nome { get; set; }
            public string Area { get; set; } = "Esporte";
            public abstract string Atividades();
            public virtual string Localizacao()
            {
                return "Brasília - DF";
            }
        }

        // Classe que herda a classe abstrata
        // A classe que herda a classe abstrata deve implementar os métodos abstratos.
        // A classe que herda a classe abstrata pode sobrescrever os métodos virtuais.
        // A classe que herda a classe abstrata pode ter seus próprios métodos e propriedades.
        public class OrgBB : Org
        {
            public override string Nome { get; set; } = "Fundação basquete brasileiro";
        
            public override string Atividades()
            {
                return "Escolinha de basquete, campeonato de basquete, etc.";
            }
            public override string Localizacao()
            {
                return "Plano Piloto - Brasília - DF";
            }
        }

        public class OrgFut : Org
        {
            public override string Nome { get; set; } = "Fundação futebol brasileiro";
            
            public override string Atividades()
            {
                return "Escolinha de futebol, campeonato de futebol, etc.";
            }
            public override string Localizacao()
            {
                return "Guará - Brasília - DF";
            }
        }
        public static void Executar(){
            Org Basquete = new OrgBB();
             Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Inofrmações da Organização:");
            Console.WriteLine($"Nome: {Basquete.Nome}");
            Console.WriteLine($"Área: {Basquete.Area}");
            Console.WriteLine($"Atividades: {Basquete.Atividades()}");
            Console.WriteLine($"Localização: {Basquete.Localizacao()}");
            Console.WriteLine("-------------------------------------------------");
            Org Futebol = new OrgFut();
            Console.WriteLine("Inofrmações da Organização:");
            Console.WriteLine($"Nome: {Futebol.Nome}");
            Console.WriteLine($"Área: {Futebol.Area}");
            Console.WriteLine($"Atividades: {Futebol.Atividades()}");
            Console.WriteLine($"Localização: {Futebol.Localizacao()}");
            Console.WriteLine("-------------------------------------------------");

            Console.WriteLine("Pressione Enter para continuar...");
            Console.ReadLine();
        }
    }
}
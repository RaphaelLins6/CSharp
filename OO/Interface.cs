using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    // A interface é um contrato que define um conjunto de métodos e propriedades que uma classe deve implementar.
    // A interface não pode ter implementação, apenas a assinatura dos métodos e propriedades.
    // A interface pode ter propriedades, métodos, eventos e indexadores.
    // A interface pode ser herdada por outras interfaces.
    // A classe que implementa a interface deve implementar todos os métodos e propriedades da interface.
    // A classe pode implementar várias interfaces.
    // A interface pode ter métodos virtuais (com implementação) que podem ser sobrescritos na classe que implementa a interface.
    public class Interface
    {
        interface Maioridade {
            int Idade { get; set; }
        }

        class Brasil : Maioridade {
            public int Idade { get; set; } = 18;
        }

        class EUA : Maioridade {
            public int Idade { get; set; } = 21;
        }

        class Europa : Maioridade {
            public int Idade { get; set; } = 18;
        }

        class Asia : Maioridade {
            public int Idade { get; set; } = 18;
        }

        class Canada : Maioridade {
            public int Idade { get; set; } = 19;
        }
        public static void Executar(){
            Maioridade brasil = new Brasil();
            Maioridade eua = new EUA();
            Maioridade europa = new Europa();
            Maioridade asia = new Asia();
            Maioridade canada = new Canada();

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Maioridade em diferentes países:");
            Console.WriteLine($"Maioridade no Brasil: {brasil.Idade} anos");
            Console.WriteLine($"Maioridade nos EUA: {eua.Idade} anos");
            Console.WriteLine($"Maioridade na Europa: {europa.Idade} anos");
            Console.WriteLine($"Maioridade na Asia: {asia.Idade} anos");
            Console.WriteLine($"Maioridade no Canada: {canada.Idade} anos");

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Pressione Enter para continuar...");
            Console.ReadLine();
        }
    }
}
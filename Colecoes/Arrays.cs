using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    public class Arrays
    {
        public static void Executar(){

            // Array é uma coleção de dados do mesmo tipo, com tamanho fixo e indexado.
            // O array é uma estrutura de dados que armazena uma coleção de elementos do mesmo tipo,
            // com um tamanho fixo e indexado. Isso significa que, uma vez que o array é criado,
            // seu tamanho não pode ser alterado, e cada elemento pode ser acessado por meio de um índice.
            // Os arrays são úteis quando você precisa armazenar uma coleção de dados relacionados
            // e deseja acessar esses dados rapidamente por meio de um índice.
            // Eles são amplamente utilizados em programação para armazenar listas de valores, como números,
            // strings ou objetos.  
            
            string[] Jogadores = new string[5];
            Jogadores[0] = "Shai";
            Jogadores[1] = "Lu Dort";
            Jogadores[2] = "Jalen Williams";
            Jogadores[3] = "Chet Holmgren";
            Jogadores[4] = "Isaiah Hartenstein";
            
            Console.WriteLine($"O armaor é o {Jogadores[0]}");
            Console.WriteLine($"O ala-armador é o {Jogadores[1]}");
            Console.WriteLine($"O ala é o {Jogadores[2]}");
            Console.WriteLine($"O ala-pivô é o {Jogadores[3]}");
            Console.WriteLine($"O pivô é o {Jogadores[4]}");


            Console.WriteLine("Pressione Enter para continuar...");
            Console.ReadLine();
        }
    }
}
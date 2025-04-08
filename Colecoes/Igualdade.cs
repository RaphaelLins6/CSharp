using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static CursoCSharp.Colecoes.List; // Usando o namespace List para evitar conflitos de nomes

namespace CursoCSharp.Colecoes
{
    public class Igualdade
    {
        // Igualdade entre objetos é um assunto complexo, pois depende de como a classe foi implementada.
        // Por padrão, o C# compara referências de objetos, ou seja, verifica se os dois objetos apontam para o mesmo local na memória.
        // Para comparar o conteúdo dos objetos, é necessário sobrescrever o método Equals e o operador == na classe.
        // O método Equals é usado para comparar dois objetos e verificar se eles são iguais, enquanto o operador == é usado para comparar referências de objetos.
        // Se o operador == não for sobrescrito, ele usará o método Equals por padrão.
        // Para sobrescrever o operador ==, é necessário criar um método estático que retorna um booleano e recebe dois parâmetros do tipo da classe.
        // O método Equals deve ser sobrescrito para comparar os atributos dos objetos e verificar se eles são iguais.
        
        public static void Executar(){
            
            var p1 = new Produto("Produto 1", 10.0);
            var p2 = new Produto("Produto 1", 10.0);

            Console.WriteLine(p1 == p2); // false, porque são referências diferentes
            Console.WriteLine(p1.Equals(p2)); // true, porque o Equals foi sobrescrito na classe Produto

            Console.WriteLine("Pressione Enter para continuar...");
            Console.ReadLine();
        }
    }
}
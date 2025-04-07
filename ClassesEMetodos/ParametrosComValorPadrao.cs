using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class ParametrosComValorPadrao
    {
        // Método com parâmetros padrão
        // O valor padrão é atribuído quando o parâmetro não é passado na chamada do método
        public static int somar(int a = 6, int b = 0)
        {
            return a + b;
        }
        public static void Executar(){
            
            // Chamando o método sem passar o segundo parâmetro
            Console.WriteLine("Chamando o método sem passar o segundo parâmetro: ");
            Console.WriteLine(somar(5)); // Saída: 5 (5 + 0)
            // Chamando o método passando ambos os parâmetros
            Console.WriteLine("Chamando o método passando ambos os parâmetros: ");
            Console.WriteLine(somar(5, 10)); // Saída: 15 (5 + 10)
            // Chamando o método sem passar nenhum parâmetro
            Console.WriteLine("Chamando o método sem passar nenhum parâmetro: ");
            Console.WriteLine(somar()); // Saída: 6 (6 + 0)
            // Chamando o método passando apenas o segundo parâmetro
            Console.WriteLine("Chamando o método passando apenas o segundo parâmetro: ");
            Console.WriteLine(somar(b: 10)); // Saída: 16 (6 + 10)
            
            Console.WriteLine("Pressione Enter para continuar...");
            Console.ReadLine();
        }
    }
}
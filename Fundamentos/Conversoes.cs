using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class Conversoes
    {

        public static void Executar()
        {

            // Ímplicita
            int inteiro = 10; // Declara a variável que deseja converter
            double quebrado = inteiro; // Atribui a primeira váriavel para uma segunda com o tipo que deseja
            Console.WriteLine(quebrado);

            // Explícita
            double nota = 9.7; // Declara a variável que deseja converter
            int notaTruncada = (int)nota; // Atribui a primeira váriavel para uma segunda declarando o tipo que deseja via cache => "(int)"
            Console.WriteLine("Nota truncada: {0}", notaTruncada);

            // Convertendo String para Int
            Console.Write("Qual a sua idade: ");
            string idadeString = Console.ReadLine(); // Variável string
            int IdadeInt = int.Parse(idadeString); // Cria uma segunda variável int e atribui a variável string a ela usando a função "int.Parse(variável1)"
            Console.WriteLine("Idade inserida {0}", IdadeInt);

            // Usando a função Convert
            IdadeInt = Convert.ToInt32(idadeString);
            Console.WriteLine("Resultado: {0}", IdadeInt);

            // Usando a função TryParse
            Console.Write("Digite o primerio número: ");
            string palavra = Console.ReadLine();
            int numero1;
            int.TryParse(palavra, out numero1);
            Console.WriteLine("Resultado 1: {0}", numero1);

            // Otimizando
            Console.Write("Digite o segundo número: ");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine("Resultado 2: {0}", numero2);

            Console.WriteLine("Pressione Enter para continuar...");
            Console.ReadLine();
        }
    }
}

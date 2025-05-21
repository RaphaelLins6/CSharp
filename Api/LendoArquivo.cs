using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.Api
{
    public class LendoArquivo
    {
        public static void Executar()
        {
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Lendo Arquivo");
            Console.WriteLine("-------------------------------------------------");

            // Lê o arquivo de texto
            var path = "C:\\Users\\rapha\\OneDrive\\Documentos\\Pessoal\\ProjetosC#\\Cod3rC#\\CursoCSharp\\Api\\LendoArquivo.txt";

            using ( StreamReader sr = new StreamReader(path))
            {
                // Lê o arquivo linha por linha
                string? line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Pressione Enter para continuar...");
            Console.ReadLine();
        }
    }
}
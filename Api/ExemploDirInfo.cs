using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace CursoCSharp.Api
{
    public class ExemploDirInfo
    {
        public static void Executar()
        {
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Exemplo de uso de DirectoryInfo");
            Console.WriteLine("-------------------------------------------------");

            var dirInfo = new DirectoryInfo(@"~/source/repos/CursoCSharp".ParseHome());

            if (!dirInfo.Exists)
            {
                Console.WriteLine("Diretório não encontrado!");
                return;
            }

            Console.WriteLine("Diretórios:");
            var pastas = dirInfo.GetDirectories();
            foreach (var pasta in pastas)
            {
                Console.WriteLine(pasta);
            }

            Console.WriteLine("Arquivos:");
            var arquivos = dirInfo.GetFiles();
            foreach (var arquivo in arquivos)
            {
                Console.WriteLine(arquivo);
            }

            Console.WriteLine("Raiz do projeto:");
            Console.WriteLine(dirInfo.Root);


            Console.WriteLine($"Nome: {dirInfo.Name}");
            Console.WriteLine($"Caminho: {dirInfo.FullName}");
            Console.WriteLine($"Criado em: {dirInfo.CreationTime}");
            Console.WriteLine($"Tamanho: {dirInfo.EnumerateFiles().Sum(f => f.Length)} bytes");

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Pressione Enter para continuar...");
            Console.ReadLine();
        }
    }
}
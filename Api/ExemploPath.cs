using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace CursoCSharp.Api
{
    public class ExemploPath
    {
        public static void Executar()
        {
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Exemplo de uso de Path");
            Console.WriteLine("-------------------------------------------------");

            var arquivo = "ExemploPath.txt";
            var pasta = "ExemploPathPasta";

            if (!File.Exists(arquivo))
            {
                using (StreamWriter sw = File.CreateText(arquivo))
                {
                    sw.WriteLine("Este é um exemplo de arquivo criado para demonstrar o uso de Path.");
                }
            }

            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            Console.WriteLine($"Nome do arquivo: {Path.GetFileName(arquivo)}");
            Console.WriteLine($"Extensão do arquivo: {Path.GetExtension(arquivo)}");
            Console.WriteLine($"Diretório do arquivo: {Path.GetDirectoryName(arquivo)}");
            Console.WriteLine($"Nome completo do arquivo: {Path.GetFullPath(arquivo)}");
            Console.WriteLine($"Nome base do arquivo: {Path.GetFileNameWithoutExtension(arquivo)}");

            Console.WriteLine($"Caminho do diretório: {Path.GetFullPath(pasta)}");
            Console.WriteLine($"Diretório raiz: {Path.GetPathRoot(pasta)}");
            Console.WriteLine($"Diretório pai: {Directory.GetParent(pasta)?.FullName ?? "Nenhum"}");
            Console.WriteLine($"Diretório atual: {Directory.GetCurrentDirectory()}");

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Pressione Enter para continuar...");
            Console.ReadLine();
        }
    }
}
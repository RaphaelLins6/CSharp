using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.Api
{
    public class FilesInfo
    {
        public static void ExcluirSeExistir(params string[] caminhos)
        {
            foreach (var caminho in caminhos)
            {
                FileInfo arquivo = new FileInfo(caminho);
                if (arquivo.Exists)
                {
                    arquivo.Delete();
                    Console.WriteLine($"Arquivo excluído: {arquivo.FullName}");
                }
                else
                {
                    Console.WriteLine($"Arquivo não encontrado: {arquivo.FullName}");
                }
            }
        }
        public static void Executar()
        {
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Usando FileInfo");
            Console.WriteLine("-------------------------------------------------");
            
            var caminhoOriginal = "arquivo.txt";
            var caminhoDestino = "arquivo_novo.txt";
            var caminhoCopia = "novo.txt";
            
            ExcluirSeExistir(caminhoOriginal, caminhoDestino, caminhoCopia);

            using (StreamWriter sw = File.CreateText(caminhoOriginal))
            {
                sw.WriteLine("Arquivo criado com FileInfo");
            }

            FileInfo original = new FileInfo(caminhoOriginal);
            Console.WriteLine($"Nome: {original.Name}");
            Console.WriteLine($"Tamanho: {original.Length} bytes");
            Console.WriteLine($"Criado em: {original.CreationTime}");
            Console.WriteLine($"Última modificação: {original.LastWriteTime}");
            Console.WriteLine($"Caminho completo: {original.FullName}");
            Console.WriteLine($"Extensão: {original.Extension}");
            Console.WriteLine($"Diretório: {original.DirectoryName}");
            Console.WriteLine($"Arquivo existe: {original.Exists}");
            Console.WriteLine($"Arquivo é editavel: {original.IsReadOnly}");

            original.CopyTo(caminhoCopia);
            original.MoveTo(caminhoDestino);

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Pressione Enter para continuar...");
            Console.ReadLine();
        }
    }
}
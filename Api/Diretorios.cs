using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace CursoCSharp.Api
{
    public class Diretorios
    {
        public static void Executar()
        {
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Usando Diretórios");
            Console.WriteLine("-------------------------------------------------");

            var novoDiretorio = @"~/PastaTeste".ParseHome();
            var novoDiretorioDestino = @"~/PastaTesteDestino".ParseHome();
            var dirProjeto = @"~/source/repos/CursoCSharp".ParseHome();

            if (!Directory.Exists(novoDiretorio))
            {
                Directory.Delete(novoDiretorio, true);
            }

            if (!Directory.Exists(novoDiretorioDestino))
            {
                Directory.Delete(novoDiretorioDestino, true);
            }

            Directory.CreateDirectory(novoDiretorio);
            Console.WriteLine(Directory.GetCreationTime(novoDiretorio));

            Console.WriteLine("Diretórios:");
            var pastas = Directory.GetDirectories(dirProjeto);
            foreach (var pasta in pastas)
            {
                Console.WriteLine(pasta);
            }

            Console.WriteLine("Arquivos:");
            var arquivos = Directory.GetFiles(dirProjeto);
            foreach (var arquivo in arquivos)
            {
                Console.WriteLine(arquivo);
            }

            Console.WriteLine("Raiz do projeto:");
            Console.WriteLine(Directory.GetDirectoryRoot(dirProjeto));

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Pressione Enter para continuar...");
            Console.ReadLine();
        }
    }
}
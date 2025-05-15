using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.Api
{
    public static class ExtensaoString
    {
        public static string ParseHome(this string caminho)
        {
            string home = (Environment.OSVersion.Platform == PlatformID.Unix ||
                Environment.OSVersion.Platform == PlatformID.MacOSX)
                ? Environment.GetEnvironmentVariable("HOME") ?? string.Empty
                : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");
            return home;
        }
    }   

    public class PrimeiroArquivo
    {
        public static void Executar()
        {
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Primeiro Arquivo");
            Console.WriteLine("-------------------------------------------------");

            var caminho = @"Api/ArquivoApi.txt";

            // Cria ou sobrescreve o arquivo
            using (var file = new StreamWriter(caminho, false))
            {
                file.WriteLine("Primeira linha do arquivo");
                file.WriteLine("Segunda linha do arquivo");
                file.WriteLine("Terceira linha do arquivo");
            }

            Console.WriteLine("Arquivo criado/alterado com sucesso!");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Pressione Enter para continuar...");
            Console.ReadLine();
        }
    } 
}
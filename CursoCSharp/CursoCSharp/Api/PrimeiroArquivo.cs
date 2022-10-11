using System;
using System.Linq;
using System.IO;
using System.Threading.Tasks;

namespace CursoCSharp.Api
{
    public static class ExtensaoString
    {
        public static string ParseHome(this string path)
        {
            string home = (Environment.OSVersion.Platform == PlatformID.Unix ||
                Environment.OSVersion.Platform == PlatformID.MacOSX)
                ? Environment.GetEnvironmentVariable("HOME")
                : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");
            return path.Replace("~", home);
        }
    }

    internal class PrimeiroArquivo
    {
        public static void Executar()
        {//@ serve para fazer com que o caminho seja executado de maneira literal, mesmo com os caracteres especiais.
         // ~ serve para achar a pasta home do sistema do usuário que esta logado 

            var path = @"~/primeiro_arquivo.txt".ParseHome();

            if (!File.Exists(path)) {
                using (StreamWriter sw = File.CreateText(path)) {
                    sw.WriteLine("Esse é");
                    sw.WriteLine("o meu");
                    sw.WriteLine("primeiro");
                    sw.WriteLine("arquivo em c#!");
                }
            }
            using (StreamWriter sw = File.AppendText(path)) {
                sw.WriteLine("");
                sw.WriteLine("É possível");
                sw.WriteLine("adicionar");
                sw.WriteLine("mais texto!");
            }
        }
    }
}

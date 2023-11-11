using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estruturas_de_Repetição_e_Recursividade
{
    internal class Recursividade
    {
        public static void lerArquivo(int numArquivo)
        {
            string arquivoComNome = $"C:\\Users\\ismaelana\\OneDrive\\Documentos\\arquivo\\Arquivos\\arq{numArquivo}.txt";
            if (File.Exists(arquivoComNome)) { 
            using (StreamReader arquivo = File.OpenText(arquivoComNome))
            {
                string linha;
                while ((linha = arquivo.ReadLine()) != null)
                {
                        Console.WriteLine(linha);
                    }
            }
                string arquivoComNome2 = $"C:\\Users\\ismaelana\\OneDrive\\Documentos\\arquivo\\Arquivos\\arq{numArquivo + 1}.txt";
                if (File.Exists(arquivoComNome2))
                {
                    lerArquivo(numArquivo + 1);
                }
            }
        }

        /*static void Main(string[] args)
         {
        lerArquivo(1);
        }*/
    }
}

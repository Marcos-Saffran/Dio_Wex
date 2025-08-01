using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class LeituraArquivo
    {
        public (bool Sucesso, string[] Linhas, int TotalLinhas) LerArquivo(string caminhoArquivo)
        {
            try
            {
                if (!File.Exists(caminhoArquivo))
                {
                    Console.WriteLine($"Arquivo não encontrado: {caminhoArquivo}");
                    return (false, new string[0], 0);
                }

                var linhas = File.ReadAllLines(caminhoArquivo);
                return (true, linhas, linhas.Count());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao ler o arquivo: {ex.Message}");
                return (false, new string[0], 0);
            }
        }
    }
}
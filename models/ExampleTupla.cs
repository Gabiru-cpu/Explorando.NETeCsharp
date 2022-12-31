using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIO_explorando.NET_C_.models
{
    public class ExampleTupla
    {
        public void TUPLA()
        {
            (int idade, string nome, string sobrenome, decimal altura) tupla = (18, "Gabriel", "Henrique", 1.80M);

            Console.WriteLine($"Idade: {tupla.idade} | nome: {tupla.nome} | sobrenome: {tupla.sobrenome} | altura: {tupla.altura}");
        }

        public (bool checkLeitura, string[] linhas, int quantidadeLinhas) LeituraTupla(string caminho)
        {
            try
            {
                string[] lerLinha = File.ReadAllLines(caminho);

                return (true, lerLinha, lerLinha.Count());
            }
            catch (Exception) { return(false, new string[0], 0); }
            
        }
    }
}
using CsvHelper;
using Picoletes.API.Interfaces;
using Picoletes.API.Models;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace Picoletes.API.Repository
{
    public class RetiradaRepository : IRetiradaRepository
    {
        public void RealizarRetirada()
        {
            //
        }
        public void GerarBaseRetirada()
        {

            string nomeArquivo = "estoqueInicial.csv";

            var arquivoInicial = new List<Retirada>
            {
                new Retirada { Id = "S5312", DescricaoProduto = "Sorvete de flocos 200g", QtdEstoque = 200 , QtdRetirada = 10, ValidadeForaFreezer = 4},
                new Retirada { Id = "S1426", DescricaoProduto = "Sorvete de morango 200g", QtdEstoque = 140 , QtdRetirada = 9, ValidadeForaFreezer = 4},
                new Retirada { Id = "S1187", DescricaoProduto = "Sorvete de chocolate 200g", QtdEstoque = 127 , QtdRetirada = 11, ValidadeForaFreezer = 4},
                new Retirada { Id = "P3214", DescricaoProduto = "Picole de chocolate", QtdEstoque = 351 , QtdRetirada = 12, ValidadeForaFreezer = 5},
                new Retirada { Id = "P7568", DescricaoProduto = "Picole de morango", QtdEstoque = 402 , QtdRetirada = 15, ValidadeForaFreezer = 5},
                new Retirada { Id = "P6853", DescricaoProduto = "Acai com frutas 200g", QtdEstoque = 50 , QtdRetirada = 8, ValidadeForaFreezer = 3},
                new Retirada { Id = "A1442", DescricaoProduto = "Picole de limao com leite", QtdEstoque = 274 , QtdRetirada = 20, ValidadeForaFreezer = 5},
            };
            var diretorio = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

            if (File.Exists(Path.Combine(diretorio, nomeArquivo)))
                File.Delete(Path.Combine(diretorio, nomeArquivo));

            using (var writer = new StreamWriter($"{diretorio}\\{nomeArquivo}"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(arquivoInicial);
            }
        }
    }
}

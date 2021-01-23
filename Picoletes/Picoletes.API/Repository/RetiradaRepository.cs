using CsvHelper;
using Picoletes.Core.Interfaces;
using Picoletes.Core.Models;
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

        public void RealizarRetirada(PedidoRetirada pedido)
        {
            //
        }

        public void GerarBaseRetirada()
        {

            string nomeArquivo = "estoqueInicial.csv";

            var arquivoInicial = new List<UnidadeRetirada>
            {
                new UnidadeRetirada ("S5312", "Sorvete de flocos 200g", 200 ,  10,  4),
                new UnidadeRetirada ("S1426", "Sorvete de morango 200g", 140 ,  9,  4),
                new UnidadeRetirada ("S1187", "Sorvete de chocolate 200g", 127 ,  11,  4),
                new UnidadeRetirada ("P3214", "Picole de chocolate", 351 ,  12,  5),
                new UnidadeRetirada ("P7568", "Picole de morango", 402 ,  15,  5),
                new UnidadeRetirada ("P6853", "Acai com frutas 200g", 50 ,  8,  3),
                new UnidadeRetirada ("A1442", "Picole de limao com leite", 274 , 20,  5)
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

﻿using Picoletes.Core.Interfaces;
using Picoletes.Core.Models;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Net;
using System.IO;
using Picoletes.Interface.Repository;

namespace Picoletes.Interface.Services
{
    public class RetiradaService : IRetiradaService
    {
        public List<UnidadeRetirada> GerarPedidoRetirada()
        {
            return new List<UnidadeRetirada>
            {
                new UnidadeRetirada ("S5312", "Sorvete de flocos 200g", 200 ,  10,  4),
                new UnidadeRetirada ("S1426", "Sorvete de morango 200g", 140 ,  9,  4),
                new UnidadeRetirada ("S1187", "Sorvete de chocolate 200g", 127 ,  11,  4),
                new UnidadeRetirada ("P3214", "Picole de chocolate", 351 ,  12,  5),
                new UnidadeRetirada ("P7568", "Picole de morango", 402 ,  15,  5),
                new UnidadeRetirada ("P6853", "Acai com frutas 200g", 50 ,  8,  3),
                new UnidadeRetirada ("A1442", "Picole de limao com leite", 274 , 20,  5)
            };
        }

        public List<UnidadeRetirada> GerarPedidoRetirada(PedidoRetirada pedidoRetirada)
        {
            return new List<UnidadeRetirada>
            {
                new UnidadeRetirada ("S5312", "Sorvete de flocos 200g", 200 ,  pedidoRetirada.qntSFloc,  4),
                new UnidadeRetirada ("S1426", "Sorvete de morango 200g", 140 ,  pedidoRetirada.qntSMor,  4),
                new UnidadeRetirada ("S1187", "Sorvete de chocolate 200g", 127 ,  pedidoRetirada.qntSChoc,  4),
                new UnidadeRetirada ("P3214", "Picole de chocolate", 351 ,  pedidoRetirada.qntPChoc,  5),
                new UnidadeRetirada ("P7568", "Picole de morango", 402 ,  pedidoRetirada.qntPMor,  5),
                new UnidadeRetirada ("P6853", "Acai com frutas 200g", 50 ,  pedidoRetirada.qntAFrut,  3),
                new UnidadeRetirada ("A1442", "Picole de limao com leite", 274 , pedidoRetirada.qntPLim,  5)
            };
        }

        public void RealizarRetirada(PedidoRetirada pedidoRetirada)
        {
            RetiradaRepository retiradaRepository = new RetiradaRepository();
            var estoqueAtual = retiradaRepository.GetEstoqueAtual();
        }

    }
}

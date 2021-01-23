using Picoletes.API.Interfaces;
using Picoletes.API.Models;
using System.Collections.Generic;

namespace Picoletes.API.Services
{
    public class RetiradaService : IRetiradaService
    {
        private readonly IRetiradaRepository _retiradaRepository;

        public RetiradaService(IRetiradaRepository retiradaRepository)
        {
            _retiradaRepository = retiradaRepository;
        }
        
        public void GerarBaseRetirada()
        {
            _retiradaRepository.GerarBaseRetirada();
        }


        public void RealizarRetirada(PedidoRetirada pedido)
        {
            _retiradaRepository.RealizarRetirada(pedido);
        }

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

        public List<UnidadeRetirada> GerarPedidoRetirada(QuantidadeSabores quantidadeSabores)
        {
            return new List<UnidadeRetirada>
            {
                new UnidadeRetirada ("S5312", "Sorvete de flocos 200g", 200 ,  quantidadeSabores.qntSFloc,  4),
                new UnidadeRetirada ("S1426", "Sorvete de morango 200g", 140 ,  quantidadeSabores.qntSMor,  4),
                new UnidadeRetirada ("S1187", "Sorvete de chocolate 200g", 127 ,  quantidadeSabores.qntSChoc,  4),
                new UnidadeRetirada ("P3214", "Picole de chocolate", 351 ,  quantidadeSabores.qntPChoc,  5),
                new UnidadeRetirada ("P7568", "Picole de morango", 402 ,  quantidadeSabores.qntPMor,  5),
                new UnidadeRetirada ("P6853", "Acai com frutas 200g", 50 ,  quantidadeSabores.qntAFrut,  3),
                new UnidadeRetirada ("A1442", "Picole de limao com leite", 274 , quantidadeSabores.qntPLim,  5)
            };
        }


    }
}

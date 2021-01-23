using Picoletes.API.Models;
using System.Collections.Generic;

namespace Picoletes.API.Interfaces
{
    public interface IRetiradaService
    {
        void GerarBaseRetirada();
        void RealizarRetirada(PedidoRetirada pedido);
        List<UnidadeRetirada> GerarPedidoRetirada();
        List<UnidadeRetirada> GerarPedidoRetirada(QuantidadeSabores quantidadeSabores);
    }
}

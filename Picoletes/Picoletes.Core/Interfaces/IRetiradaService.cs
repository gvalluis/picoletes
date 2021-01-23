using Picoletes.Core.Models;
using System.Collections.Generic;

namespace Picoletes.Core.Interfaces
{
    public interface IRetiradaService
    {
        void GerarBaseRetirada();
        void RealizarRetirada(PedidoRetirada pedido);
        List<UnidadeRetirada> GerarPedidoRetirada();
        List<UnidadeRetirada> GerarPedidoRetirada(PedidoRetirada pedidoRetirada);
    }
}

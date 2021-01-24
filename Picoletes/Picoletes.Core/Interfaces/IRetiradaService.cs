using Picoletes.Core.Models;
using System.Collections.Generic;

namespace Picoletes.Core.Interfaces
{
    public interface IRetiradaService
    {
        List<UnidadeRetirada> GerarPedidoRetirada();
        List<UnidadeRetirada> GerarPedidoRetirada(PedidoRetirada pedidoRetirada);
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Picoletes.Dominio.Interfaces
{
    public interface IRetiradaRepository
    {
        public void RealizarRetirada();
        public void GerarBaseRetirada();
    }
}

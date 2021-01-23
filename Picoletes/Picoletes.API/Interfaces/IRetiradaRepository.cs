using System;
using System.Collections.Generic;
using System.Text;

namespace Picoletes.API.Interfaces
{
    public interface IRetiradaRepository
    {
        public void RealizarRetirada();
        public void GerarBaseRetirada();
    }
}

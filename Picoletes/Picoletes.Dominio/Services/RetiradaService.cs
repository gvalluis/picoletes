using CsvHelper;
using Picoletes.Dominio.Interfaces;
using Picoletes.Dominio.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;

namespace Picoletes.Dominio.Services
{
    public class RetiradaService
    {
        private readonly IRetiradaRepository _retiradaRepository;

        public RetiradaService()
        {
        }

        public RetiradaService(IRetiradaRepository retiradaRepository)
        {
            _retiradaRepository = retiradaRepository;
        }
        
        public void GerarBaseRetirada()
        {
            _retiradaRepository.GerarBaseRetirada();
        }
    }
}

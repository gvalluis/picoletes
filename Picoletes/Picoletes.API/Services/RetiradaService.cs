using Picoletes.Dominio.Interfaces;

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

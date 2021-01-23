using Picoletes.API.Interfaces;

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
    }
}

using dsmovie.Domain;

namespace dsmovie.Service.AvaliacaoService
{
    public interface IAvaliacaoService : IService
    {
        void RegisterScore(int avaliacao);
    }
}

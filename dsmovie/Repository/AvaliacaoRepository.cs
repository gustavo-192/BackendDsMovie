using dsmovie.Data;
using dsmovie.Entities;

namespace dsmovie.Repository
{
    public class AvaliacaoRepository : Repository, IAvaliacaoRepository
    {
        private BackendContext _context;

        public AvaliacaoRepository(BackendContext context) : base(context)
        {
            _context = context;
        }

        public void RegisterScore(int avaliacao)
        {
            throw new System.NotImplementedException();
        }
    }
}

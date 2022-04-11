using dsmovie.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dsmovie.Entities
{
    public interface IAvaliacaoRepository : IRepository
    {
        void RegisterScore(int avaliacao);
    }
}

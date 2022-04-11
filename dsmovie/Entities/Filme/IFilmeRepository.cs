using dsmovie.Domain;
using System.Collections.Generic;

namespace dsmovie.Entities
{
    public interface IFilmeRepository : IRepository
    {
        List<Filme> SkipTakeMovies(int size, int actualPage);
        Filme GetByIdIncludeScores(long id);
        Filme GetByTitle(string titulo);

    }
}

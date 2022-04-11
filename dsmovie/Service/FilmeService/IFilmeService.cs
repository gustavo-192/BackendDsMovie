using dsmovie.Domain;
using dsmovie.DTO;
using dsmovie.Entities;
using System.Collections.Generic;

namespace dsmovie.Service
{
    public interface IFilmeService : IService
    {
        MoviePage ConfigurarPage();
        void RecordMovie(FilmeDto dto);
        List<Filme> SkipTakeMovies(int size, int actualPage);
        Filme GetByIdIncludeScores(long id);
        Filme GetByTitle(string titulo);
    }
}

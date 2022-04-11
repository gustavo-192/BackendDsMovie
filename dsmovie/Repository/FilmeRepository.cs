using Backend.DadosMocados;
using dsmovie.Data;
using dsmovie.DTO;
using dsmovie.Entities;
using System.Collections.Generic;

namespace dsmovie.Repository
{
    public class FilmeRepository : Repository, IFilmeRepository
    {
        private BackendContext _context;
        public FilmeRepository(BackendContext context) : base(context)
        {
            _context = context;
        }
        public List<Filme> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public List<Filme> SkipTakeMovies(int size, int actualPage)
        {
            throw new System.NotImplementedException();
        }

        public Filme GetByIdIncludeScores(long id)
        {
            throw new System.NotImplementedException();
        }

        public Filme GetByTitle(string titulo)
        {
            throw new System.NotImplementedException();
        }
        public void RecordMovie(FilmeDto dto)
        {
            throw new System.NotImplementedException();
        }
    }
}

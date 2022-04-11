using dsmovie.DTO;
using dsmovie.Entities;
using dsmovie.Repository;
using System.Collections.Generic;

namespace dsmovie.Service
{
    public class FilmeService : Service, IFilmeService
    {
        private IFilmeRepository _filmeRepository;
        
        public FilmeService(IFilmeRepository filmeRepository)
        {
            _filmeRepository = filmeRepository;
        }   

        public MoviePage ConfigurarPage()
        {
            return new MoviePage {Content = GetAll<Filme>() };
        }
        public List<Filme> GetAll()
        {
            return _filmeRepository.GetAll<Filme>();
        }

        public List<Filme> SkipTakeMovies(int size, int actualPage)
        {
            throw new System.NotImplementedException();
        }

        public Filme GetByIdIncludeScores(long id)
        {
            return _filmeRepository.GetById<Filme>(id);
        }

        public Filme GetByTitle(string titulo)
        {
            return _filmeRepository.GetByTitle(titulo);
        }
        public void RecordMovie(FilmeDto dto)
        {
            _filmeRepository.Save(new Filme(dto.Id, dto.Avaliacao, dto.Contagem, dto.TituloFilme, dto.Imagem));
        }
    }
}

using dsmovie.DTO;
using dsmovie.Entities;
using dsmovie.Service;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace dsmovie.Controllers
{
    [EnableCors("MyPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public class FilmeController : ControllerBase
    {
        private IFilmeService _filmeService;

        private readonly ILogger<FilmeController> _logger;

        public FilmeController(ILogger<FilmeController> logger, IFilmeService filmeService)
        {
            _logger = logger;
            _filmeService = filmeService;
        }

        [EnableCors("MyPolicy")]
        [HttpGet, Route("buscar-todos")]
        public MoviePage GetAll()
        {
            return _filmeService.ConfigurarPage();
        }

        [HttpGet, Route("buscar-por-id")]
        public Filme GetById(int id)
        {
            return _filmeService.GetById<Filme>(id);
        }

        [HttpGet, Route ("buscar-por-titulo")]
        public Filme GetByTitle(string titulo)
        {
            return _filmeService.GetByTitle(titulo);
        }

        [HttpPost, Route ("registrar-filme")]
        public void RecordMovie(FilmeDto dto)
        {
            _filmeService.RecordMovie(dto);
        }
        
            /*Id = id;
            Avaliacao = avaliacao;
            Contagem = contagem;
            Titulo = titulo;
            Imagem = imagem;*/
    }
}

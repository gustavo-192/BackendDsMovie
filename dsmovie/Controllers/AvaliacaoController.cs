using dsmovie.Service.AvaliacaoService;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace dsmovie.Controllers
{
    [EnableCors("MyPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public class AvaliacaoController : Controller
    {
        private IAvaliacaoService _avaliacaoService;
        private readonly ILogger<FilmeController> _logger;

        public AvaliacaoController(ILogger<FilmeController> logger, IAvaliacaoService avaliacaoService)
        {
            _avaliacaoService = avaliacaoService;
            _logger = logger;
        }

        [EnableCors("MyPolicy")]
        [HttpPost, Route("registrar-avaliacao")]
        public void RegistrarAvaliacao(int avaliacao)
        {
            _avaliacaoService.RegisterScore(avaliacao);
        }
    }
}

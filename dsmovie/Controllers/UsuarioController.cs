using dsmovie.DTO;
using dsmovie.Entities;
using dsmovie.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace dsmovie.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private IUsuarioService _usuarioService;
        private readonly ILogger<FilmeController> _logger;

        public UsuarioController(ILogger<FilmeController> logger, IUsuarioService usuarioService)
        {
            _logger = logger;
            _usuarioService = usuarioService;
        }

        [HttpGet, Route ("buscar-todos")]
        public List<Usuario> GetAll()
        {
            return _usuarioService.GetAll<Usuario>();
        }

        [HttpGet, Route ("buscar-por-id")]
        public Usuario GetById(int id)
        {
            return _usuarioService.GetById<Usuario>(id);
        }

        [HttpPost, Route ("registrar-usuario")]
        public void RegisterUser(UsuarioDto usuarioDto)
        {
            _usuarioService.RegisterUser(usuarioDto);
        }
    }
}

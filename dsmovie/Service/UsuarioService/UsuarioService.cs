using dsmovie.DTO;
using dsmovie.Entities;
using dsmovie.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dsmovie.Service
{
    public class UsuarioService : Service, IUsuarioService
    {
        private IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
        public List<Usuario> BuscarTodos()
        {
            return _usuarioRepository.GetAll<Usuario>();
        }
        public Usuario BuscarPorId(int id)
        {
            return _usuarioRepository.GetById<Usuario>(id);
        }
        public void RegisterUser(UsuarioDto usuarioDto)
        {
            _usuarioRepository.RegisterUser(new Usuario(usuarioDto.Id, usuarioDto.Email));
        }
    }
}

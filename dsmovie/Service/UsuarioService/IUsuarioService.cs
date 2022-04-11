using dsmovie.Domain;
using dsmovie.DTO;
using dsmovie.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dsmovie.Service
{
    public interface IUsuarioService : IService
    {
        void RegisterUser(UsuarioDto usuarioDto);
    }
}

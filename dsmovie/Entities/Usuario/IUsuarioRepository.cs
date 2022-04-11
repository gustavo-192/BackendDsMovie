using dsmovie.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dsmovie.Entities
{
    public interface IUsuarioRepository : IRepository
    {
        void RegisterUser(Usuario usuario);
    }
}

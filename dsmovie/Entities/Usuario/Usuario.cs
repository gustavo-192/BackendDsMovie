using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dsmovie.Entities
{
    public class Usuario : Entity
    {

        public long Id { get; set; }
        public string Email { get; set; }
        
        public Usuario()
        {

        }
        public Usuario(long id, string email)
        {
            Id = id;
            Email = email;
        }
    }
}

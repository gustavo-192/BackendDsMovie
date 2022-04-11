using dsmovie.Domain;
using dsmovie.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dsmovie.Service
{
    public class Service : IService
    {
        public List<T> GetAll<T>() where T : Entity
        {
            throw new NotImplementedException();
        }

        public T GetById<T>(long id) where T : Entity
        {
            throw new NotImplementedException();
        }

        public int GetTotalRegister<T>() where T : Entity
        {
            throw new NotImplementedException();
        }

        public void Save<T>(T obj) where T : Entity
        {
            throw new NotImplementedException();
        }

        public void Update<T>(T obj) where T : Entity
        {
            throw new NotImplementedException();
        }
    }
}

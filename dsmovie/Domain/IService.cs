using dsmovie.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dsmovie.Domain
{
    public interface IService 
    {
        T GetById<T>(long id) where T : Entity;
        List<T> GetAll<T>() where T : Entity;
        int GetTotalRegister<T>() where T : Entity;
        void Update<T>(T obj) where T : Entity;
        void Save<T>(T obj) where T : Entity;
    }
}

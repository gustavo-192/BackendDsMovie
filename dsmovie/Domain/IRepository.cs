using dsmovie.Entities;
using System.Collections.Generic;

namespace dsmovie.Domain
{
    public interface IRepository 
    {
        T GetById<T>(long id) where T : Entity;
        List<T> GetAll<T>() where T : Entity;
        int GetTotalRegister<T>() where T : Entity;
        void Update<T>(T obj) where T : Entity;
        void Save<T>(T obj) where T : Entity;

    }
}

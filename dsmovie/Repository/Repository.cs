using dsmovie.Data;
using dsmovie.Domain;
using dsmovie.Entities;
using System;
using System.Collections.Generic;

namespace dsmovie.Repository
{
    public class Repository : IRepository
    {
        private BackendContext _context; 
        public Repository(BackendContext context)
        {
            _context = context;
        }
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
            _context.Set<T>().Add(obj);
            _context.SaveChanges();
        }

        public void Update<T>(T obj) where T : Entity
        {
            throw new NotImplementedException();
        }
    }
}

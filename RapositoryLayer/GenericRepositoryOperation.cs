using Microsoft.EntityFrameworkCore;
using RapositoryLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapositoryLayer
{
    public class GenericRepositoryOperation<T> : IGenericRepositoryOperation<T> where T : class
    {
        DbContext _Context;
        readonly DbSet<T> _dbset;
        public GenericRepositoryOperation(DbContext product)
        {
            _Context = product;
            _dbset = _Context.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return _dbset.ToList();
        }

        public void Add(T entity)
        {
            _dbset.Add(entity);
            _Context.SaveChanges();
        }

        public void Update(T entity)
        {
            _dbset.Update(entity);
            _Context.SaveChanges();
        }

        public void Delete(T entity)
        {
            _dbset.Remove(entity);
        }

        public void GetById(int Id)
        {
            _dbset.Find(Id);
        }

        public void Save()
        {
            _Context.SaveChanges();
        }

       
    }
}

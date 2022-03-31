using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapositoryLayer.Interface
{
   public  interface IGenericRepositoryOperation<T>
    {
        IEnumerable<T> GetAll();
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void GetById(int Id);
        void Save();


    }
}

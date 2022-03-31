using DomainLayer;
using RapositoryLayer;
using RapositoryLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesLogic
{
  public  class ProductCatalog
    {

        ProductDbContext _Context;
        IGenericRepositoryOperation<Product> _Repo;
        public ProductCatalog(ProductDbContext Context)
        {
            _Context = Context;
            _Repo = new GenericRepositoryOperation<Product>(_Context);
        }

        public ProductCatalog()
        {
        }

        public void Add(Product product)
        {
            _Repo.Add(product);
            _Repo.Save();
        }
        public void Update(Product product)
        {
            _Repo.Update(product);
            _Repo.Save();
        }
        public void Delete(Product product)
        {
            _Repo.Delete(product);
            _Repo.Save();
        }
        public IEnumerable<Product> GetAll()
        {
            return _Repo.GetAll();
        }
        public void GetById(int Id)
        {
            _Repo.GetById(Id);
        }
    }
}

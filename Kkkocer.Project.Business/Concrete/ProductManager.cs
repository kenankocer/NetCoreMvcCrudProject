using Kkkocer.Project.Business.Abstract;
using Kkocer.Project.DataAccess.Abstract;
using Kkocer.Project.Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Kkkocer.Project.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;    
        }

        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }

        public Product GetById(int id)
        {
            return _productDal.GetById(id);
        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }
    }
}

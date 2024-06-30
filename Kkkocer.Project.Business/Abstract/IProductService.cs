using Kkocer.Project.Entities.Concrete;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Kkkocer.Project.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();

        void Add(Product product);

        void Update(Product product);

        Product GetById(int id);

        void Delete(Product product);
    }
}

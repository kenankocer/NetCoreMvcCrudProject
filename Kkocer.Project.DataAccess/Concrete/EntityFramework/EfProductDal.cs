using Kkocer.Project.Core.DataAccess.EntityFramework;
using Kkocer.Project.DataAccess.Abstract;
using Kkocer.Project.Entities.Concrete;

namespace Kkocer.Project.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, DemoContext> , IProductDal
    {
    }
}

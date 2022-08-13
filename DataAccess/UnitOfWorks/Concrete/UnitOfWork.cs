using DataAccess.Abstract;
using DataAccess.UnitOfWorks.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.UnitOfWorks.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        public IProductRepository productRepository => throw new NotImplementedException();

        public ICategoryRepository categoryRepository => throw new NotImplementedException();

        public Task SaveAsync()
        {
            throw new NotImplementedException();
        }
    }
}

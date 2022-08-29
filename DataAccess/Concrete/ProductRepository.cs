using Core.Data.Concrete.EntityFramework;
using Core.Entities;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class ProductRepository : EfGenericRepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(OnlineMenuContext context) : base(context)
        {
        }
    }
}

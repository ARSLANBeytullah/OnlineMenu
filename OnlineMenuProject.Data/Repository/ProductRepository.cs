using OnlineMenuProject.Core.Entities;
using OnlineMenuProject.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMenuProject.Data.Repository
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(OnlineMenuContext context) : base(context)
        {
        }
    }
}

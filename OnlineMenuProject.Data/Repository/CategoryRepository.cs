using OnlineMenuProject.Core.Entities;
using OnlineMenuProject.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMenuProject.Data.Repository
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(OnlineMenuContext context) : base(context)
        {
        }
    }
}

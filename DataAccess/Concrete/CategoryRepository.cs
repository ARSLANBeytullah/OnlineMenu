using Core.Data.Concrete.EntityFramework;
using Core.Entities;
using DataAccess.Abstract;
using DataAccess.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class CategoryRepository : EfGenericRepositoryBase<Category>,ICategoryRepository
    {

        public CategoryRepository(AppDbContext context) : base(context)
        {

        }
    }
}

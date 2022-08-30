using OnlineMenu.Core.Repositories;
using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Contexts;
using OnlineMenu.Core.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMenu.Data.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }
        private ProductRepository _productRepository;
        private CategoryRepository _categoryRepository;

        Core.Repositories.IProductRepository productRepository => (_productRepository ??= new ProductRepository(_context));

        Core.Repositories.ICategoryRepository categoryRepository => 

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}

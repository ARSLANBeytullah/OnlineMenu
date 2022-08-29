using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Contexts;
using DataAccess.UnitOfWorks.Abstract;
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
        private readonly ProductRepository _productRepository;
        private readonly CategoryRepository _categoryRepository;

        public IProductRepository productRepository => _productRepository ??= new ProductRepository(_context);

        public ICategoryRepository categoryRepository => _categoryRepository ??= new CategoryRepository(_context);

        public ICategoryRepository categoryRepository => throw new NotImplementedException();

        public Task SaveAsync()
        {
            throw new NotImplementedException();
        }
    }
}

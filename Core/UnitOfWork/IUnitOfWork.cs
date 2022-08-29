using OnlineMenu.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMenu.Core.UnitOfWork
{
    public interface IUnitOfWork
    {
        IProductRepository productRepository { get; }
        ICategoryRepository categoryRepository { get; }

        Task SaveAsync();
    }
}

using OnlineMenuProject.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMenuProject.Core.UnitOfWork
{
    public interface IUnitOfWork
    {
        IProductRepository productRepository { get; }
        ICategoryRepository categoryRepository { get; }

        Task SaveAsync();
    }
}

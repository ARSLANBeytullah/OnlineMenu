using Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryDto>> GetAllAsync(int userId);
        Task<CategoryDto> GetByIdAsync(int id);
        Task AddAysnc(CategoryAddDto entity);
        Task Update(CategoryUpdateDto entity);
        Task Delete(int id);
        Task<bool> AnyAsync();
        Task<int> CountAsync();
    }
}

﻿using Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetAllAsync(int userId);
        Task<ProductDto> GetByIdAsync(int id);
        Task AddAysnc(ProductAddDto entity);
        Task Update(ProductUpdateDto entity);
        Task Delete(int id);
        Task<bool> AnyAsync();
        Task<int> CountAsync();
    }
}

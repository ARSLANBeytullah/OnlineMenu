﻿using Core.Data.Abstract;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
    }
}
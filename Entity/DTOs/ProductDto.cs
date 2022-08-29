﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTOs
{
    public class ProductDto
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public string? Image { get; set; }

        public string? Info { get; set; }

    }
}
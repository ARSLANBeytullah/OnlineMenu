﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMenuProject.Core.Dtos
{
    public class ProductAddDto
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public string? Image { get; set; }

        public string? Info { get; set; }
        public int UserId { get; set; }
        public int CategoryId { get; set; }
    }
}

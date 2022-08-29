using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMenu.Core.DTOs
{
    public class CategoryAddDto
    {
        public string Name { get; set; }
        public string? Image { get; set; }
        public int UserId { get; set; }
    }
}

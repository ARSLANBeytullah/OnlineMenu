using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Category : BaseEntity,IEntity
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public ICollection<Product> Products { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}

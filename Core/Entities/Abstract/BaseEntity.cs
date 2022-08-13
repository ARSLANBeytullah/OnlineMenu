using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public abstract class BaseEntity
    {
        public virtual int Id { get; set; }
        public virtual DateTime CreatedByName { get; set; }
        public virtual DateTime ModifiedByName { get; set; }
        public virtual bool IsActive { get; set; }
        public virtual bool IsDeleted { get; set; }
    }
}

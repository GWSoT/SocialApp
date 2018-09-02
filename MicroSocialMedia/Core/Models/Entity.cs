using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroSocialMedia.Core.Models
{
    public abstract class Entity<T> 
    {
        public T Id { get; set; }

        public override bool Equals(object obj)
        {

            if (!(obj is Entity<T> item))
            {
                return false;
            }

            return this.Id.Equals(item.Id);
        }
       
        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }
    }
}

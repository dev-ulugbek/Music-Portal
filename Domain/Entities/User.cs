using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class User : Person
    {
        public string Email { get; set; }
        public virtual ICollection<Purchase> Purchases { get; set; }
    }
}

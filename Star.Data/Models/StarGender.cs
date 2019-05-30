using System;
using System.Collections.Generic;

namespace Star.Data.Models
{
    public partial class StarGender
    {
        public StarGender()
        {
            StarEmployee = new HashSet<StarEmployee>();
        }

        public int Id { get; set; }
        public string ContentfulId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<StarEmployee> StarEmployee { get; set; }
    }
}

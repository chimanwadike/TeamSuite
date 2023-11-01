using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamSuite.Entities.Models
{
    public class Site
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public ICollection<Team>? Teams { get; set; }
        public ICollection<Member>? Members { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamSuite.Entities.Models
{
    public class SubTeam
    {
        public Guid Id { get; set; }
        public Guid TeamId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Team? Team { get; set; }
    }
}

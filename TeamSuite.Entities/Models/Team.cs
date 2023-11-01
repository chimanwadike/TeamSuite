using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamSuite.Entities.Models
{
    public class Team
    {
        public Guid Id { get; set; }
        public Guid SiteId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<SubTeam> SubTeams { get; set; }
        public Site? Site { get; set; }
    }
}

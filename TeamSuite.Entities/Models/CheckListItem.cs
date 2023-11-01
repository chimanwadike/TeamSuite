using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamSuite.Entities.Models
{
    public class CheckListItem
    {
        public Guid Id { get; set; }
        //public Guid SiteId { get; set; }
        //public Guid TeamId  { get; set; }
        //public Guid SubTeamId { get; set; }
        public string Name { get; set; } = default!;
        public string? Description { get; set; }
        //public Guid SeverityLevel { get; set; }
        public Guid Status { get; set; }
    }
}

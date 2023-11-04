using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamSuite.Entities.Models
{
    public class CheckListReport
    {
        public Guid Id { get; set; }
        public Guid CheckListId { get; set; }
        public Guid Status { get; set; }
        public string CompletedBy { get; set; } = default!;
        public DateTime TimeCompleted { get; set; } = DateTime.Now;
    }
}

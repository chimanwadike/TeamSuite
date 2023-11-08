using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamSuite.Shared.ReadDTOs
{
    public class CheckListReportReadDTO
    {
        public Guid Id { get; set; }
        public string Location { get; set; }
        public string Action { get; set; }
        public string Status { get; set; }
        public int Order { get; set; }
        public bool Completed { get; set; }

        public CheckListReportReadDTO(Guid Id, string Location, string Action, string Status, int Order)
        {
            this.Id = Id;
            this.Location = Location;
            this.Action = Action;
            this.Status = Status;
            this.Order = Order;
        }

        public CheckListReportReadDTO()
        {
            
        }
    }
}

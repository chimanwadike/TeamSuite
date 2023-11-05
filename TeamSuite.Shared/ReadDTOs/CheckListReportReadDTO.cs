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
        public Guid CheckListId { get; set; }
        public string LocationName { get; set; } = string.Empty;
        public string CheckListItemName { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public int Order { get; set; }
        public string CompletedBy { get; set; } = default!;
        public DateTime TimeCompleted { get; set; } = DateTime.Now;
        public string TimeString { get => this.TimeCompleted.ToLongTimeString(); }
        public string DateString { get => this.TimeCompleted.ToShortDateString(); }
        public string WeekDay { get => this.TimeCompleted.DayOfWeek.ToString(); }
    }
}

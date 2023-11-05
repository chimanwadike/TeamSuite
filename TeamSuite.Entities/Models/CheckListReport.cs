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
        public Guid Status { get; set; } = Guid.Parse("25cf2e32-36fa-47fe-a272-6afc8bd95f5c");
        public string? CompletedBy { get; set; } = default!;
        public bool Completed { get; set; } = false;
        public DateTime TimeCompleted { get; set; } = DateTime.UtcNow;
        public string TimeString { get => TimeCompleted.ToLongTimeString(); private set => _ = value; }
        public string DateString { get => TimeCompleted.ToShortDateString(); private set => _ = value; }
        public string WeekDay { get => TimeCompleted.DayOfWeek.ToString(); private set => _ = value; }

        public CheckList CheckList { get; set; }
    }
}

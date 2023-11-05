﻿using System;
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
        public DateTime TimeCompleted { get; set; } = DateTime.Now;
        public string TimeString { get => this.TimeCompleted.ToLongTimeString(); }
        public string DateString { get => this.TimeCompleted.ToShortDateString(); }
        public string WeekDay { get => this.TimeCompleted.DayOfWeek.ToString(); }

        public CheckList checkList { get; set; }
    }
}

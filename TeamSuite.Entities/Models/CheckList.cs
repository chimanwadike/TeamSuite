using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamSuite.Entities.Models
{
    public class CheckList
    {
        public Guid Id { get; set; }
        public Guid CheckListItemId { get; set; }
        public Guid CheckListFormId { get; set; }
        public Guid LocationId { get; set; }

        public int Order {  get; set; }

        public CheckListItem CheckListItem { get; set; }
        public CheckListForm CheckListForm { get; set; }
        public Location Location { get; set; }
    }
}

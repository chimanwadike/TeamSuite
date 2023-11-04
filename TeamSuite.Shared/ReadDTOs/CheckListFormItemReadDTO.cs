using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamSuite.Shared.ReadDTOs
{
    public class CheckListFormItemReadDTO
    {
        public string LocationId { get; set; }
        public string LocationName { get; set; }
        public string CheckListId { get; set; }
        public string CheckListItemName { get; set; }
        public string Status { get; set; }
        public int Order { get; set; }
    }
}

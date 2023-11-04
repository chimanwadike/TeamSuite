using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamSuite.Shared.ReadDTOs;

namespace TeamSuite.Contracts.IServices
{
    public interface ICheckListService
    {
        public IEnumerable<CheckListFormItemReadDTO> GetCheckList();
    }
}

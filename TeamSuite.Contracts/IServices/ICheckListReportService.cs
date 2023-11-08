using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamSuite.Entities.Models;
using TeamSuite.Shared.ReadDTOs;

namespace TeamSuite.Contracts.IServices
{
    public interface ICheckListReportService
    {
        public IEnumerable<CheckListReportReadDTO> GetCheckListReport();
        public IEnumerable<CheckListReportReadDTO> GetTodayCheckList(Guid checkListFormId);
        void GenerateTodayCheckList(Guid checkListFormId);
    }
}

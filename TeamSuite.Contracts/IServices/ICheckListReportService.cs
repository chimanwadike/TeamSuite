using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamSuite.Entities.Models;

namespace TeamSuite.Contracts.IServices
{
    public interface ICheckListReportService
    {
        public IEnumerable<CheckListReport> GetCheckListReport();
        public IEnumerable<CheckListReport> GetTodayCheckList(Guid checkListFormId);
        void GenerateTodayCheckList(Guid checkListFormId);
    }
}

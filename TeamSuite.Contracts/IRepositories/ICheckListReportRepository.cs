using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TeamSuite.Entities.Models;

namespace TeamSuite.Contracts.IRepositories
{
    public interface ICheckListReportRepository
    {
        IEnumerable<CheckListReport> GetAllCheckListReport(bool trackChanges);
        IEnumerable<CheckListReport> GetCheckListReportByCondition(bool trackChanges, Expression<Func<CheckListReport, bool>> expression);
        void Add(CheckListReport checkListReport);
    }
}

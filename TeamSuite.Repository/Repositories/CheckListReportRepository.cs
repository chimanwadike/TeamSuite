using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TeamSuite.Contracts.IRepositories;
using TeamSuite.Entities.Models;

namespace TeamSuite.Repository.Repositories
{
    public class CheckListReportRepository : RepositoryBase<CheckListReport>, ICheckListReportRepository
    {
        public CheckListReportRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void Add(CheckListReport checkListReport)
        {
            Create(checkListReport);
        }

        public IEnumerable<CheckListReport> GetAllCheckListReport(bool trackChanges)
        {
            return FindAll(trackChanges)
                .Include(_ => _.CheckList).ThenInclude(_ => _.Location)
                .Include(_ => _.CheckList).ThenInclude(_ => _.CheckListItem)
                .OrderBy(_ => _.CheckList.Order)
                .ToList();               
        }

        public IEnumerable<CheckListReport> GetCheckListReportByCondition(bool trackChanges, Expression<Func<CheckListReport, bool>> expression)
        {
            return FindByCondition(expression, trackChanges)
                .Include(_ => _.CheckList).ThenInclude(_ => _.Location)
                .Include(_ => _.CheckList).ThenInclude(_ => _.CheckListItem);                
        }
    }
}

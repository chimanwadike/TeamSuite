using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}

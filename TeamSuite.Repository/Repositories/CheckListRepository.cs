using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TeamSuite.Contracts.IRepositories;
using TeamSuite.Entities.Models;
using TeamSuite.Shared.ReadDTOs;

namespace TeamSuite.Repository.Repositories
{
    public class CheckListRepository : RepositoryBase<CheckList>, ICheckListRepository
    {
        public CheckListRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public IEnumerable<CheckList> GetAllCheckList(bool trackChanges)
        {
            return FindAll(trackChanges)                                
                .OrderBy(_ => _.Order);
        }

        public IEnumerable<CheckList> GetCheckListByCondition(bool trackChanges, Expression<Func<CheckList, bool>> expression)
        {
            return FindByCondition(expression, trackChanges).OrderBy(_ => _.Order);
        }
    }
}

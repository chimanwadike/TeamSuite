using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TeamSuite.Entities.Models;
using TeamSuite.Shared.ReadDTOs;

namespace TeamSuite.Contracts.IRepositories
{
    public interface ICheckListRepository
    {
        IEnumerable<CheckList> GetAllCheckList(bool trackChanges);
        IEnumerable<CheckList> GetCheckListByCondition(bool trackChanges, Expression<Func<CheckList, bool>> expression);
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public IEnumerable<CheckListFormItemReadDTO> GetAllCheckList(bool trackChanges)
        {
            return FindAll(trackChanges)
                .Include(_ => _.location)
                .Include(_ => _.checkListItem)                
                .Select(_ => new CheckListFormItemReadDTO { LocationId = _.LocationId.ToString(), LocationName = _.location.Name, CheckListId = _.Id.ToString(), CheckListItemName = _.checkListItem.Name, Status = "", Order = _.Order })
                .OrderBy(_ => _.Order);
        }
    }
}

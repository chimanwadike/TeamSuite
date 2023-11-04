using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamSuite.Contracts.IRepositories;

namespace TeamSuite.Contracts
{
    public interface IRepositoryManager
    {
        IMemberRepository MemberRepository { get; }
        ICheckListRepository CheckListRepository { get; }
        ICheckListReportRepository CheckListReportRepository { get; }
        void Save();
    }
}

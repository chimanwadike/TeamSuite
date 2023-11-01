using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamSuite.Contracts.IServices;

namespace TeamSuite.Contracts
{
    public interface IServiceManager
    {
        IMemberService MemberService { get; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamSuite.Contracts;
using TeamSuite.Contracts.IServices;
using TeamSuite.Service.Services;

namespace TeamSuite.Service
{
    public sealed class ServiceManager : IServiceManager
    {
        private readonly Lazy<IMemberService> _memberService;

        public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager logger)
        {
            _memberService = new Lazy<IMemberService>(() => new MemberService(repositoryManager, logger));            
        }

        public IMemberService MemberService => _memberService.Value;
    }
}

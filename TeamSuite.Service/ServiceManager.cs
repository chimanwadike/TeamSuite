using AutoMapper;
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
        private readonly Lazy<ICheckListService> _checkListService;
        private readonly Lazy<ICheckListReportService> _checkListReportService;

        public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper)
        {
            _memberService = new Lazy<IMemberService>(() => new MemberService(repositoryManager, logger));
            _checkListService = new Lazy<ICheckListService>(() => new CheckListService(repositoryManager,logger));
            _checkListReportService = new Lazy<ICheckListReportService>(() => new CheckListReportService(repositoryManager, logger, mapper));
        }

        public IMemberService MemberService => _memberService.Value;

        public ICheckListService CheckListService => _checkListService.Value;

        public ICheckListReportService CheckListReportService => _checkListReportService.Value;
    }
}

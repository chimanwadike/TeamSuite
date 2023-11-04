using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamSuite.Contracts;
using TeamSuite.Contracts.IRepositories;
using TeamSuite.Contracts.IServices;

namespace TeamSuite.Service.Services
{
    public class CheckListReportService : ICheckListReportService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;

        public CheckListReportService(IRepositoryManager repository, ILoggerManager logger)
        {
            _repository = repository;
            _logger = logger;
        }
    }
}

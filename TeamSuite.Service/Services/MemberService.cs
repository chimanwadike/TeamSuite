using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamSuite.Contracts;
using TeamSuite.Contracts.IServices;

namespace TeamSuite.Service.Services
{
    internal sealed class MemberService : IMemberService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;

        public MemberService(IRepositoryManager repository, ILoggerManager logger)
        {
            _repository = repository;
            _logger = logger;
        }
    }
}

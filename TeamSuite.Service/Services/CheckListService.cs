using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamSuite.Contracts;
using TeamSuite.Contracts.IServices;
using TeamSuite.Shared.ReadDTOs;

namespace TeamSuite.Service.Services
{
    public class CheckListService : ICheckListService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;

        public CheckListService(IRepositoryManager repository, ILoggerManager logger)
        {
            _repository = repository;
            _logger = logger;
        }

        public IEnumerable<CheckListFormItemReadDTO> GetCheckList()
        {
            return _repository.CheckListRepository
                 .GetAllCheckList(false);
        }
    }
}

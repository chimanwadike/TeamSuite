using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamSuite.Contracts;
using TeamSuite.Contracts.IRepositories;
using TeamSuite.Contracts.IServices;
using TeamSuite.Entities.Models;
using TeamSuite.Shared.ReadDTOs;

namespace TeamSuite.Service.Services
{
    public class CheckListReportService : ICheckListReportService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public CheckListReportService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public void GenerateTodayCheckList(Guid checkListFormId)
        {
           var today = DateTime.UtcNow.ToShortDateString();
            //check for individual existing element before creating
           IEnumerable<Guid> added_checklists =  _repository
                .CheckListReportRepository
                .GetCheckListReportByCondition(false, _ => _
                .CheckList.CheckListFormId == checkListFormId && _.DateString
                .Equals(today)).Select(_ => _.CheckListId).ToList();

            List<CheckList> checklists = _repository
                .CheckListRepository
                .GetCheckListByCondition(false, _ => _
                .CheckListFormId == checkListFormId && !added_checklists.Contains(_.Id)
                ).ToList();

            checklists.ForEach(checklist => { 
                _repository
                .CheckListReportRepository
                .Add(new CheckListReport 
                { 
                    Id = Guid.NewGuid(), 
                    CheckListId = checklist.Id 
                }); 
            });

            _repository.Save();
        }

        public IEnumerable<CheckListReportReadDTO> GetCheckListReport()
        {
            IEnumerable<CheckListReport> checklistreports = _repository
               .CheckListReportRepository
               .GetAllCheckListReport(false).OrderBy(_ => _.CheckList.Order)
               .ToList();

            var checklistreportDtos = _mapper.Map<IEnumerable<CheckListReportReadDTO>>(checklistreports);

            return checklistreportDtos;
        }

        public IEnumerable<CheckListReportReadDTO> GetTodayCheckList(Guid checkListFormId)
        {
            var today = DateTime.UtcNow.ToShortDateString();

            IEnumerable<CheckListReport> checklistreports = _repository
               .CheckListReportRepository
               .GetCheckListReportByCondition(false, _ => _
               .CheckList.CheckListFormId == checkListFormId && _.DateString
               .Equals(today))
               .OrderBy(_ => _.CheckList.Order)
               .ToList();

            var checklistreportDtos = _mapper.Map<IEnumerable<CheckListReportReadDTO>>(checklistreports);

            return checklistreportDtos;
        }
    }
}

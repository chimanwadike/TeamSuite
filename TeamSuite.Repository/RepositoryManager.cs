using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamSuite.Contracts;
using TeamSuite.Contracts.IRepositories;
using TeamSuite.Repository.Repositories;

namespace TeamSuite.Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _repositoryContext;
        private readonly Lazy<IMemberRepository> _memberRepository;
        private readonly Lazy<ICheckListRepository> _checkListRepository;
        private readonly Lazy<ICheckListReportRepository> _checkListReportRepository;

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
            _memberRepository = new Lazy<IMemberRepository>(() => new MemberRepository(repositoryContext));
            _checkListRepository = new Lazy<ICheckListRepository>(() => new CheckListRepository(repositoryContext));
            _checkListReportRepository = new Lazy<ICheckListReportRepository>(() => new CheckListReportRepository(repositoryContext));
        }

        public IMemberRepository MemberRepository => _memberRepository.Value;

        public ICheckListRepository CheckListRepository => _checkListRepository.Value;

        public ICheckListReportRepository CheckListReportRepository => _checkListReportRepository.Value;

        public void Save() => _repositoryContext.SaveChanges();
    }
}

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

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
            _memberRepository = new Lazy<IMemberRepository>(() => new MemberRepository(repositoryContext));
        }

        public IMemberRepository MemberRepository => _memberRepository.Value;

        public void Save() => _repositoryContext.SaveChanges();
    }
}

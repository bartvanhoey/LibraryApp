using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.UI;

namespace LibraryApp.Models
{
    public class AuthorManager: DomainService, IAuthorManager
    {
        private readonly IRepository<Author> _repo;

        public AuthorManager(IRepository<Author> repo)
        {
            _repo = repo;
        }

        public IEnumerable<Author> GetAllList() => _repo.GetAllIncluding(x => x.Books);

        public Author GetAuthorById(int id) => _repo.Get(id);

        public async Task<Author> Create(Author entity)
        {
            return _repo.FirstOrDefault(x => x.Id== entity.Id) == null
                ? await _repo.InsertAsync(entity)
                : throw new UserFriendlyException("Author already exist!");
        }

        public void Update(Author entity)
        {
            if (_repo.FirstOrDefault(x => x.Id == entity.Id) != null)
                _repo.Update(entity);
            else
                throw new UserFriendlyException("Author does not exist");
        }

        public void Delete(int id)
        {
            if (_repo.FirstOrDefault(x => x.Id == id) != null)
                _repo.Delete(_repo.FirstOrDefault(x => x.Id == id));
            else
                throw new UserFriendlyException("Author does not exist");
        }
    }
}
using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.UI;

namespace LibraryApp.Models
{
    public class CategoryManager : DomainService, ICategoryManager
    {
        private readonly IRepository<Category> _repo;

        public CategoryManager(IRepository<Category> repo)
        {
            _repo = repo;
        }

        public IEnumerable<Category> GetAllList() => _repo.GetAllIncluding(x => x.Books);

        public Category GetCategoryById(int id) => _repo.Get(id);

        public async Task<Category> Create(Category entity)
        {
            return _repo.FirstOrDefault(x => x.Id== entity.Id) == null
                ? await _repo.InsertAsync(entity)
                : throw new UserFriendlyException("Category already exist!");
        }

        public void Update(Category entity)
        {
            if (_repo.FirstOrDefault(x => x.Id == entity.Id) != null)
                _repo.Update(entity);
            else
                throw new UserFriendlyException("Category does not exist");
        }

        public void Delete(int id)
        {
            if (_repo.FirstOrDefault(x => x.Id == id) != null)
                _repo.Delete(_repo.FirstOrDefault(x => x.Id == id));
            else
                throw new UserFriendlyException("Category does not exist");
        }
    }
}
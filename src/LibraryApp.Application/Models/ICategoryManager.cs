using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Services;

namespace LibraryApp.Models
{
    public interface ICategoryManager: IDomainService
    {
        IEnumerable<Category> GetAllList();
        Category GetCategoryById(int id);
        Task<Category> Create(Category entity);
        void Update(Category entity);
        void Delete(int id);
    }
}
using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Services;

namespace LibraryApp.Models.Author
{
    public interface IAuthorManager : IDomainService
    {
        IEnumerable<Author> GetAllList();
        Author GetAuthorById(int id);
        Task<Author> Create(Author entity);
        void Update(Author entity);
        void Delete(int id);
    }
}
using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Services;

namespace LibraryApp.Models.Book
{
    public interface IBookManager : IDomainService
    {
        IEnumerable<Book> GetAllList();
        Book GetBookById(int id);
        Task<Book> Create(Book entity);
        void Update(Book entity);
        void Delete(int id);
    }
}
using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.UI;

namespace LibraryApp.Models.Book
{
    public class BookManager: DomainService, IBookManager
    {
        private readonly IRepository<Book> _repo;

        public BookManager(IRepository<Book> repo)
        {
            _repo = repo;
        }

        public IEnumerable<Book> GetAllList() => _repo.GetAll();

        public Book GetBookById(int id) => _repo.Get(id);

        public async Task<Book> Create(Book entity)
        {
            return _repo.FirstOrDefault(x => x.Id== entity.Id) == null
                ? await _repo.InsertAsync(entity)
                : throw new UserFriendlyException("Book already exist!");
        }

        public void Update(Book entity)
        {
            var book = _repo.FirstOrDefault(x => x.Id == entity.Id);
            if (book != null)
            {
                entity.MapTo(book);
                _repo.Update(book);
            }
            else
                throw new UserFriendlyException("Book does not exist");
        }

        public void Delete(int id)
        {
            if (_repo.FirstOrDefault(x => x.Id == id) != null)
                _repo.Delete(_repo.FirstOrDefault(x => x.Id == id));
            else
                throw new UserFriendlyException("Book does not exist");
        }
    }
}
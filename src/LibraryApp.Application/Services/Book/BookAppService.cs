using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services;
using AutoMapper;
using LibraryApp.Models;
using LibraryApp.Models.Book;
using LibraryApp.Services.Authors.DTO;
using LibraryApp.Services.Books.DTO;

namespace LibraryApp.Services.Books
{
    public class BookAppService : ApplicationService, IBookAppService
    {
        private readonly IBookManager _bookManager;

        public BookAppService(IBookManager bookManager) 
            => _bookManager = bookManager;

        public IEnumerable<GetBookOutput> ListALl() 
            => Mapper.Map<List<Book>, List<GetBookOutput>>(_bookManager.GetAllList().ToList());

        public async Task Create(CreateBookInput input) 
            => await _bookManager.Create(Mapper.Map<CreateBookInput, Book>(input));

        public void Update(UpdateBookInput input) 
            => _bookManager.Update(Mapper.Map<UpdateBookInput, Book>(input));

        public void Delete(DeleteBookInput input) 
            => _bookManager.Delete(input.Id);

        public GetBookOutput GetBookById(GetBookInput input) 
            => Mapper.Map<Book, GetBookOutput>(_bookManager.GetBookById(input.Id));
    }
}
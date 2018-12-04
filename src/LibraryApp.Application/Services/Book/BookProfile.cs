using AutoMapper;
using LibraryApp.Models.Book;
using LibraryApp.Services.Books.DTO;

namespace LibraryApp.Services.Books
{
    public class BookProfile : Profile
    {
        public BookProfile()
        {
            CreateMap<CreateBookInput, Book>().ReverseMap();
            CreateMap<Book, GetBookOutput>().ReverseMap();
            CreateMap<UpdateBookInput, Book>().ReverseMap();
            CreateMap<Book, Book>().ReverseMap();
        }
    }
}
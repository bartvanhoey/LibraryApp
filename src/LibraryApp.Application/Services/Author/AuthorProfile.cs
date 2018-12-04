using AutoMapper;
using LibraryApp.Models.Author;
using LibraryApp.Services.Authors.DTO;

namespace LibraryApp.Services.AuthorService
{
    public class AuthorProfile : Profile
    {
        public AuthorProfile()
        {
            CreateMap<CreateAuthorInput, Author>().ReverseMap();
            CreateMap<Author, GetAuthorOutput>().ReverseMap();
            CreateMap<UpdateAuthorInput, Author>().ReverseMap();
            CreateMap<Author, Author>().ReverseMap();
        }
    }
}
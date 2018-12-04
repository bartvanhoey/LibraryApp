using AutoMapper;
using LibraryApp.Models.Category;
using LibraryApp.Services.Categories.DTO;

namespace LibraryApp.Services.Categories
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<CreateCategoryInput, Category>().ReverseMap();
            CreateMap<Category, GetCategoryOutput>().ReverseMap();
            CreateMap<UpdateCategoryInput, Category>().ReverseMap();
            CreateMap<Category, Category>().ReverseMap();
        }
    }
}
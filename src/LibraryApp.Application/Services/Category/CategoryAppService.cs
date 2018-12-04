using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services;
using AutoMapper;
using LibraryApp.Models;
using LibraryApp.Models.Category;
using LibraryApp.Services.Categories.DTO;

namespace LibraryApp.Services.Categories
{
    public class CategoryAppService : ApplicationService, ICategoryAppService
    {
        private readonly ICategoryManager _categoryManager;

        public CategoryAppService(ICategoryManager categoryManager) 
            => _categoryManager = categoryManager;

        public IEnumerable<GetCategoryOutput> ListALl() 
            => Mapper.Map<List<Category>, List<GetCategoryOutput>>(_categoryManager.GetAllList().ToList());

        public async Task Create(CreateCategoryInput input) 
            => await _categoryManager.Create(Mapper.Map<CreateCategoryInput, Category>(input));

        public void Update(UpdateCategoryInput input) 
            => _categoryManager.Update(Mapper.Map<UpdateCategoryInput, Category>(input));

        public void Delete(DeleteCategoryInput input) 
            => _categoryManager.Delete(input.Id);

        public GetCategoryOutput GetCategoryById(GetCategoryInput input) 
            => Mapper.Map<Category, GetCategoryOutput>(_categoryManager.GetCategoryById(input.Id));
    }
}
using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using LibraryApp.Services.Categories.DTO;

namespace LibraryApp.Services.Categories
{
    public interface ICategoryAppService: IApplicationService
    {
        IEnumerable<GetCategoryOutput> ListALl();
        Task Create(CreateCategoryInput input);
        void Update(UpdateCategoryInput input);
        void Delete(DeleteCategoryInput input);
        GetCategoryOutput GetCategoryById(GetCategoryInput input);
    }
}
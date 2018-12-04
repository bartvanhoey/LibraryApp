using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using LibraryApp.Services.Books.DTO;

namespace LibraryApp.Services.Books
{
    public interface IBookAppService : IApplicationService
    {
        IEnumerable<GetBookOutput> ListALl();
        Task Create(CreateBookInput input);
        void Update(UpdateBookInput input);
        void Delete(DeleteBookInput input);
        GetBookOutput GetBookById(GetBookInput input);
    }
}
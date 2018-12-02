using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using LibraryApp.Services.Authors.DTO;

namespace LibraryApp.Services.AuthorService
{
    public interface IAuthorAppService : IApplicationService
    {
        IEnumerable<GetAuthorOutput> ListALl();
        Task Create(CreateAuthorInput input);
        void Update(UpdateAuthorInput input);
        void Delete(DeleteAuthorInput input);
        GetAuthorOutput GetAuthorById(GetAuthorInput input);
    }
}
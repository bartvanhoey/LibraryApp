using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services;
using AutoMapper;
using LibraryApp.Models;
using LibraryApp.Services.Authors.DTO;

namespace LibraryApp.Services.AuthorService
{
    public class AuthorAppService : ApplicationService, IAuthorAppService
    {
        private readonly IAuthorManager _authorManager;

        public AuthorAppService(IAuthorManager  authorManager) 
            => _authorManager = authorManager;
        
        public IEnumerable<GetAuthorOutput> ListALl() 
            => Mapper.Map<List<Author>, List<GetAuthorOutput>>(_authorManager.GetAllList().ToList());

        public async Task Create(CreateAuthorInput input) 
            => await _authorManager.Create(Mapper.Map<CreateAuthorInput, Author>(input));

        public void Update(UpdateAuthorInput input) 
            => _authorManager.Update(Mapper.Map<UpdateAuthorInput, Author>(input));

        public void Delete(DeleteAuthorInput input) 
            => _authorManager.Delete(input.Id);

        public GetAuthorOutput GetAuthorById(GetAuthorInput input) 
            => Mapper.Map<Author, GetAuthorOutput>(_authorManager.GetAuthorById(input.Id));
    }
}
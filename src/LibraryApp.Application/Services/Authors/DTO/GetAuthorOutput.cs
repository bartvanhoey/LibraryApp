using System;

namespace LibraryApp.Services.Authors.DTO
{
    public class GetAuthorOutput
    {
        public int Id { get; set; }
        public string DisplayName { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime? DeathDate { get; set; }
    }
}
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;

namespace LibraryApp.Models.Category
{
    public class Category : FullAuditedEntity
    {
        public Category()
        {
            Books = new HashSet<Book.Book>();
        }

        [Required]
        [Display(Name = "Display Name")]
        [StringLength(64, ErrorMessage = "Maximum Length is 64")]
        public string DisplayName { get; set; }

        public virtual ICollection<Book.Book> Books { get; set; }
    }
}
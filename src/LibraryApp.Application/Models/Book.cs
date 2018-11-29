using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities.Auditing;

namespace LibraryApp.Models
{
    public class Book : FullAuditedEntity
    {
        [Required]
        [Display(Name = "Display Name")]
        [StringLength(64, ErrorMessage = "Maximum Length is 64")]
        public string DisplayName { get; set; }

        public int? TotalPageNumber { get; set; }

        [ForeignKey(nameof(Author))]
        public int AuthorId { get; set; }

        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }

        public virtual Author Author { get; set; }

        public virtual Category Category { get; set; }
    }
}
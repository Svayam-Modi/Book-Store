using System.ComponentModel.DataAnnotations;

namespace FinalExam.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; } 

        public string Title { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "PublishDate")]
        public DateTime PublishDate { get; set; }

        public string Category { get; set; }
        public string ISBN { get; set; }
        public ICollection<BookStore> BookStores { get; set; }
    }
}

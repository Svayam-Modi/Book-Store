using System.ComponentModel.DataAnnotations;

namespace FinalExam.Models
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "BirthDate")]
        public DateTime BirthDate { get; set; }

        public ICollection<BookStore> BookStores { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace FinalExam.Models
{
    public class BookStore
    {
        [Key]
        public int BookStoreId { get; set; }

        public int BookId { get; set; }
        public Book Book { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}

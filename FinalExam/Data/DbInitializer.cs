using FinalExam.Models;

namespace FinalExam.Data
{
    public class DbInitializer
    {
        public static void Initialize(BookStoreContext context)
        {
               if (context.Book.Any() || context.Author.Any())
            {
                return;   // DB has been seeded
            }

            var outlive = new Book
            {
                Title = "Outlive",
                PublishDate= DateTime.Parse("2018-09-01"),
                Category = "Philosophy",
                ISBN = "ASEDF2113"
                
            };
            var spare = new Book
            {

                Title = "Spare",
                PublishDate = DateTime.Parse("2020-09-01"),
                Category = "Philosophy",
                ISBN = "KJDER1234"
            };
            var atomic = new Book
            {

                Title = "Atomic Habits",
                PublishDate = DateTime.Parse("2018-09-01"),
                Category = "Philosophy",
                ISBN = "ASDCV1565"
            };

            var life = new Book
            {

                Title = "Life Worth Living",
                PublishDate = DateTime.Parse("2016-12-01"),
                Category = "Philosophy",
                ISBN = "SVFHA3426"
            };

            var rich = new Book
            {

                Title = "Rich Dad Poor Dad",
                PublishDate = DateTime.Parse("2019-10-05"),
                Category = "Finnance",
                ISBN = "ZXBDK9087"
            };

            var agreement = new Book
            {

                Title = "The Four Agreements",
                PublishDate = DateTime.Parse("2015-11-05"),
                Category = "History",
                ISBN = "SZXFQ1870"
            };
            var think = new Book
            {

                Title = "Think and Grow Rich",
                PublishDate = DateTime.Parse("2019-06-03"),
                Category = "Finance",
                ISBN = "ASXDL1238"
            };
            var hurt = new Book
            {

                Title = "Can't Hurt Me",
                PublishDate = DateTime.Parse("2018-02-08"),
                Category = "Biography",
                ISBN = "SZXGH1090"
            };
            var creative = new Book
            {

                Title = "The Creative Act",
                PublishDate = DateTime.Parse("2020-04-10"),
                Category = "Self-Help",
                ISBN = "ZXBVW1276"
            };
            var green = new Book
            {

                Title = "Greenlights",
                PublishDate = DateTime.Parse("2019-10-05"),
                Category = "Philospphy",
                ISBN = "SZASQ1700"
            };

            var books = new Book[]
            {
                rich, agreement, think, hurt, creative,outlive,life,spare,
                green,atomic
            };
           
            context.AddRange(books);
           // context.SaveChanges();

            var peter = new Author
            {
                FirstName = "Peter",
                LastName = "Attia",
                Age = 30,
                BirthDate = DateTime.Parse("1970-10-01")

            };
            var james = new Author
            {
                FirstName = "James",
                LastName = "Clear",
                Age = 35,
                BirthDate = DateTime.Parse("1965-03-04")

            };
            var harry = new Author
            {
                FirstName = "Prince",
                LastName = "Harry",
                Age = 25,
                BirthDate = DateTime.Parse("1975-05-01")

            };
            var mark = new Author
            {
                FirstName = "Mark",
                LastName = "Manson",
                Age = 30,
                BirthDate = DateTime.Parse("1970-06-11")
            };
            var david = new Author
            {
                FirstName = "David",
                LastName = "Gggins",
                Age = 40,
                BirthDate = DateTime.Parse("1960-05-09")
            };
            var kiyo = new Author
            {
                FirstName = "Robert",
                LastName = "Kiyosaki",
                Age = 70,
                BirthDate = DateTime.Parse("1950-08-05")
            };
            var rick = new Author
            {
                FirstName = "Rick",
                LastName = "Rubin",
                Age = 50,
                BirthDate = DateTime.Parse("1980-07-03")
            };
            var shanno = new Author
            {
                FirstName = "Shannon ",
                LastName = "Bream",
                Age = 40,
                BirthDate = DateTime.Parse("1990-07-11")
            };
            var authors = new Author[]
            {
                peter, james, harry, mark, david,kiyo,rick,shanno
            };

            context.AddRange(authors);


            var bookstores = new BookStore[]
            {
                new BookStore
                {
                    Book = outlive,
                    Author = peter
                },
                new BookStore
                {
                    Book = outlive,
                    Author = james
                },
                new BookStore
                {
                    Book = spare,
                    Author = james
                },
                new BookStore
                {
                    Book = spare,
                    Author = harry
                },
                 new BookStore
                {
                    Book = atomic,
                    Author = harry
                },
                 new BookStore
                {
                    Book = atomic,
                    Author = mark
                },
                 new BookStore
                {
                    Book = life,
                    Author = mark
                },
                 new BookStore
                {
                    Book = life,
                    Author = david
                },
                 new BookStore
                {
                    Book = rich,
                    Author = david
                },
                 new BookStore
                {
                    Book = rich,
                    Author = kiyo
                },
                new BookStore
                {
                    Book = agreement,
                    Author = kiyo
                },
                new BookStore
                {
                    Book = agreement,
                    Author = rick
                },
                new BookStore
                {
                    Book = think,
                    Author = rick
                },
                new BookStore
                {
                    Book = think,
                    Author = peter
                },
                new BookStore
                {
                    Book = hurt,
                    Author = james
                },
                new BookStore
                {
                    Book = hurt,
                    Author = shanno
                },
                new BookStore
                {
                    Book = creative,
                    Author = shanno
                },
                new BookStore
                {
                    Book = creative,
                    Author = harry
                },
                new BookStore

                {
                    Book = green,
                    Author = mark
                },
                new BookStore
                {
                    Book = green,
                    Author = rick
                },
                
            };

            context.AddRange(bookstores);

            context.SaveChanges();

        }

    }
}

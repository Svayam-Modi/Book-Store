using FinalExam.Data;
using FinalExam.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace FinalExam.Pages
{
    public class AssignModel : PageModel
    {
        public readonly BookStoreContext _context;

        public AssignModel(BookStoreContext context)
        {
            _context = context;
        }
        public IList<Author> Authors { get; set; } 
        public IList<Book> Books { get;set; }

        [BindProperty]

        public Book BookId { get; set; }

        [BindProperty]

        public Author AuthorId { get; set; }

        public async Task OnGetAsync()
        {
            if(_context.Author !=null)
            {
                Authors = await _context.Author.Include(a => a.BookStores).ThenInclude(s => s.Book).ToListAsync();
            }
            if(_context.Book != null)
            {
                Books =  await _context.Book.Include(a => a.BookStores).ThenInclude(c => c.Author).ToListAsync();
            }
        }
        public async Task<IActionResult> OnPostAsync(int AuthorId, int BookId)
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            _context.Add(new BookStore { BookId= BookId, AuthorId = AuthorId });
            await _context.SaveChangesAsync();
            return RedirectToPage("/Index");
        }
    }
}

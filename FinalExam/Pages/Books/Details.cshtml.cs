using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FinalExam.Data;
using FinalExam.Models;

namespace FinalExam.Pages.Books
{
    public class DetailsModel : PageModel
    {
        private readonly FinalExam.Data.BookStoreContext _context;

        public DetailsModel(FinalExam.Data.BookStoreContext context)
        {
            _context = context;
        }

      public Book Book { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Book == null)
            {
                return NotFound();
            }
            //Here we are getting the data of authors 
            var book = await _context.Book.
                Include(s => s.BookStores).
                ThenInclude(b => b.Author).
                FirstOrDefaultAsync(m => m.BookId == id);
            if (book == null)
            {
                return NotFound();
            }
            else 
            {
                Book = book;
            }
            return Page();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FinalExam.Data;
using FinalExam.Models;

namespace FinalExam.Pages.Authors
{
    public class DetailsModel : PageModel
    {
        private readonly FinalExam.Data.BookStoreContext _context;

        public DetailsModel(FinalExam.Data.BookStoreContext context)
        {
            _context = context;
        }

      public Author Author { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Author == null)
            {
                return NotFound();
            }
            //Here we are getting the data of BOOKS
            var author = await _context.Author.Include(s => s.BookStores).ThenInclude(b => b.Book).FirstOrDefaultAsync(m => m.AuthorId == id);
            if (author == null)
            {
                return NotFound();
            }
            else 
            {
                Author = author;
            }
            return Page();
        }
    }
}

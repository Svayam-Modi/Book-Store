﻿using System;
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
    public class IndexModel : PageModel
    {
        private readonly FinalExam.Data.BookStoreContext _context;

        public IndexModel(FinalExam.Data.BookStoreContext context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;
        public IList<BookStore> BookStore { get; set; } = default!;
        public async Task OnGetAsync(int? id)
        {
            if (_context.Book != null)
            {
                Book = await _context.Book.ToListAsync();
            }
            //By using below function we are getting the list of BooksStores which has author and Book object
            if(id != null)
            {
                BookStore =
                  await _context.BookStores.Include(a => a.Author).Include(a => a.Book).
                  Where(a => a.BookId == id).ToListAsync();
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Mezei_Dragos_Colocviu.Data;
using Mezei_Dragos_Colocviu.Models;

namespace Mezei_Dragos_Colocviu.Pages.Articles
{
    public class DeleteModel : PageModel
    {
        private readonly Mezei_Dragos_Colocviu.Data.Mezei_Dragos_ColocviuContext _context;

        public DeleteModel(Mezei_Dragos_Colocviu.Data.Mezei_Dragos_ColocviuContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Article Article { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Article = await _context.Article.FirstOrDefaultAsync(m => m.ID == id);

            if (Article == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Article = await _context.Article.FindAsync(id);

            if (Article != null)
            {
                _context.Article.Remove(Article);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

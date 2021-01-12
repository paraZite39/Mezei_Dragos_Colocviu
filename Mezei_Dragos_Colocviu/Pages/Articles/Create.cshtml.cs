using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Mezei_Dragos_Colocviu.Data;
using Mezei_Dragos_Colocviu.Models;

namespace Mezei_Dragos_Colocviu.Pages.Articles
{
    public class CreateModel : PageModel
    {
        private readonly Mezei_Dragos_Colocviu.Data.Mezei_Dragos_ColocviuContext _context;

        public CreateModel(Mezei_Dragos_Colocviu.Data.Mezei_Dragos_ColocviuContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Article Article { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Article.Add(Article);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

using System;
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
    public class IndexModel : PageModel
    {
        private readonly Mezei_Dragos_Colocviu.Data.Mezei_Dragos_ColocviuContext _context;

        public IndexModel(Mezei_Dragos_Colocviu.Data.Mezei_Dragos_ColocviuContext context)
        {
            _context = context;
        }

        public IList<Article> Article { get;set; }

        public async Task OnGetAsync()
        {
            Article = await _context.Article.ToListAsync();
        }
    }
}

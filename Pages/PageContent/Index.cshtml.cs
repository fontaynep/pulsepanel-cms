using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CustomCMS.Data;
using CustomCMS.Models;

namespace CustomCMS.Pages_PageContent
{
    public class IndexModel : PageModel
    {
        private readonly CustomCMS.Data.CMSContext _context;

        public IndexModel(CustomCMS.Data.CMSContext context)
        {
            _context = context;
        }

        public IList<PageContent> PageContent { get;set; } = default!;

        public async Task OnGetAsync()
        {
            PageContent = await _context.PageContents.ToListAsync();
        }
    }
}

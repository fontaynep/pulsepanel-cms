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
    public class DeleteModel : PageModel
    {
        private readonly CustomCMS.Data.CMSContext _context;

        public DeleteModel(CustomCMS.Data.CMSContext context)
        {
            _context = context;
        }

        [BindProperty]
        public PageContent PageContent { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pagecontent = await _context.PageContents.FirstOrDefaultAsync(m => m.Id == id);

            if (pagecontent is not null)
            {
                PageContent = pagecontent;

                return Page();
            }

            return NotFound();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pagecontent = await _context.PageContents.FindAsync(id);
            if (pagecontent != null)
            {
                PageContent = pagecontent;
                _context.PageContents.Remove(PageContent);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

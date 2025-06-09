using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CustomCMS.Data;
using CustomCMS.Models;

namespace CustomCMS.Pages_PageContent
{
    public class CreateModel : PageModel
    {
        private readonly CustomCMS.Data.CMSContext _context;

        public CreateModel(CustomCMS.Data.CMSContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public PageContent PageContent { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.PageContents.Add(PageContent);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

using Microsoft.AspNetCore.Mvc.RazorPages;
using CustomCMS.Data;
using CustomCMS.Models;
using System.Linq;

namespace CustomCMS.Pages
    {
    public class AboutModel : PageModel
        {
        private readonly CMSContext _context;

        public AboutModel(CMSContext context)
            {
            _context = context;
            }

        public CustomCMS.Models.PageContent? AboutContent
            {
            get; set;
            }

        public void OnGet()
            {
            AboutContent = _context.PageContents
                .Where(p => p.PageName == "About")
                .OrderByDescending(p => p.LastUpdated)
                .FirstOrDefault();
            }
        }
    }

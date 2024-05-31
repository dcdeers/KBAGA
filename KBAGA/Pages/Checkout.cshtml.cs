using KBAGA.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace KBAGA.Pages
{
    public class CheckoutModel : PageModel
    {
        private readonly KBAGA.Areas.Identity.Data.ApplicationDbContext _context;

        public CheckoutModel(KBAGA.Areas.Identity.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Menu> Menu { get; set; } = default!;

        public async Task OnGetAsync()
        {
            Menu = await _context.Menu.ToListAsync();
        }
    }
}

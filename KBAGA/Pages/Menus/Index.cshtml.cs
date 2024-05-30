using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using KBAGA.Areas.Identity.Data;
using KBAGA.Models;

namespace KBAGA.Pages.Menus
{
    public class IndexModel : PageModel
    {
        private readonly KBAGA.Areas.Identity.Data.ApplicationDbContext _context;

        public IndexModel(KBAGA.Areas.Identity.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Menu> Menu { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Menu = await _context.Menu.ToListAsync();
        }
    }
}

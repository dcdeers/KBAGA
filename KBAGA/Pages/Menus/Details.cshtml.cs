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
    public class DetailsModel : PageModel
    {
        private readonly KBAGA.Areas.Identity.Data.ApplicationDbContext _context;

        public DetailsModel(KBAGA.Areas.Identity.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Menu Menu { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var menu = await _context.Menu.FirstOrDefaultAsync(m => m.Id == id);
            if (menu == null)
            {
                return NotFound();
            }
            else
            {
                Menu = menu;
            }
            return Page();
        }
    }
}

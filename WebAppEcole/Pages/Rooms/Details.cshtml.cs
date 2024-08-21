using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebAppEcole.Data;
using WebAppEcole.Models;

namespace WebAppEcole.Pages.Rooms
{
    public class DetailsModel : PageModel
    {
        private readonly WebAppEcole.Data.WebAppEcoleContext _context;

        public DetailsModel(WebAppEcole.Data.WebAppEcoleContext context)
        {
            _context = context;
        }

        public Room Room { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var room = await _context.Room.FirstOrDefaultAsync(m => m.Id == id);
            if (room == null)
            {
                return NotFound();
            }
            else
            {
                Room = room;
            }
            return Page();
        }
    }
}

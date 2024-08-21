﻿using System;
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
    public class IndexModel : PageModel
    {
        private readonly WebAppEcole.Data.WebAppEcoleContext _context;

        public IndexModel(WebAppEcole.Data.WebAppEcoleContext context)
        {
            _context = context;
        }

        public IList<Room> Room { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Room = await _context.Room.ToListAsync();
        }
    }
}

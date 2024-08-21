using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppEcole.Models;

namespace WebAppEcole.Data
{
    public class WebAppEcoleContext : DbContext
    {
        public WebAppEcoleContext (DbContextOptions<WebAppEcoleContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppEcole.Models.Room> Room { get; set; } = default!;
    }
}

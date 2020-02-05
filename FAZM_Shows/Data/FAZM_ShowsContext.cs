using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FAZM_Shows.Models.Show;

namespace FAZM_Shows.Models
{
    public class FAZM_ShowsContext : DbContext
    {
        public FAZM_ShowsContext (DbContextOptions<FAZM_ShowsContext> options)
            : base(options)
        {
        }

        public DbSet<FAZM_Shows.Models.Show.Show> Show { get; set; }
    }
}

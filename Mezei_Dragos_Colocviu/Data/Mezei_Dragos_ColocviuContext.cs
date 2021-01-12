using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Mezei_Dragos_Colocviu.Models;

namespace Mezei_Dragos_Colocviu.Data
{
    public class Mezei_Dragos_ColocviuContext : DbContext
    {
        public Mezei_Dragos_ColocviuContext (DbContextOptions<Mezei_Dragos_ColocviuContext> options)
            : base(options)
        {
        }

        public DbSet<Mezei_Dragos_Colocviu.Models.Article> Article { get; set; }
    }
}

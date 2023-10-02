using JeanLuis_AP1_P1.Models;
using Microsoft.EntityFrameworkCore;

namespace JeanLuis_AP1_P1.DAL
{
    public class Context: DbContext
    {
        public Context(DbContextOptions<Context>opcion): base(opcion) { }
        public DbSet<Aportes> Aportes { get; set; }
    }

    
}

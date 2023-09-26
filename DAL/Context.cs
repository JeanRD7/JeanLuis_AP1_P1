
using Microsoft.EntityFrameworkCore;

namespace JeanLuis_AP1_P1.DAL
{
    public class Context: DbContext
    {
        public Context(DbContextOptions<Context>opcion): base(opcion) { }
    }
}

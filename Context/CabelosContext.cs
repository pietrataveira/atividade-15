using Cabelos_do_Taeyong.Models;
using Microsoft.EntityFrameworkCore;

namespace Cabelos_do_Taeyong.Context
{
    public class CabelosContext : DbContext
    {
        public CabelosContext(DbContextOptions<CabelosContext> options) : base(options){}
        
        public DbSet<Cabelos> Cabelos{ get; set;}
    }
}
using Microsoft.EntityFrameworkCore;

namespace PetCrud.Models
{
    public class PetContext:DbContext
    {
        public PetContext(DbContextOptions<PetContext> options) : base(options) { }
        public DbSet<Animal> Animals { get; set; }
    }
}

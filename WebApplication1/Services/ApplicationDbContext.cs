using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Services
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }
    }
}

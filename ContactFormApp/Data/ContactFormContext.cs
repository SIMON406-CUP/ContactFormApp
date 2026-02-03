using Microsoft.EntityFrameworkCore;
using ContactFormApp.Models;

namespace ContactFormApp.Data
{
    public class ContactFormContext : DbContext
    {
        public ContactFormContext(DbContextOptions<ContactFormContext> options)
            : base(options)
        {
        }

        public DbSet<ContactMessage> ContactMessages { get; set; }
    }
}

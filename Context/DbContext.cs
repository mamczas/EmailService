using EmailService.Context.Models;
using Microsoft.EntityFrameworkCore;

namespace EmailService.Context
{
    public class EmailServiceDbContext : DbContext 
    {
        public EmailServiceDbContext(DbContextOptions<EmailServiceDbContext> options)
            : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        //entities
        public DbSet<EmailModel> Emails { get; set; }
    }
}

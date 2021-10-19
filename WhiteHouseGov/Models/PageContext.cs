using Microsoft.EntityFrameworkCore;
using ScholarlySummaries.Models.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScholarlySummaries.Models
{
    public class PageContext : DbContext
    {
        public PageContext(DbContextOptions<PageContext> options) : base(options) { }

        public DbSet<Page> Pages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StartPage>();
        }
    }
}

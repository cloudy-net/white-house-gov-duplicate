using Microsoft.EntityFrameworkCore;
using WhiteHouseGov.Models.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WhiteHouseGov.Models.Settings;
using Cloudy.CMS.ContentSupport.Serialization;

namespace WhiteHouseGov.Models
{
    public class ContentContext : DbContext
    {
        public ContentContext(DbContextOptions<ContentContext> options) : base(options) { }

        public DbSet<Page> Pages { get; set; }
        public DbSet<SettingsContainer> Settings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StartPage>();
            modelBuilder.Entity<HeaderSettings>().Property(s => s.PageLinks).HasConversion(new JsonValueConverter<IEnumerable<string>>());
            modelBuilder.Entity<FooterSettings>().Property(s => s.MainLinks).HasConversion(new JsonValueConverter<IEnumerable<string>>());
            modelBuilder.Entity<FooterSettings>().Property(s => s.SecondaryLinks).HasConversion(new JsonValueConverter<IEnumerable<string>>());
        }
    }
}

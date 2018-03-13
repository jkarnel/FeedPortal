using FeedPortal.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FeedPortal.Core.Data
{
    public class FeedDbContext : DbContext
    {
        public FeedDbContext(DbContextOptions<FeedDbContext> options) : base(options) { }

        public DbSet<FeedSource> FeedSources { get; set; }
        public DbSet<FeedCollection> FeedCollections { get; set; }
    }
}

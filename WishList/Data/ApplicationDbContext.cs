using System;
using Microsoft.EntityFrameworkCore;
using WishList.Models;

namespace WishList.Data
{
    public class ApplicationDbContext : DbContext
    {
        DbContextOptions _options;
        public DbSet<Item> Items { get; set; }

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            _options = options;
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore;

namespace linx_backend.Models
{
    public class ItemContext : DbContext
    {
        public ItemContext(DbContextOptions<ItemContext> options) : base(options)
        {
        }
        public DbSet<Item> Items { get; set; }
    }
}

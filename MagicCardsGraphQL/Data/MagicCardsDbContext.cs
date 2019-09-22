using MagicCardsGraphQL.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace MagicCardsGraphQL.Data
{
    public class MagicCardsDbContext : DbContext
    {
        public MagicCardsDbContext(DbContextOptions<MagicCardsDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Card> Cards { get; set; }
    }
}

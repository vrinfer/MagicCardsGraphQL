using MagicCardsGraphQL.Data;
using MagicCardsGraphQL.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MagicCardsGraphQL.Repositories
{
    public class CardsRepository
    {
        private readonly MagicCardsDbContext _dbContext;

        public CardsRepository(MagicCardsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<List<Card>> GetAll()
        {
            return _dbContext.Cards.ToListAsync();
        }
    }
}

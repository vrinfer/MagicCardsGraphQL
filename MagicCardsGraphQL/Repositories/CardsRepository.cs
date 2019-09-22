using MagicCardsGraphQL.Data;
using MagicCardsGraphQL.Data.Entities;
using System.Collections.Generic;
using System.Linq;

namespace MagicCardsGraphQL.Repositories
{
    public class CardsRepository
    {
        private readonly MagicCardsDbContext _dbContext;

        public CardsRepository(MagicCardsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Card> GetAll()
        {
            return _dbContext.Cards.ToList();
        }
    }
}

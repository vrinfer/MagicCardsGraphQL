using MagicCardsGraphQL.Data.Entities;
using MagicCardsGraphQL.Data.Enums;
using System.Linq;

namespace MagicCardsGraphQL.Data
{
    public static class InitialData
    {
        public static void Seed(this MagicCardsDbContext dbContext)
        {
            if (!dbContext.Cards.Any())
            {
                dbContext.Cards.Add(new Card
                {
                    Name = "Risen Reef",
                    Category = Categories.Creature,
                    ColectorNumber = "217/280 U",
                    SetName = "Core Set 2020",
                    Text = "Whenever Risen Reef or another Elemental enters the battlefield under your control, look at the top card of your library. If it's a land card, you may put it onto the battlefield tapped. If you don't put the card onto the battlefield, put it into your hand.",
                    Type = CardTypes.Creature
                });

                dbContext.SaveChanges();
            }
        }
    }
}

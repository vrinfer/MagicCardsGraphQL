using GraphQL.Types;
using MagicCardsGraphQL.Data.Entities;

namespace MagicCardsGraphQL.GraphQL.Types
{
    public class CardType : ObjectGraphType<Card> // <- Specify from which class I want to provide metadata
    {
        public CardType()
        {
            Field(t => t.Id);
            Field(t => t.Name);
            Field(t => t.Text).Description("The text describing the card behavior.");
        }
    }
}

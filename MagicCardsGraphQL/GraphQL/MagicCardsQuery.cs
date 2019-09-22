using GraphQL.Types;
using MagicCardsGraphQL.GraphQL.Types;
using MagicCardsGraphQL.Repositories;

namespace MagicCardsGraphQL.GraphQL
{
    // This is the class that knows how to get the cards
    public class MagicCardsQuery : ObjectGraphType
    {
        public MagicCardsQuery(CardsRepository cardRepository)
        {
            Field<ListGraphType<CardType>>(
                "cards",
                resolve: context => cardRepository.GetAll()
                );
        }
    }
}

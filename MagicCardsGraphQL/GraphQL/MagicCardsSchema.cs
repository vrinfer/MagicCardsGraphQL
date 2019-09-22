using GraphQL;
using GraphQL.Types;

namespace MagicCardsGraphQL.GraphQL
{
    public class MagicCardsSchema : Schema
    {
        public MagicCardsSchema(IDependencyResolver resolver) : base(resolver)
        {
            //Query -> data retrieval
            Query = resolver.Resolve<MagicCardsQuery>();
        }
    }
}

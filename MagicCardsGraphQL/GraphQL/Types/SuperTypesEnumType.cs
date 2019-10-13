using GraphQL.Types;
using MagicCardsGraphQL.Data.Enums;

namespace MagicCardsGraphQL.GraphQL.Types
{
    public class SuperTypesEnumType : EnumerationGraphType<SuperTypes>
    {
        public SuperTypesEnumType()
        {
            Name = "SuperType";
            Description = "The card Subtype";
        }
    }
}

using GraphQL.Types;
using MagicCardsGraphQL.Data.Enums;

namespace MagicCardsGraphQL.GraphQL.Types
{
    public class SubTypesType : EnumerationGraphType<SubTypes>
    {
        public SubTypesType()
        {
            Name = "SubType";
            Description = "The card SubType";
        }
    }
}

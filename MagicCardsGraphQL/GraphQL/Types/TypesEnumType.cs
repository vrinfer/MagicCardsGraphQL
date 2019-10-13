using GraphQL.Types;

namespace MagicCardsGraphQL.GraphQL.Types
{
    //Custom graphql type
    public class TypesEnumType : EnumerationGraphType<Data.Enums.Types>
    {
        public TypesEnumType()
        {
            Name = "Type";
            Description = "The card type";
        }
    }
}

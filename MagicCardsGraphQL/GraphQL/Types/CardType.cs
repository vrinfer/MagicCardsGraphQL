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
            Field(t => t.SuperType, type: typeof(SuperTypesEnumType));
            Field(t => t.Type, type: typeof(TypesEnumType));
            Field(t => t.SubType, type: typeof(SubTypesType));
            Field(t => t.SetName);
            Field(t => t.Colors).Description("Displays the card color in the format is color-color");
            Field(t => t.ManaCost).Description("Displays the mana cost in the format: {amount of colorless mana}-{mana color}");
        }
    }
}

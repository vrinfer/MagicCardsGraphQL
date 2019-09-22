using MagicCardsGraphQL.Data.Enums;

namespace MagicCardsGraphQL.Data.Entities
{
    public class Card
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public string ColectorNumber { get; set; }
        public Categories Category { get; set; }
        public CardTypes Type { get; set; }
        public string SetName { get; set; }
    }
}

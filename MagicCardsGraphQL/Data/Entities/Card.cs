using MagicCardsGraphQL.Data.Enums;

namespace MagicCardsGraphQL.Data.Entities
{
    public class Card
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public string Colors { get; set; }
        public string ManaCost { get; set; }
        public string SetName { get; set; }
        public SuperTypes SuperType { get; set; }
        public Types Type { get; set; }
        public SubTypes SubType { get; set; }
    }
}

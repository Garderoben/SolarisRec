using DomainDrivenDesign.DomainObjects;

namespace SolarisRec.Core.Deck
{
    public class Deck : Entity<Deck>
    {
        public Deck(Id<Deck> id) : base(id)
        {

        }
    }
}
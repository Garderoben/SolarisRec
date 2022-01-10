using SolarisRec.Core.CardType.Processes.PrimaryPorts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SolarisRec.Core.CardType.Processes
{
    internal class ProvideCardTypeService : IProvideCardTypeService
    {
        public async Task<List<Card.CardType>> List()
        {
            var cardTypes = new List<Card.CardType>
            {
                new Card.CardType
                {
                    Id = 1,
                    Name = "Agent"
                },
                new Card.CardType
                {
                    Id = 2,
                    Name = "Construction"
                },
                new Card.CardType
                {
                    Id = 3,
                    Name = "Maneuver"
                },
                new Card.CardType
                {
                    Id = 4,
                    Name = "Mission"
                },
            };

            return await Task.FromResult(cardTypes);
        }
    }
}
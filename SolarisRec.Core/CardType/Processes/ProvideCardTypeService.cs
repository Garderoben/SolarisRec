using SolarisRec.Core.CardType.Processes.PrimaryPorts;
using System.Collections.Generic;
using System.Threading.Tasks;
using Enums = SolarisRec.Core.Card.Enums;

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
                    Id = (int)Enums.CardType.Agent,
                    Name = "Agent"
                },
                new Card.CardType
                {
                    Id = (int)Enums.CardType.Construction,
                    Name = "Construction"
                },
                new Card.CardType
                {
                    Id = (int)Enums.CardType.Maneuver,
                    Name = "Maneuver"
                },
                new Card.CardType
                {
                    Id = (int)Enums.CardType.Mission,
                    Name = "Mission"
                },
            };

            return await Task.FromResult(cardTypes);
        }
    }
}
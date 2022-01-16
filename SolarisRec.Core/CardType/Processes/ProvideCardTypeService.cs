using SolarisRec.Core.CardType.Processes.PrimaryPorts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SolarisRec.Core.CardType.Processes
{
    internal class ProvideCardTypeService : IProvideCardTypeService
    {
        public async Task<List<CardType>> List()
        {
            var cardTypes = new List<CardType>
            {
                new CardType
                {
                    Id = (int)CardTypeEnum.Agent,
                    Name = "Agent"
                },
                new CardType
                {
                    Id = (int)CardTypeEnum.Construction,
                    Name = "Construction"
                },
                new CardType
                {
                    Id = (int)CardTypeEnum.Maneuver,
                    Name = "Maneuver"
                },
                new CardType
                {
                    Id = (int)CardTypeEnum.Mission,
                    Name = "Mission"
                },
            };

            return await Task.FromResult(cardTypes);
        }
    }
}
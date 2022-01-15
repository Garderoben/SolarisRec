using SolarisRec.Core.Card.Processes.SecondaryPorts;
using SolarisRec.Core.Faction.Processes.PrimaryPorts;
using SolarisRec.Core.Faction.Processes.SecondaryPorts;
using System;
using System.Threading.Tasks;

namespace SolarisRec.Core.Faction.Processes
{
    internal class ProvideFactionInformationService : IProvideFactionInformationService
    {
        private ICardRepository cardRepository;
        private IFactionRepository factionRepository;

        public ProvideFactionInformationService(
            ICardRepository cardRepository,
            IFactionRepository factionRepository)
        {
            this.cardRepository = cardRepository ?? throw new ArgumentNullException(nameof(cardRepository));
            this.factionRepository = factionRepository ?? throw new ArgumentNullException(nameof(factionRepository));
        }

        public async Task<FactionInformation> ProvideFactionInformation(string factionName)
        {
            var result = new FactionInformation();
            result.Faction.Name = factionName;

            var factionId = await factionRepository.GetFactionId(factionName);
            result.Faction.Id = factionId;
            result.Cards = await cardRepository.GetFactionCards(factionId);
           
            return result;
        }
    }
}
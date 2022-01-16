using SolarisRec.Core.Card;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SolarisRec.UI.Providers
{
    public interface ICardProvider
    {
        Task<List<UIModels.Card>> GetCardsFiltered(CardFilter cardFilter);
    }
}
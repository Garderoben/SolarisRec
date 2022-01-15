using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace SolarisRec.UI.Utility
{
    public interface IFileSaveService
    {
        Task Save(DotNetStreamReference dotNetStreamReference, string fileName = "CreatedBySolarisRec");
    }
}
using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;

namespace SolarisRec.UI.Utility
{
    internal class FileSaveService : IFileSaveService
    {
        private IJSRuntime jsrRuntime;

        public FileSaveService(IJSRuntime jSRuntime)
        {
            this.jsrRuntime = jSRuntime ?? throw new ArgumentNullException(nameof(jsrRuntime));
        }

        public async Task Save(DotNetStreamReference dotNetStreamReference, string fileName)
        {
            await jsrRuntime.InvokeVoidAsync("downloadFileFromStream", fileName, dotNetStreamReference);
        }
    }
}
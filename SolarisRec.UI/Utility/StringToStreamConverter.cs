using System.IO;
using System.Text;

namespace SolarisRec.UI.Utility
{
    internal static class StringToStreamConverter
    {
        public static Stream Convert(string text)
        {
            return new MemoryStream(Encoding.UTF8.GetBytes(text));
        }
    }
}
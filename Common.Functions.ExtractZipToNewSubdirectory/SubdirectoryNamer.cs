using static Common.Functions.GetRandomAlphaNumericString.StringGenerator;
using static System.IO.Path;

namespace Common.Functions.ExtractZipToNewSubdirectory
{
    internal static class SubdirectoryNamer
    {
        private const byte Chars = 9;

        public static string Subdirectory(string filePath)
            => Combine(
                GetDirectoryName(filePath),
                Random(Chars));
    }
}

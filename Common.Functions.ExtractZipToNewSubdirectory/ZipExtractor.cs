using static Common.Functions.ExtractZipToNewSubdirectory.SubdirectoryNamer;
using static System.IO.Compression.ZipFile;

namespace Common.Functions.ExtractZipToNewSubdirectory
{
    public static class ZipExtractor
    {
        public static string Extract(string zipAbsolutePath)
        {
            var extractTo = Subdirectory(zipAbsolutePath);
            ExtractToDirectory(zipAbsolutePath, extractTo);
            return extractTo;
        }
    }
}

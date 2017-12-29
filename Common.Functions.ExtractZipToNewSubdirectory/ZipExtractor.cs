using System;
using static System.IO.Path;
using static System.IO.Compression.ZipFile;

namespace Common.Functions.ExtractZipToNewSubdirectory
{
    public static class ZipExtractor
    {
        public static string Extract(string zipAbsolutePath)
        {
            var extractTo = GetNewSubdirectoryPath(zipAbsolutePath);
            ExtractToDirectory(zipAbsolutePath, extractTo);
            return extractTo;
        }

        private static string GetNewSubdirectoryPath(string filePath)
            => Combine(
                GetDirectoryName(filePath),
                GetLast12CharsFromRandomGuid());

        private static string GetLast12CharsFromRandomGuid()
            => Guid.NewGuid().ToString().Substring(24);
    }
}

using BlobMyData.Domain.Exceptions;
using BlobMyData.Infrastructure.Base;
using System.IO;
using System.Reflection;

namespace BlobMyData.UI.Data
{
    public static class DbProviderFactory
    {
        public static DbProvider CreateDbProvider()
        {
            var appPath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

            var di = Directory.CreateDirectory(Path.Combine(appPath, "DB"));
            string dbPath = Path.Combine(di.FullName, "blobMyData.db");

            if (string.IsNullOrEmpty(dbPath))
                throw new BlobMyDataException($"Illegal state in {nameof(DbProviderFactory)}");

            return new DbProvider(dbPath);
        }
    }

}

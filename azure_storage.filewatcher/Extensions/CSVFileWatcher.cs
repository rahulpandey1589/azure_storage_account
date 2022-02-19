using System;
using System.IO;
using azure_storage.core.BlobStorage;

namespace azure_storage.filewatcher.Extensions
{
    public class CSVFileWatcher : BaseFileWatcher
    {
        public override void WatchFileChangesAsync(string directoryPath)
        {
            base.FileExtensionToWatch = "*.csv*";

            base.WatchFileChangesAsync(directoryPath);
        }

        public override void OnCreated(
            object sender,
            FileSystemEventArgs e)
        {
            string value = $"Created: {e.FullPath}";

            BlobOperations operations
                = new BlobOperations();

            operations.UploadBlobAsync(
                "new-container", "container-blobs", e.FullPath).ConfigureAwait(false);

            Console.WriteLine(value);

        }
    }
}

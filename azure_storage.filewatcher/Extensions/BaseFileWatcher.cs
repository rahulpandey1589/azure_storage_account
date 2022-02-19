using System.IO;

namespace azure_storage.filewatcher.Extensions
{
    public abstract class BaseFileWatcher
    {
        public string FileExtensionToWatch { get; set; }

        public virtual void WatchFileChangesAsync(
            string directoryPath)
        {
            var watcher
                 = new FileSystemWatcher(directoryPath);

            watcher.NotifyFilter = NotifyFilters.Attributes
                                 | NotifyFilters.CreationTime
                                 | NotifyFilters.DirectoryName
                                 | NotifyFilters.FileName
                                 | NotifyFilters.LastAccess
                                 | NotifyFilters.LastWrite
                                 | NotifyFilters.Security
                                 | NotifyFilters.Size;

            watcher.Created += OnCreated;

            watcher.Filter = FileExtensionToWatch;
            watcher.IncludeSubdirectories = true;
            watcher.EnableRaisingEvents = true;

        }

        protected abstract void OnCreated(object sender, FileSystemEventArgs e);
       
    }
}

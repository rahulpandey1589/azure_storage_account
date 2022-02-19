using azure_storage.filewatcher.Extensions;
using System;

namespace azure_storage.filewatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var fileWatcher = new CsvFileWatcher();
            fileWatcher.WatchFileChangesAsync(@"E:\\Watcher");


            Console.WriteLine("Press enter to exit.");
            Console.ReadLine();
        }
    }
}

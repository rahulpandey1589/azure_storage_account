# Azure Storage Account

This application is capable of pushing files into Azure Storage Account. It utilizes Azure SDK library to push files into Azure Blob Storage.

## Keys Points
1) Connection String of azure storage is picking up from Environment Variable.
2) The name of the environment variable is AZURE_STORAGE_CONNECTION_STRING.
3) Environment Variable could be set using setx AZURE_STORAGE_CONNECTION_STRING "<ConnectionString>"
4) Filewatcher application is also there which also read specific file and then new files are pushed to blob storage.

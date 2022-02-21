# Azure Storage Account

This application is capable of pushing files into Azure Storage Account(Blob Storage).

# Prerequisites
* Azure Subscription
* Azure Storage General V2 Account

## Dependencies

| Package                	| Version 	|
|------------------------	|---------	|
| Azure.Storage.Blobs       | 12.10.0   |



# Projects
The solution consists of three project files.
* azure_storage.core
* azure_storage.clientapplication
* azure_storage.filewatcher

The `azure_storage.core` library is the core library which consists of all the core logic of interaction with azure blob storage.

## Key Points

* The `azure_storage.core` is based on `NetStandard2.1` so that is could be integrated with .Net Framework and 
.Net Core based app.
* The application is expecting its connection string to azure storage account from environment variable. Before running the application, please set connection string in environment variable globally using following command
```
  SETX  AZURE_STORAGE_CONNECTION_STRING "<your_connection_string>"
```
* If you want to set environment variable locally, then replace `SETX` with `SET`
```
  SET  AZURE_STORAGE_CONNECTION_STRING "<your_connection_string>"
```
* This project also consists of File Watcher application which looks for specific file changes in particular directory. As soon as new file in created in that directory, it automatically push that file into Azure Blob Storage at defined location.


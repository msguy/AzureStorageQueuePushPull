AzureStorageQueuePushPull
=========================

This sample demonstrates how to use a Storage Queue on Microsoft Azure. 

There are two console applications in this solution

1. AzureStorageQueuePull
   This application gets a reference to Microsoft Azure Storage Account, creates a queue and then collects messages from user and places them in the queue. 

2. AzureStorageQueuePull
   This application again gets a reference to Microsoft Azure Storage Account, reads the storage queue, pulls the messages from queue and displays the count & the actual messages in the consol.
   
   
   To run a demo, configure the project in Visual Studio 2013, set the option of "Multiple Projects: in Solution Properties -> Startup project setting.
   
   
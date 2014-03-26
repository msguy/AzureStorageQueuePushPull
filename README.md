Azure Storage Queue Push Pull
=============================

This sample demonstrates how to use a Storage Queue on Microsoft Azure. 

There are two console applications in this solution

1. AzureStorageQueuePull
   This application gets a reference to Microsoft Azure Storage Account, creates a queue and then collects messages from user and places them in the queue. 

2. AzureStorageQueuePull
   This application again gets a reference to Microsoft Azure Storage Account, reads the storage queue, pulls the messages from queue and displays the count & the actual messages in the consol.
   
   
   To run a demo, configure the project in Visual Studio 2013, set the option of "Multiple Projects: in Solution Properties -> Startup project setting.
   
Run the solution. Two console windows will be displayed. 
In the AzureStorageQueuePush window, enter the number (integer) of messages you wish to place in queue. Hit Enter Key.
Now, enter you messages one at a time and hit enter. Repeat it.

In the AzureStorageQueuePull window, hit enter key. It displays the number of messages in queue and displays the messages one after the other in console.
   

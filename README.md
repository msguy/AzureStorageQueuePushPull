Azure Storage Queue Push Pull
=============================

This sample demonstrates how to use a Storage Queue on Microsoft Azure. 

There are two console applications in this solution

1. AzureStorageQueuePull :
==========================
   This application gets a reference to Microsoft Azure Storage Account, creates a queue and then collects messages from user and places them in the queue. 

2. AzureStorageQueuePull
==========================
   This application again gets a reference to Microsoft Azure Storage Account, reads the storage queue, pulls the messages from queue and displays the count & the actual messages in the consol.

   
Run a demo, 
============================
Create a storage account on azure and copy the keys. The screens below can be of your use.

Creating a storage account on Microsoft Azure

![alt tag](http://s28.postimg.org/xvvyyx6dp/Create_Storage_Account.png)


Obtaining the keys required to run the project

![alt tag](http://s3.postimg.org/6yx430jlf/Find_Keys.png)

Next,

Setup the project using Visual Studio 2013, In the solution properties, set the option to run Multiple Projects.
(Right click on Solution -> Properties -> Startup project setting Tab - "Multiple Projects".

Run the solution. Two console windows will be displayed. 
In the AzureStorageQueuePush window, enter the number (integer) of messages you wish to place in queue. Hit Enter Key.
Now, enter you messages one at a time and hit enter. Repeat it.

In the AzureStorageQueuePull window, hit enter key. It displays the number of messages in queue and displays the messages one after the other in console.

Output
![alt tag](http://s9.postimg.org/bbq0bi567/Output.png)


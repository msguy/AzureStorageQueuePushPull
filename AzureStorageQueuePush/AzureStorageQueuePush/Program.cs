using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Queue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureStorageQueuePush
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press Enter to Start Reading the Queue");
            Console.ReadKey();

            //You need to provide your storage account name and the key here.
            //Create a storage account on azure portal. Then click on the "Manage Keys" option at the bottom.
            //A dialog will be opened. Copy the Account name & primary key and paste them below respectively.
            //Note : The below name & key does not work for you as I the storage account used for this demo. Please use your own.
            //Also, it is not a good practice to put keys in code. Use SharedAccessSignature. I used like this to make it quick.
            string sAccountName = "msguystorage";
            string sAccountKey = "oN0wql7jtNDjx8rMQZbLKVP7oxlTkIZ+0yZYGR+cuZOirdH/z2fxT3/loU1+bMxdcH5+0Z2JYjhRsH/Bc6E6Sg==";

            //Set the credentials required to authenticate the request
            StorageCredentials sc = new StorageCredentials(sAccountName, sAccountKey);

            //Get the reference to storage account. Uses https protocol in this case
            CloudStorageAccount storageAccount = new CloudStorageAccount(sc, true);


            // Create the queue client.
            CloudQueueClient queueClient = storageAccount.CreateCloudQueueClient();

            // Get a reference to the queue.
            CloudQueue queue = queueClient.GetQueueReference("myfirstqueue");

            // Fetch the attributes of the Queue
            queue.FetchAttributes();

            // Retrieve the cached approximate message count.
            int? cachedMessageCount = queue.ApproximateMessageCount;

            // Display the count of messages available in queue
            Console.WriteLine("Number of messages in queue: " + cachedMessageCount);

            foreach (CloudQueueMessage message in queue.GetMessages(20))
            {
                // Print the messages
                Console.WriteLine(message.AsString);
                queue.DeleteMessage(message); // Deletes the message from queue. Not deleting a message makes it available again and again till it expires. (Max 7 Days). It is a good practice to delete a message from queue if it is not required
            }

            Console.WriteLine("Hit enter to close");
            Console.ReadLine();
        }
    }
}

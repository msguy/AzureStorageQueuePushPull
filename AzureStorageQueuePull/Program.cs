using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Queue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureStorageQueuePull
{
    class Program
    {
        static void Main(string[] args)
        {
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

            // Retrieve a reference to a queue.
            CloudQueue queue = queueClient.GetQueueReference("myfirstqueue");

            // Create the queue if it doesn't already exist.
            queue.CreateIfNotExists();

            Console.WriteLine("How many message you want to write to queue bus?");
            int x = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter the messages one after the other");

            for (int i = 0; i < x; i++)
            {

                // Create a message and add it to the queue.
                CloudQueueMessage message = new CloudQueueMessage(Console.ReadLine());
                queue.AddMessage(message);
            }

            Console.WriteLine("All the messages were successfully placed in queue. Hit enter to close.");
            Console.ReadLine();
        }
    }
}

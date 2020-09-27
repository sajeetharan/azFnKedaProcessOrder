using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace processOrder
{
    public static class processOrder
    {
        [FunctionName("processOrder")]
        public static void Run([QueueTrigger("myqueue-items", Connection = "StorageConnection")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# Queue trigger function with KEDA processed: {myQueueItem}");
        }
    }
}

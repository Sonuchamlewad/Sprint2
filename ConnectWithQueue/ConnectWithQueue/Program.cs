using Azure.Storage.Queues;
using System;

namespace ConnectwithQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            InsertMessage("Order with ORD13234 is proccessed");
        }

        public static void InsertMessage(string message)
        {
            string connectionstring = "DefaultEndpointsProtocol=https;AccountName=sangam;AccountKey=jYBhTw18+pKoBxEhpIPz6XpSRuDoX0Kw3j+LejeuJeyF0I99c84VKDm+WU5W7AQGWfI3CWF0lbsY+AStowtj0g==;EndpointSuffix=core.windows.net";
            QueueClient queueClient = new QueueClient(connectionstring, "sample-queue");
            queueClient.CreateIfNotExists();
            if (queueClient.Exists())
            {
                queueClient.SendMessage(message);
            }
            Console.WriteLine("Message is inserted");
        }
    }
}
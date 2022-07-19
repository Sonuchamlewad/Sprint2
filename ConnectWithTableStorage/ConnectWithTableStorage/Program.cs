using Azure;
using Azure.Data.Tables;
using System;

namespace ConnectWithTableStorage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var client = new TableClient(new Uri("https://sangam.table.core.windows.net"), "tblSample", new TableSharedKeyCredential("sangam", "jYBhTw18+pKoBxEhpIPz6XpSRuDoX0Kw3j+LejeuJeyF0I99c84VKDm+WU5W7AQGWfI3CWF0lbsY+AStowtj0g=="));
            Pageable<TableEntity> queryableTable = client.Query<TableEntity>();
            foreach (TableEntity item in queryableTable)
            {
                Console.WriteLine(item.GetString("Name"));
            }
        }
    }
}
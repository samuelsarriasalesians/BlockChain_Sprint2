using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BlockchainNuevo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Blockchain starting...");

            List<Transaction> transactions = new List<Transaction>
        {
            new Transaction
            {
                Id = Guid.NewGuid(),
                AccountId = Guid.NewGuid(),
                TransactionDate = DateTime.Now,
                TransactionAmount = 330500m,
                Memo = "101 N Main St Greenwood, IN"
            },
            new Transaction
            {
                Id = Guid.NewGuid(),
                AccountId = Guid.NewGuid(),
                TransactionDate = DateTime.Now,
                TransactionAmount = 474900m,
                Memo = "421 Pearl St Columbus, IN"
            },
            new Transaction
            {
                Id = Guid.NewGuid(),
                AccountId = Guid.NewGuid(),
                TransactionDate = DateTime.Now,
                TransactionAmount = 515000m,
                Memo = "416 Banta St Franklin, IN"
            }
        };

            Blockchain blockchain = new Blockchain(2);

            foreach (Transaction transaction in transactions)
            {
                string data = JsonConvert.SerializeObject(transaction);

                Console.WriteLine($"Adding block: {data}");

                Block block = new Block(blockchain.GetLatestBlock().Index + 1, DateTime.Now, data, blockchain.GetLatestBlock().Hash);
                blockchain.AddBlock(block);
            }

            Console.WriteLine($"Checking if blockchain is valid: {blockchain.IsChainValid()}");
            Console.WriteLine($"Blockchain: {JsonConvert.SerializeObject(blockchain, Formatting.Indented)}");
            Console.ReadKey();
        }
    }
}

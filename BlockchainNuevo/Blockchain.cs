using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BlockchainNuevo
{
    public class Blockchain
    {
        public List<Block> Chain { get; set; } = new List<Block>();
        public int Difficulty { get; set; }

        public Blockchain(int difficulty)
        {
            Difficulty = difficulty;
            Chain = new List<Block>();
            AddGenesisBlock();
        }

        public void AddGenesisBlock()
        {
            Chain.Add(new Block(0, DateTime.Now, "GENESIS_BLOCK", ""));
        }

        public Block GetLatestBlock()
        {
            return Chain[Chain.Count - 1];
        }

        public void AddBlock(Block block)
        {
            block.PreviousHash = GetLatestBlock().Hash;
            block.MineBlock(Difficulty);
            Chain.Add(block);
        }

        public bool IsChainValid()
        {
            for (int i = 1; i < Chain.Count; i++)
            {
                Block currentBlock = Chain[i];
                Block previousBlock = Chain[i - 1];

                if (currentBlock.Hash != currentBlock.CalculateHash())
                {
                    return false;
                }

                if (currentBlock.PreviousHash != previousBlock.Hash)
                {
                    return false;
                }
            }

            return true;
        }
    }
}

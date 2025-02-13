using System;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using BlockchainNuevo;

namespace GestorDocumental_Abad_Oriol
{
    public partial class FrmHome : Form
    {
        private Blockchain blockchain;
        private const string filePath = "Docs.json";

        public FrmHome()
        {
            InitializeComponent();
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            blockchain = FrmSplash.Blockchain;
            MostrarBlockchain();

            if (blockchain.Chain.Count == 1)
            {
                txtDifficulty.Text = blockchain.Difficulty.ToString();
                txtDifficulty.Enabled = true;
            }
            else
            {
                txtDifficulty.Text = blockchain.Difficulty.ToString();
                txtDifficulty.Enabled = false;
            }
        }

        private void MostrarBlockchain()
        {
            // Muestra la cadena en el RichTextBox en formato JSON
            richTextBox1.Text = JsonConvert.SerializeObject(blockchain, Formatting.Indented);

            // Mostrar la cadena de bloques en el DataGridView
            dtgBlockChain.DataSource = null;  // Limpiar el DataSource actual
            dtgBlockChain.Rows.Clear();  // Limpiar las filas actuales

            //Iterar sobre la cadena de bloques y agregar cada bloque al DataGridView
            foreach (var block in blockchain.Chain)
            {
                dtgBlockChain.Rows.Add(block.Index, block.Timestamp, block.Hash, block.PreviousHash, block.Data, block.Nonce);
            }
        }
        private void GuardarBlockchain()
        {
            // Serializar la blockchain y guardarla automáticamente
            string json = JsonConvert.SerializeObject(blockchain, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }
        private void btnAddBlock_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string data = File.ReadAllText(openFileDialog.FileName);
                Block newBlock = new Block(blockchain.Chain.Count, DateTime.Now, data, blockchain.GetLatestBlock().Hash);
                newBlock.MineBlock(blockchain.Difficulty);
                blockchain.AddBlock(newBlock);

                GuardarBlockchain();
                MostrarBlockchain();

                listBox1.Items.Add("Nuevo bloque añadido.");
            }
        }

        private void btnCheckDocument_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIndex.Text, out int index) || index < 0 || index >= blockchain.Chain.Count)
            {
                MessageBox.Show("Índice inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string data = File.ReadAllText(openFileDialog.FileName);
                Block testBlock = new Block(index, blockchain.Chain[index].Timestamp, data, blockchain.Chain[index].PreviousHash);
                testBlock.MineBlock(blockchain.Difficulty);

                if (testBlock.Hash == blockchain.Chain[index].Hash)
                {
                    MessageBox.Show("El documento es válido.", "Verificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pbStatus.ImageLocation = "\\images\\OK.png";
                }
                else
                {
                    MessageBox.Show("El documento ha sido manipulado o es diferente.", "Verificación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnShowBlockChain_Click(object sender, EventArgs e)
        {
            // Mostrar la cadena en el RichTextBox
            richTextBox1.Text = JsonConvert.SerializeObject(blockchain, Formatting.Indented);

            // Mostrar la cadena de bloques en el DataGridView
            dtgBlockChain.DataSource = null;  // Limpiar el DataSource actual
            dtgBlockChain.Rows.Clear();  // Limpiar las filas actuales

            // Iterar sobre la cadena de bloques y agregar cada bloque al DataGridView
            foreach (var block in blockchain.Chain)
            {
                dtgBlockChain.Rows.Add(block.Index, block.Timestamp, block.Hash, block.PreviousHash, block.Data, block.Nonce);
            }
        }

        private void txtIndex_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtIndex.Text, out int ind))
            {
                btnCheck.Enabled = true;  // Activamos el botón si el texto es un número válido
            }
            else
            {
                btnCheck.Enabled = false; // Desactivamos el botón si el texto no es un número
            }
        }
    }
}

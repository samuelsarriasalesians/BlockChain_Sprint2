using System;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using BlockchainNuevo;
using System.Reflection;

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
            blockchain.Difficulty = Convert.ToInt32(txtDifficulty.Text);

            LogStatus("Blockchain cargada en memoria.");

            if (blockchain.Chain.Count == 1)
            {
                txtDifficulty.Text = blockchain.Difficulty.ToString();
                txtDifficulty.Enabled = true;
                LogStatus("Dificultad editable.");
            }
            else
            {
                txtDifficulty.Text = blockchain.Difficulty.ToString();
                txtDifficulty.Enabled = false;
                LogStatus("Dificultad bloqueada.");
            }
        }

        private void MostrarBlockchain()
        {
            LogStatus("Mostrando blockchain...");

            // Muestra la cadena en el RichTextBox en formato JSON
            richTextBox1.Text = JsonConvert.SerializeObject(blockchain, Formatting.Indented);
            Application.DoEvents();

            // Limpiar y actualizar DataGridView
            dtgBlockChain.DataSource = null;
            dtgBlockChain.Rows.Clear();
            Application.DoEvents();

            LogStatus("Blockchain mostrada.");
        }

        private void GuardarBlockchain()
        {
            LogStatus("Guardando blockchain...");

            // Serializar la blockchain y guardarla en archivo
            string json = JsonConvert.SerializeObject(blockchain, Formatting.Indented);
            File.WriteAllText(filePath, json);
            Application.DoEvents();

            LogStatus("Blockchain guardada correctamente.");
        }

        private void btnAddBlock_Click(object sender, EventArgs e)
        {
            blockchain.Difficulty = Convert.ToInt32(txtDifficulty.Text);

            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                LogStatus("Cargando archivo...");
                string data = File.ReadAllText(openFileDialog.FileName);
                LogStatus("Archivo cargado. Creando bloque...");

                Block newBlock = new Block(blockchain.Chain.Count, DateTime.Now, data, blockchain.GetLatestBlock().Hash);
                newBlock.MineBlock(blockchain.Difficulty);
                LogStatus("Bloque minado correctamente.");

                blockchain.AddBlock(newBlock);
                LogStatus("Bloque añadido a la blockchain.");

                GuardarBlockchain();
                MostrarBlockchain();
                UpdateDataGridView();
            }
            if (blockchain.Chain.Count > 1)
            {
                txtDifficulty.Enabled = false;
            }
        }

        private void btnCheckDocument_Click(object sender, EventArgs e)
        {
            LogStatus("Verificando documento...");

            if (!int.TryParse(txtIndex.Text, out int index) || index < 0 || index >= blockchain.Chain.Count)
            {
                MessageBox.Show("Índice inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LogStatus("Error: Índice inválido.");
                return;
            }

            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                LogStatus("Cargando archivo...");
                string data = File.ReadAllText(openFileDialog.FileName);
                LogStatus("Archivo cargado. Verificando integridad...");

                Block testBlock = new Block(index, blockchain.Chain[index].Timestamp, data, blockchain.Chain[index].PreviousHash);
                testBlock.MineBlock(blockchain.Difficulty);

                lblVerification2.Text = $"Document index: {txtIndex.Text}";

                if (testBlock.Hash == blockchain.Chain[index].Hash)
                {
                    pbStatus.ImageLocation = "images\\OK.png";
                    label1.Text = "Successfully verified";
                    LogStatus("Documento verificado correctamente.");
                }
                else
                {
                    pbStatus.ImageLocation = "images\\NOK.png";
                    label1.Text = "Unsuccessfully verified";
                    LogStatus("Error: La verificación falló.");
                }

                groupBox2.Visible = true;
            }
        }

        private void btnShowBlockChain_Click(object sender, EventArgs e)
        {
            LogStatus("Actualizando vista de blockchain...");
            MostrarBlockchain();
            UpdateDataGridView();
            LogStatus("Blockchain actualizada en la interfaz.");
        }

        private void txtIndex_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtIndex.Text, out int ind))
            {
                btnCheck.Enabled = true;
                LogStatus("Índice válido ingresado.");
            }
            else
            {
                btnCheck.Enabled = false;
                LogStatus("Error: Índice inválido.");
            }
        }

        private void UpdateDataGridView()
        {
            LogStatus("Actualizando DataGridView...");
            dtgBlockChain.Rows.Clear();
            dtgBlockChain.Columns.Clear();

            if (blockchain.Chain.Count > 0)
            {
                var firstBlock = blockchain.Chain[0];
                PropertyInfo[] properties = firstBlock.GetType().GetProperties();

                foreach (var property in properties)
                {
                    dtgBlockChain.Columns.Add(property.Name, property.Name);
                }

                foreach (var block in blockchain.Chain)
                {
                    var row = new DataGridViewRow();

                    foreach (var property in properties)
                    {
                        var cell = new DataGridViewTextBoxCell
                        {
                            Value = property.GetValue(block)?.ToString() ?? string.Empty
                        };
                        row.Cells.Add(cell);
                    }

                    dtgBlockChain.Rows.Add(row);
                }
            }

            LogStatus("DataGridView actualizado.");
        }

        private void LogStatus(string message)
        {
            listBox1.Items.Add($"{DateTime.Now:HH:mm:ss} - {message}");
            listBox1.TopIndex = listBox1.Items.Count - 1; // Scroll automático al último mensaje
            Application.DoEvents();
        }
    }
}

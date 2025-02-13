using System;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using BlockchainNuevo;

namespace GestorDocumental_Abad_Oriol
{
    public partial class FrmSplash : Form
    {
        private Timer splashTimer;
        private int dotCount;
        private int totalTime;
        public static Blockchain Blockchain { get; private set; }
        private readonly string jsonFilePath = "Docs.json";

        

        public FrmSplash()
        {
            InitializeComponent();
            InitializeSplashTimer();
            dotCount = 0;  // Inicializamos el contador de puntos
            totalTime = 0; // Variable para contar el tiempo total
            LoadBlockchain(); // Cargamos la blockchain al iniciar el splash
        }

        private void InitializeSplashTimer()
        {
            splashTimer = new Timer();
            splashTimer.Interval = 500;
            splashTimer.Tick += SplashTimer_Tick;
            splashTimer.Start();
        }

        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            dotCount++;

            string loadingText = "Loading" + new string('.', dotCount);
            if (dotCount > 3)
            {
                dotCount = 0;
                loadingText = "Loading";
            }

            lblLoading.Text = loadingText;

            totalTime += 500;

            // Si han pasado 5 segundos y la blockchain ya se cargó, avanzamos
            if (totalTime >= 5000)
            {
                splashTimer.Stop();
                FrmHome homeForm = new FrmHome();
                homeForm.Show();
                this.Hide();
            }
        }

        private void LoadBlockchain()
        {
            try
            {
                if (File.Exists(jsonFilePath))
                {
                    string jsonData = File.ReadAllText(jsonFilePath);
                    Blockchain = JsonConvert.DeserializeObject<Blockchain>(jsonData);

                    if (Blockchain == null || Blockchain.Chain.Count == 0)
                    {
                        InitializeNewBlockchain();
                    }
                }
                else
                {
                    InitializeNewBlockchain();
                }
            }
            catch (Exception)
            {
                InitializeNewBlockchain();
            }
        }

        private void InitializeNewBlockchain()
        {
            Blockchain = new Blockchain(2); // Dificultad 2
            Blockchain.Chain[0].Data = "BLOC_INICIAL";  
            SaveBlockchain();
        }


        private void SaveBlockchain()
        {
            string jsonData = JsonConvert.SerializeObject(Blockchain, Formatting.Indented);
            File.WriteAllText(jsonFilePath, jsonData);
        }
    }
}

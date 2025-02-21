
namespace GestorDocumental_Abad_Oriol
{
    partial class FrmHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            this.btnAddBlock = new System.Windows.Forms.Button();
            this.btnShowBlockChain = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.lblIndex = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pbStatus = new System.Windows.Forms.PictureBox();
            this.lblVerification2 = new System.Windows.Forms.Label();
            this.lblVerification1 = new System.Windows.Forms.Label();
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.txtDifficulty = new System.Windows.Forms.TextBox();
            this.dtgBlockChain = new System.Windows.Forms.DataGridView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBlockChain)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddBlock
            // 
            this.btnAddBlock.Location = new System.Drawing.Point(59, 72);
            this.btnAddBlock.Name = "btnAddBlock";
            this.btnAddBlock.Size = new System.Drawing.Size(93, 50);
            this.btnAddBlock.TabIndex = 0;
            this.btnAddBlock.Text = "Add new block";
            this.btnAddBlock.UseVisualStyleBackColor = true;
            this.btnAddBlock.Click += new System.EventHandler(this.btnAddBlock_Click);
            // 
            // btnShowBlockChain
            // 
            this.btnShowBlockChain.Location = new System.Drawing.Point(59, 128);
            this.btnShowBlockChain.Name = "btnShowBlockChain";
            this.btnShowBlockChain.Size = new System.Drawing.Size(93, 54);
            this.btnShowBlockChain.TabIndex = 1;
            this.btnShowBlockChain.Text = "Show BlockChain";
            this.btnShowBlockChain.UseVisualStyleBackColor = true;
            this.btnShowBlockChain.Click += new System.EventHandler(this.btnShowBlockChain_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCheck);
            this.groupBox1.Controls.Add(this.txtIndex);
            this.groupBox1.Controls.Add(this.lblIndex);
            this.groupBox1.Location = new System.Drawing.Point(158, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 115);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File verification";
            // 
            // btnCheck
            // 
            this.btnCheck.Enabled = false;
            this.btnCheck.Location = new System.Drawing.Point(10, 56);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 53);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "Check document";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheckDocument_Click);
            // 
            // txtIndex
            // 
            this.txtIndex.Location = new System.Drawing.Point(69, 22);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(100, 22);
            this.txtIndex.TabIndex = 1;
            this.txtIndex.TextChanged += new System.EventHandler(this.txtIndex_TextChanged);
            // 
            // lblIndex
            // 
            this.lblIndex.AutoSize = true;
            this.lblIndex.Location = new System.Drawing.Point(7, 22);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(41, 17);
            this.lblIndex.TabIndex = 0;
            this.lblIndex.Text = "Index";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.pbStatus);
            this.groupBox2.Controls.Add(this.lblVerification2);
            this.groupBox2.Controls.Add(this.lblVerification1);
            this.groupBox2.Location = new System.Drawing.Point(364, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 132);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Verification reult";
            this.groupBox2.Visible = false;
            // 
            // pbStatus
            // 
            this.pbStatus.Image = ((System.Drawing.Image)(resources.GetObject("pbStatus.Image")));
            this.pbStatus.Location = new System.Drawing.Point(20, 56);
            this.pbStatus.Name = "pbStatus";
            this.pbStatus.Size = new System.Drawing.Size(53, 50);
            this.pbStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStatus.TabIndex = 2;
            this.pbStatus.TabStop = false;
            // 
            // lblVerification2
            // 
            this.lblVerification2.AutoSize = true;
            this.lblVerification2.Location = new System.Drawing.Point(79, 56);
            this.lblVerification2.Name = "lblVerification2";
            this.lblVerification2.Size = new System.Drawing.Size(23, 17);
            this.lblVerification2.TabIndex = 1;
            this.lblVerification2.Text = "ok";
            // 
            // lblVerification1
            // 
            this.lblVerification1.AutoSize = true;
            this.lblVerification1.Location = new System.Drawing.Point(17, 27);
            this.lblVerification1.Name = "lblVerification1";
            this.lblVerification1.Size = new System.Drawing.Size(216, 17);
            this.lblVerification1.TabIndex = 0;
            this.lblVerification1.Text = "Result for the document checked";
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.Location = new System.Drawing.Point(66, 194);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(65, 17);
            this.lblDifficulty.TabIndex = 4;
            this.lblDifficulty.Text = "Difficulty:";
            // 
            // txtDifficulty
            // 
            this.txtDifficulty.Location = new System.Drawing.Point(137, 191);
            this.txtDifficulty.Name = "txtDifficulty";
            this.txtDifficulty.Size = new System.Drawing.Size(30, 22);
            this.txtDifficulty.TabIndex = 5;
            this.txtDifficulty.Text = "2";
            // 
            // dtgBlockChain
            // 
            this.dtgBlockChain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBlockChain.Location = new System.Drawing.Point(59, 232);
            this.dtgBlockChain.Name = "dtgBlockChain";
            this.dtgBlockChain.RowHeadersWidth = 51;
            this.dtgBlockChain.RowTemplate.Height = 24;
            this.dtgBlockChain.Size = new System.Drawing.Size(847, 259);
            this.dtgBlockChain.TabIndex = 6;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(613, 51);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(293, 148);
            this.listBox1.TabIndex = 7;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(912, 51);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(623, 715);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Variable Display", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(63, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(327, 32);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "File Verification BlockChain";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1553, 782);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dtgBlockChain);
            this.Controls.Add(this.txtDifficulty);
            this.Controls.Add(this.lblDifficulty);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnShowBlockChain);
            this.Controls.Add(this.btnAddBlock);
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmHome";
            this.Load += new System.EventHandler(this.FrmHome_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBlockChain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddBlock;
        private System.Windows.Forms.Button btnShowBlockChain;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox txtIndex;
        private System.Windows.Forms.Label lblIndex;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pbStatus;
        private System.Windows.Forms.Label lblVerification2;
        private System.Windows.Forms.Label lblVerification1;
        private System.Windows.Forms.Label lblDifficulty;
        private System.Windows.Forms.TextBox txtDifficulty;
        private System.Windows.Forms.DataGridView dtgBlockChain;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
    }
}
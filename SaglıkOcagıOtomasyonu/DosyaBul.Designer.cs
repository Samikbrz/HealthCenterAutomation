namespace SaglıkOcagıOtomasyonu
{
    partial class DosyaBul
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Bul = new System.Windows.Forms.Button();
            this.label_Ve = new System.Windows.Forms.Label();
            this.checkBox_Ve = new System.Windows.Forms.CheckBox();
            this.textBox_AramaKriteriTwo = new System.Windows.Forms.TextBox();
            this.textBox_AramaKriteri = new System.Windows.Forms.TextBox();
            this.comboBox_AramaKriterleri = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_AramaSonucları = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AramaSonucları)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button_Bul);
            this.panel1.Controls.Add(this.label_Ve);
            this.panel1.Controls.Add(this.checkBox_Ve);
            this.panel1.Controls.Add(this.textBox_AramaKriteriTwo);
            this.panel1.Controls.Add(this.textBox_AramaKriteri);
            this.panel1.Controls.Add(this.comboBox_AramaKriterleri);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(601, 42);
            this.panel1.TabIndex = 0;
            // 
            // button_Bul
            // 
            this.button_Bul.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button_Bul.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Bul.Location = new System.Drawing.Point(513, 1);
            this.button_Bul.Name = "button_Bul";
            this.button_Bul.Size = new System.Drawing.Size(74, 30);
            this.button_Bul.TabIndex = 1;
            this.button_Bul.Text = "Bul";
            this.button_Bul.UseVisualStyleBackColor = false;
            this.button_Bul.Click += new System.EventHandler(this.button_Bul_Click);
            // 
            // label_Ve
            // 
            this.label_Ve.AutoSize = true;
            this.label_Ve.Location = new System.Drawing.Point(378, 8);
            this.label_Ve.Name = "label_Ve";
            this.label_Ve.Size = new System.Drawing.Size(23, 17);
            this.label_Ve.TabIndex = 4;
            this.label_Ve.Text = "ve";
            // 
            // checkBox_Ve
            // 
            this.checkBox_Ve.AutoSize = true;
            this.checkBox_Ve.Location = new System.Drawing.Point(354, 9);
            this.checkBox_Ve.Name = "checkBox_Ve";
            this.checkBox_Ve.Size = new System.Drawing.Size(18, 17);
            this.checkBox_Ve.TabIndex = 3;
            this.checkBox_Ve.UseVisualStyleBackColor = true;
            // 
            // textBox_AramaKriteriTwo
            // 
            this.textBox_AramaKriteriTwo.Location = new System.Drawing.Point(407, 5);
            this.textBox_AramaKriteriTwo.Name = "textBox_AramaKriteriTwo";
            this.textBox_AramaKriteriTwo.Size = new System.Drawing.Size(100, 22);
            this.textBox_AramaKriteriTwo.TabIndex = 2;
            // 
            // textBox_AramaKriteri
            // 
            this.textBox_AramaKriteri.Location = new System.Drawing.Point(236, 5);
            this.textBox_AramaKriteri.Name = "textBox_AramaKriteri";
            this.textBox_AramaKriteri.Size = new System.Drawing.Size(112, 22);
            this.textBox_AramaKriteri.TabIndex = 2;
            // 
            // comboBox_AramaKriterleri
            // 
            this.comboBox_AramaKriterleri.FormattingEnabled = true;
            this.comboBox_AramaKriterleri.Items.AddRange(new object[] {
            "Hasta Adı Soyadı",
            "Dosya No",
            "Kurum Sicil No"});
            this.comboBox_AramaKriterleri.Location = new System.Drawing.Point(99, 5);
            this.comboBox_AramaKriterleri.Name = "comboBox_AramaKriterleri";
            this.comboBox_AramaKriterleri.Size = new System.Drawing.Size(131, 24);
            this.comboBox_AramaKriterleri.TabIndex = 1;
            this.comboBox_AramaKriterleri.SelectedIndexChanged += new System.EventHandler(this.comboBox_AramaKriterleri_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arma Kriteri";
            // 
            // dataGridView_AramaSonucları
            // 
            this.dataGridView_AramaSonucları.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_AramaSonucları.Location = new System.Drawing.Point(1, 38);
            this.dataGridView_AramaSonucları.Name = "dataGridView_AramaSonucları";
            this.dataGridView_AramaSonucları.RowTemplate.Height = 24;
            this.dataGridView_AramaSonucları.Size = new System.Drawing.Size(601, 355);
            this.dataGridView_AramaSonucları.TabIndex = 1;
            // 
            // DosyaBul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 391);
            this.Controls.Add(this.dataGridView_AramaSonucları);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DosyaBul";
            this.Text = "<Dosya Bul>";
            this.Load += new System.EventHandler(this.DosyaBul_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AramaSonucları)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_Bul;
        private System.Windows.Forms.Label label_Ve;
        private System.Windows.Forms.CheckBox checkBox_Ve;
        private System.Windows.Forms.TextBox textBox_AramaKriteriTwo;
        private System.Windows.Forms.TextBox textBox_AramaKriteri;
        private System.Windows.Forms.ComboBox comboBox_AramaKriterleri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_AramaSonucları;
    }
}
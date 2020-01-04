namespace SaglıkOcagıOtomasyonu
{
    partial class Raporlama
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_BaslagıcTarihi = new System.Windows.Forms.ComboBox();
            this.comboBox_BitisTarihi = new System.Windows.Forms.ComboBox();
            this.radioButton_TaburcuOlmus = new System.Windows.Forms.RadioButton();
            this.radioButton_Hepsi = new System.Windows.Forms.RadioButton();
            this.radioButton_TaburcuOlmamıs = new System.Windows.Forms.RadioButton();
            this.button_Sorgula = new System.Windows.Forms.Button();
            this.button_Temizle = new System.Windows.Forms.Button();
            this.button_Yazdır = new System.Windows.Forms.Button();
            this.button_Cıkıs = new System.Windows.Forms.Button();
            this.dataGridView_TaburcuBilgileri = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TaburcuBilgileri)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Başlangıç Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bitiş Tarihi";
            // 
            // comboBox_BaslagıcTarihi
            // 
            this.comboBox_BaslagıcTarihi.FormattingEnabled = true;
            this.comboBox_BaslagıcTarihi.Location = new System.Drawing.Point(145, 26);
            this.comboBox_BaslagıcTarihi.Name = "comboBox_BaslagıcTarihi";
            this.comboBox_BaslagıcTarihi.Size = new System.Drawing.Size(121, 24);
            this.comboBox_BaslagıcTarihi.TabIndex = 1;
            // 
            // comboBox_BitisTarihi
            // 
            this.comboBox_BitisTarihi.FormattingEnabled = true;
            this.comboBox_BitisTarihi.Location = new System.Drawing.Point(145, 69);
            this.comboBox_BitisTarihi.Name = "comboBox_BitisTarihi";
            this.comboBox_BitisTarihi.Size = new System.Drawing.Size(121, 24);
            this.comboBox_BitisTarihi.TabIndex = 1;
            // 
            // radioButton_TaburcuOlmus
            // 
            this.radioButton_TaburcuOlmus.AutoSize = true;
            this.radioButton_TaburcuOlmus.Location = new System.Drawing.Point(303, 18);
            this.radioButton_TaburcuOlmus.Name = "radioButton_TaburcuOlmus";
            this.radioButton_TaburcuOlmus.Size = new System.Drawing.Size(126, 21);
            this.radioButton_TaburcuOlmus.TabIndex = 2;
            this.radioButton_TaburcuOlmus.TabStop = true;
            this.radioButton_TaburcuOlmus.Text = "Taburcu Olmuş";
            this.radioButton_TaburcuOlmus.UseVisualStyleBackColor = true;
            // 
            // radioButton_Hepsi
            // 
            this.radioButton_Hepsi.AutoSize = true;
            this.radioButton_Hepsi.Location = new System.Drawing.Point(303, 72);
            this.radioButton_Hepsi.Name = "radioButton_Hepsi";
            this.radioButton_Hepsi.Size = new System.Drawing.Size(65, 21);
            this.radioButton_Hepsi.TabIndex = 2;
            this.radioButton_Hepsi.TabStop = true;
            this.radioButton_Hepsi.Text = "Hepsi";
            this.radioButton_Hepsi.UseVisualStyleBackColor = true;
            // 
            // radioButton_TaburcuOlmamıs
            // 
            this.radioButton_TaburcuOlmamıs.AutoSize = true;
            this.radioButton_TaburcuOlmamıs.Location = new System.Drawing.Point(303, 45);
            this.radioButton_TaburcuOlmamıs.Name = "radioButton_TaburcuOlmamıs";
            this.radioButton_TaburcuOlmamıs.Size = new System.Drawing.Size(140, 21);
            this.radioButton_TaburcuOlmamıs.TabIndex = 2;
            this.radioButton_TaburcuOlmamıs.TabStop = true;
            this.radioButton_TaburcuOlmamıs.Text = "Taburcu Olmamış";
            this.radioButton_TaburcuOlmamıs.UseVisualStyleBackColor = true;
            // 
            // button_Sorgula
            // 
            this.button_Sorgula.Location = new System.Drawing.Point(465, 18);
            this.button_Sorgula.Name = "button_Sorgula";
            this.button_Sorgula.Size = new System.Drawing.Size(75, 71);
            this.button_Sorgula.TabIndex = 3;
            this.button_Sorgula.Text = "Sorgula";
            this.button_Sorgula.UseVisualStyleBackColor = true;
            this.button_Sorgula.Click += new System.EventHandler(this.button_Sorgula_Click);
            // 
            // button_Temizle
            // 
            this.button_Temizle.Location = new System.Drawing.Point(546, 18);
            this.button_Temizle.Name = "button_Temizle";
            this.button_Temizle.Size = new System.Drawing.Size(75, 71);
            this.button_Temizle.TabIndex = 3;
            this.button_Temizle.Text = "Temizle";
            this.button_Temizle.UseVisualStyleBackColor = true;
            this.button_Temizle.Click += new System.EventHandler(this.button_Temizle_Click);
            // 
            // button_Yazdır
            // 
            this.button_Yazdır.Location = new System.Drawing.Point(627, 18);
            this.button_Yazdır.Name = "button_Yazdır";
            this.button_Yazdır.Size = new System.Drawing.Size(75, 71);
            this.button_Yazdır.TabIndex = 3;
            this.button_Yazdır.Text = "Yazdır";
            this.button_Yazdır.UseVisualStyleBackColor = true;
            this.button_Yazdır.Click += new System.EventHandler(this.button_Yazdır_Click);
            // 
            // button_Cıkıs
            // 
            this.button_Cıkıs.Location = new System.Drawing.Point(773, 20);
            this.button_Cıkıs.Name = "button_Cıkıs";
            this.button_Cıkıs.Size = new System.Drawing.Size(75, 71);
            this.button_Cıkıs.TabIndex = 3;
            this.button_Cıkıs.Text = "Çıkış";
            this.button_Cıkıs.UseVisualStyleBackColor = true;
            this.button_Cıkıs.Click += new System.EventHandler(this.button_Cıkıs_Click);
            // 
            // dataGridView_TaburcuBilgileri
            // 
            this.dataGridView_TaburcuBilgileri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_TaburcuBilgileri.Location = new System.Drawing.Point(2, 99);
            this.dataGridView_TaburcuBilgileri.Name = "dataGridView_TaburcuBilgileri";
            this.dataGridView_TaburcuBilgileri.RowTemplate.Height = 24;
            this.dataGridView_TaburcuBilgileri.Size = new System.Drawing.Size(846, 350);
            this.dataGridView_TaburcuBilgileri.TabIndex = 4;
            // 
            // Raporlama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 450);
            this.Controls.Add(this.dataGridView_TaburcuBilgileri);
            this.Controls.Add(this.button_Cıkıs);
            this.Controls.Add(this.button_Yazdır);
            this.Controls.Add(this.button_Temizle);
            this.Controls.Add(this.button_Sorgula);
            this.Controls.Add(this.radioButton_TaburcuOlmamıs);
            this.Controls.Add(this.radioButton_Hepsi);
            this.Controls.Add(this.radioButton_TaburcuOlmus);
            this.Controls.Add(this.comboBox_BitisTarihi);
            this.Controls.Add(this.comboBox_BaslagıcTarihi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Raporlama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raporlama";
            this.Load += new System.EventHandler(this.Raporlama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TaburcuBilgileri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_BaslagıcTarihi;
        private System.Windows.Forms.ComboBox comboBox_BitisTarihi;
        private System.Windows.Forms.RadioButton radioButton_TaburcuOlmus;
        private System.Windows.Forms.RadioButton radioButton_Hepsi;
        private System.Windows.Forms.RadioButton radioButton_TaburcuOlmamıs;
        private System.Windows.Forms.Button button_Sorgula;
        private System.Windows.Forms.Button button_Temizle;
        private System.Windows.Forms.Button button_Yazdır;
        private System.Windows.Forms.Button button_Cıkıs;
        private System.Windows.Forms.DataGridView dataGridView_TaburcuBilgileri;
    }
}
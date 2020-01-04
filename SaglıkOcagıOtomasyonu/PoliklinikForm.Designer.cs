namespace SaglıkOcagıOtomasyonu
{
    partial class PoliklinikForm
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
            this.textBox_PoliklinikAdi = new System.Windows.Forms.TextBox();
            this.checkBox_Gecerlilik = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox_Acıklama = new System.Windows.Forms.RichTextBox();
            this.button_Cıkıs = new System.Windows.Forms.Button();
            this.button__Sil = new System.Windows.Forms.Button();
            this.button_Guncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Poliklinik Adı";
            // 
            // textBox_PoliklinikAdi
            // 
            this.textBox_PoliklinikAdi.Location = new System.Drawing.Point(104, 23);
            this.textBox_PoliklinikAdi.Name = "textBox_PoliklinikAdi";
            this.textBox_PoliklinikAdi.Size = new System.Drawing.Size(243, 22);
            this.textBox_PoliklinikAdi.TabIndex = 1;
            this.textBox_PoliklinikAdi.TextChanged += new System.EventHandler(this.textBox_PoliklinikAdi_TextChanged);
            // 
            // checkBox_Gecerlilik
            // 
            this.checkBox_Gecerlilik.AutoSize = true;
            this.checkBox_Gecerlilik.Location = new System.Drawing.Point(104, 51);
            this.checkBox_Gecerlilik.Name = "checkBox_Gecerlilik";
            this.checkBox_Gecerlilik.Size = new System.Drawing.Size(131, 21);
            this.checkBox_Gecerlilik.TabIndex = 2;
            this.checkBox_Gecerlilik.Text = "Geçerlik/Geçerli";
            this.checkBox_Gecerlilik.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Açıklama";
            // 
            // richTextBox_Acıklama
            // 
            this.richTextBox_Acıklama.Location = new System.Drawing.Point(15, 103);
            this.richTextBox_Acıklama.Name = "richTextBox_Acıklama";
            this.richTextBox_Acıklama.Size = new System.Drawing.Size(332, 103);
            this.richTextBox_Acıklama.TabIndex = 4;
            this.richTextBox_Acıklama.Text = "";
            // 
            // button_Cıkıs
            // 
            this.button_Cıkıs.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button_Cıkıs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Cıkıs.Location = new System.Drawing.Point(244, 212);
            this.button_Cıkıs.Name = "button_Cıkıs";
            this.button_Cıkıs.Size = new System.Drawing.Size(103, 54);
            this.button_Cıkıs.TabIndex = 5;
            this.button_Cıkıs.Text = "Çıkış";
            this.button_Cıkıs.UseVisualStyleBackColor = false;
            this.button_Cıkıs.Click += new System.EventHandler(this.button_Cıkıs_Click);
            // 
            // button__Sil
            // 
            this.button__Sil.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button__Sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button__Sil.ForeColor = System.Drawing.Color.Red;
            this.button__Sil.Location = new System.Drawing.Point(131, 212);
            this.button__Sil.Name = "button__Sil";
            this.button__Sil.Size = new System.Drawing.Size(107, 54);
            this.button__Sil.TabIndex = 6;
            this.button__Sil.Text = "Sil";
            this.button__Sil.UseVisualStyleBackColor = false;
            this.button__Sil.Click += new System.EventHandler(this.button__Sil_Click);
            // 
            // button_Guncelle
            // 
            this.button_Guncelle.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button_Guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Guncelle.ForeColor = System.Drawing.Color.Green;
            this.button_Guncelle.Location = new System.Drawing.Point(14, 212);
            this.button_Guncelle.Name = "button_Guncelle";
            this.button_Guncelle.Size = new System.Drawing.Size(111, 54);
            this.button_Guncelle.TabIndex = 7;
            this.button_Guncelle.Text = "Güncelle";
            this.button_Guncelle.UseVisualStyleBackColor = false;
            this.button_Guncelle.Click += new System.EventHandler(this.button_Guncelle_Click);
            // 
            // PoliklinikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 281);
            this.Controls.Add(this.button_Cıkıs);
            this.Controls.Add(this.button__Sil);
            this.Controls.Add(this.button_Guncelle);
            this.Controls.Add(this.richTextBox_Acıklama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox_Gecerlilik);
            this.Controls.Add(this.textBox_PoliklinikAdi);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PoliklinikForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Poliklinik";
            this.Load += new System.EventHandler(this.Poliklinik_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_PoliklinikAdi;
        private System.Windows.Forms.CheckBox checkBox_Gecerlilik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox_Acıklama;
        private System.Windows.Forms.Button button_Cıkıs;
        private System.Windows.Forms.Button button__Sil;
        private System.Windows.Forms.Button button_Guncelle;
    }
}
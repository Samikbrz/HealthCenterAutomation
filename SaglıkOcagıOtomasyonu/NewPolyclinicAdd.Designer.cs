namespace SaglıkOcagıOtomasyonu
{
    partial class NewPolyclinicAdd
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
            this.button_Cıkıs = new System.Windows.Forms.Button();
            this.button_Ekle = new System.Windows.Forms.Button();
            this.richTextBox_Acıklama = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox_Gecerlilik = new System.Windows.Forms.CheckBox();
            this.textBox_PoliklinikAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Cıkıs
            // 
            this.button_Cıkıs.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button_Cıkıs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Cıkıs.Location = new System.Drawing.Point(175, 186);
            this.button_Cıkıs.Name = "button_Cıkıs";
            this.button_Cıkıs.Size = new System.Drawing.Size(103, 54);
            this.button_Cıkıs.TabIndex = 13;
            this.button_Cıkıs.Text = "Çıkış";
            this.button_Cıkıs.UseVisualStyleBackColor = false;
            this.button_Cıkıs.Click += new System.EventHandler(this.button_Cıkıs_Click);
            // 
            // button_Ekle
            // 
            this.button_Ekle.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button_Ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Ekle.ForeColor = System.Drawing.Color.Green;
            this.button_Ekle.Location = new System.Drawing.Point(14, 186);
            this.button_Ekle.Name = "button_Ekle";
            this.button_Ekle.Size = new System.Drawing.Size(111, 54);
            this.button_Ekle.TabIndex = 15;
            this.button_Ekle.Text = "Ekle";
            this.button_Ekle.UseVisualStyleBackColor = false;
            this.button_Ekle.Click += new System.EventHandler(this.button_Ekle_Click);
            // 
            // richTextBox_Acıklama
            // 
            this.richTextBox_Acıklama.Location = new System.Drawing.Point(15, 77);
            this.richTextBox_Acıklama.Name = "richTextBox_Acıklama";
            this.richTextBox_Acıklama.Size = new System.Drawing.Size(263, 103);
            this.richTextBox_Acıklama.TabIndex = 12;
            this.richTextBox_Acıklama.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Açıklama";
            // 
            // checkBox_Gecerlilik
            // 
            this.checkBox_Gecerlilik.AutoSize = true;
            this.checkBox_Gecerlilik.Location = new System.Drawing.Point(104, 34);
            this.checkBox_Gecerlilik.Name = "checkBox_Gecerlilik";
            this.checkBox_Gecerlilik.Size = new System.Drawing.Size(131, 21);
            this.checkBox_Gecerlilik.TabIndex = 10;
            this.checkBox_Gecerlilik.Text = "Geçerlik/Geçerli";
            this.checkBox_Gecerlilik.UseVisualStyleBackColor = true;
            // 
            // textBox_PoliklinikAdi
            // 
            this.textBox_PoliklinikAdi.Location = new System.Drawing.Point(104, 6);
            this.textBox_PoliklinikAdi.Name = "textBox_PoliklinikAdi";
            this.textBox_PoliklinikAdi.Size = new System.Drawing.Size(174, 22);
            this.textBox_PoliklinikAdi.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Poliklinik Adı";
            // 
            // NewPolyclinicAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 248);
            this.Controls.Add(this.button_Cıkıs);
            this.Controls.Add(this.button_Ekle);
            this.Controls.Add(this.richTextBox_Acıklama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox_Gecerlilik);
            this.Controls.Add(this.textBox_PoliklinikAdi);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NewPolyclinicAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewPolyclinicAdd";
            this.Load += new System.EventHandler(this.NewPolyclinicAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Cıkıs;
        private System.Windows.Forms.Button button_Ekle;
        private System.Windows.Forms.RichTextBox richTextBox_Acıklama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox_Gecerlilik;
        private System.Windows.Forms.TextBox textBox_PoliklinikAdi;
        private System.Windows.Forms.Label label1;
    }
}
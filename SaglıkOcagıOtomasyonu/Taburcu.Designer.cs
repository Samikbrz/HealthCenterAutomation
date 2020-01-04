namespace SaglıkOcagıOtomasyonu
{
    partial class Taburcu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker_CıkısTarihi = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_SevkTarihi = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_OdemeSekli = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_ToplamTutar = new System.Windows.Forms.TextBox();
            this.textBox_TCKimlikNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Vazgec = new System.Windows.Forms.Button();
            this.button_Kaydet = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker_CıkısTarihi);
            this.groupBox1.Controls.Add(this.dateTimePicker_SevkTarihi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBox_OdemeSekli);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_ToplamTutar);
            this.groupBox1.Controls.Add(this.textBox_TCKimlikNo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 177);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dateTimePicker_CıkısTarihi
            // 
            this.dateTimePicker_CıkısTarihi.Location = new System.Drawing.Point(117, 75);
            this.dateTimePicker_CıkısTarihi.Name = "dateTimePicker_CıkısTarihi";
            this.dateTimePicker_CıkısTarihi.Size = new System.Drawing.Size(189, 22);
            this.dateTimePicker_CıkısTarihi.TabIndex = 4;
            // 
            // dateTimePicker_SevkTarihi
            // 
            this.dateTimePicker_SevkTarihi.Location = new System.Drawing.Point(117, 45);
            this.dateTimePicker_SevkTarihi.Name = "dateTimePicker_SevkTarihi";
            this.dateTimePicker_SevkTarihi.Size = new System.Drawing.Size(189, 22);
            this.dateTimePicker_SevkTarihi.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Toplam Tutar:";
            // 
            // comboBox_OdemeSekli
            // 
            this.comboBox_OdemeSekli.FormattingEnabled = true;
            this.comboBox_OdemeSekli.Items.AddRange(new object[] {
            "Nakit",
            "Kredi Kartı-Taksitli",
            "Kredi Kartı-Tek Çekim",
            "Çek",
            "Senet"});
            this.comboBox_OdemeSekli.Location = new System.Drawing.Point(117, 107);
            this.comboBox_OdemeSekli.Name = "comboBox_OdemeSekli";
            this.comboBox_OdemeSekli.Size = new System.Drawing.Size(189, 24);
            this.comboBox_OdemeSekli.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ödeme Şekli";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Çıkış Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sevk Tarihi:";
            // 
            // textBox_ToplamTutar
            // 
            this.textBox_ToplamTutar.Location = new System.Drawing.Point(117, 137);
            this.textBox_ToplamTutar.Name = "textBox_ToplamTutar";
            this.textBox_ToplamTutar.Size = new System.Drawing.Size(189, 22);
            this.textBox_ToplamTutar.TabIndex = 1;
            // 
            // textBox_TCKimlikNo
            // 
            this.textBox_TCKimlikNo.Location = new System.Drawing.Point(117, 15);
            this.textBox_TCKimlikNo.Name = "textBox_TCKimlikNo";
            this.textBox_TCKimlikNo.Size = new System.Drawing.Size(189, 22);
            this.textBox_TCKimlikNo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC No:";
            // 
            // button_Vazgec
            // 
            this.button_Vazgec.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button_Vazgec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Vazgec.Location = new System.Drawing.Point(15, 186);
            this.button_Vazgec.Name = "button_Vazgec";
            this.button_Vazgec.Size = new System.Drawing.Size(94, 30);
            this.button_Vazgec.TabIndex = 1;
            this.button_Vazgec.Text = "Vazgeç";
            this.button_Vazgec.UseVisualStyleBackColor = false;
            this.button_Vazgec.Click += new System.EventHandler(this.button_Vazgec_Click);
            // 
            // button_Kaydet
            // 
            this.button_Kaydet.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button_Kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Kaydet.Location = new System.Drawing.Point(230, 186);
            this.button_Kaydet.Name = "button_Kaydet";
            this.button_Kaydet.Size = new System.Drawing.Size(94, 30);
            this.button_Kaydet.TabIndex = 1;
            this.button_Kaydet.Text = "Kaydet";
            this.button_Kaydet.UseVisualStyleBackColor = false;
            this.button_Kaydet.Click += new System.EventHandler(this.button_Kaydet_Click);
            // 
            // Taburcu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 225);
            this.Controls.Add(this.button_Kaydet);
            this.Controls.Add(this.button_Vazgec);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Taburcu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SOHATS-Taburcu";
            this.Load += new System.EventHandler(this.Taburcu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_CıkısTarihi;
        private System.Windows.Forms.DateTimePicker dateTimePicker_SevkTarihi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_OdemeSekli;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_ToplamTutar;
        private System.Windows.Forms.TextBox textBox_TCKimlikNo;
        private System.Windows.Forms.Button button_Vazgec;
        private System.Windows.Forms.Button button_Kaydet;
    }
}
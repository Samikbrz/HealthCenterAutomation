namespace SaglıkOcagıOtomasyonu
{
    partial class AnaForm
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
            this.Login = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Cıkıs = new System.Windows.Forms.Button();
            this.button_Temizle = new System.Windows.Forms.Button();
            this.button_Giris = new System.Windows.Forms.Button();
            this.textBox_Sifre = new System.Windows.Forms.TextBox();
            this.textBox_KullanıcıAdı = new System.Windows.Forms.TextBox();
            this.label_Sifre = new System.Windows.Forms.Label();
            this.label_KullanıcıAdı = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Referanslar_MenuSprit = new System.Windows.Forms.ToolStripMenuItem();
            this.Logout_MenuSplit = new System.Windows.Forms.ToolStripMenuItem();
            this.PoliklinikTanıtma_MenuSplit = new System.Windows.Forms.ToolStripMenuItem();
            this.KullanıcıTanıtma_MenuSplit = new System.Windows.Forms.ToolStripMenuItem();
            this.Cıkıs_MenuSplit = new System.Windows.Forms.ToolStripMenuItem();
            this.HastaKabul_MenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.HastaIslemleri_MenuSplit = new System.Windows.Forms.ToolStripMenuItem();
            this.Raporlar_MenuSprit = new System.Windows.Forms.ToolStripMenuItem();
            this.Raporlar_MenuSplit = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_PoliklinikTanıtma = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox_PoliklinikAdı = new System.Windows.Forms.ComboBox();
            this.checkBox_GecerliGecersiz = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel_KullanıcıTanıtma = new System.Windows.Forms.Panel();
            this.button_YeniKullanıcıEkle = new System.Windows.Forms.Button();
            this.comboBox_KullanıcıAdı = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Login.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel_PoliklinikTanıtma.SuspendLayout();
            this.panel_KullanıcıTanıtma.SuspendLayout();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Login.Controls.Add(this.label1);
            this.Login.Controls.Add(this.button_Cıkıs);
            this.Login.Controls.Add(this.button_Temizle);
            this.Login.Controls.Add(this.button_Giris);
            this.Login.Controls.Add(this.textBox_Sifre);
            this.Login.Controls.Add(this.textBox_KullanıcıAdı);
            this.Login.Controls.Add(this.label_Sifre);
            this.Login.Controls.Add(this.label_KullanıcıAdı);
            this.Login.Location = new System.Drawing.Point(355, 283);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(380, 194);
            this.Login.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "  SOHATS-Login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_Cıkıs
            // 
            this.button_Cıkıs.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button_Cıkıs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Cıkıs.Location = new System.Drawing.Point(266, 126);
            this.button_Cıkıs.Name = "button_Cıkıs";
            this.button_Cıkıs.Size = new System.Drawing.Size(92, 54);
            this.button_Cıkıs.TabIndex = 5;
            this.button_Cıkıs.Text = "Çıkış";
            this.button_Cıkıs.UseVisualStyleBackColor = false;
            this.button_Cıkıs.Click += new System.EventHandler(this.button_Cıkıs_Click);
            // 
            // button_Temizle
            // 
            this.button_Temizle.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button_Temizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Temizle.ForeColor = System.Drawing.Color.Yellow;
            this.button_Temizle.Location = new System.Drawing.Point(135, 126);
            this.button_Temizle.Name = "button_Temizle";
            this.button_Temizle.Size = new System.Drawing.Size(96, 54);
            this.button_Temizle.TabIndex = 4;
            this.button_Temizle.Text = "Temizle";
            this.button_Temizle.UseVisualStyleBackColor = false;
            this.button_Temizle.Click += new System.EventHandler(this.button_Temizle_Click);
            // 
            // button_Giris
            // 
            this.button_Giris.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button_Giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Giris.ForeColor = System.Drawing.Color.Green;
            this.button_Giris.Location = new System.Drawing.Point(36, 126);
            this.button_Giris.Name = "button_Giris";
            this.button_Giris.Size = new System.Drawing.Size(93, 54);
            this.button_Giris.TabIndex = 3;
            this.button_Giris.Text = "Giriş";
            this.button_Giris.UseVisualStyleBackColor = false;
            this.button_Giris.Click += new System.EventHandler(this.button_Giris_Click);
            // 
            // textBox_Sifre
            // 
            this.textBox_Sifre.Location = new System.Drawing.Point(135, 82);
            this.textBox_Sifre.Name = "textBox_Sifre";
            this.textBox_Sifre.Size = new System.Drawing.Size(223, 22);
            this.textBox_Sifre.TabIndex = 2;
            this.textBox_Sifre.TextChanged += new System.EventHandler(this.textBox_Sifre_TextChanged);
            this.textBox_Sifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Sifre_KeyPress);
            // 
            // textBox_KullanıcıAdı
            // 
            this.textBox_KullanıcıAdı.Location = new System.Drawing.Point(135, 49);
            this.textBox_KullanıcıAdı.Name = "textBox_KullanıcıAdı";
            this.textBox_KullanıcıAdı.Size = new System.Drawing.Size(223, 22);
            this.textBox_KullanıcıAdı.TabIndex = 1;
            // 
            // label_Sifre
            // 
            this.label_Sifre.AutoSize = true;
            this.label_Sifre.Location = new System.Drawing.Point(92, 85);
            this.label_Sifre.Name = "label_Sifre";
            this.label_Sifre.Size = new System.Drawing.Size(37, 17);
            this.label_Sifre.TabIndex = 1;
            this.label_Sifre.Text = "Şifre";
            // 
            // label_KullanıcıAdı
            // 
            this.label_KullanıcıAdı.AutoSize = true;
            this.label_KullanıcıAdı.Location = new System.Drawing.Point(45, 52);
            this.label_KullanıcıAdı.Name = "label_KullanıcıAdı";
            this.label_KullanıcıAdı.Size = new System.Drawing.Size(84, 17);
            this.label_KullanıcıAdı.TabIndex = 0;
            this.label_KullanıcıAdı.Text = "Kullanıcı Adı";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Referanslar_MenuSprit,
            this.HastaKabul_MenuStrip,
            this.Raporlar_MenuSprit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1103, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // Referanslar_MenuSprit
            // 
            this.Referanslar_MenuSprit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Logout_MenuSplit,
            this.PoliklinikTanıtma_MenuSplit,
            this.KullanıcıTanıtma_MenuSplit,
            this.Cıkıs_MenuSplit});
            this.Referanslar_MenuSprit.Name = "Referanslar_MenuSprit";
            this.Referanslar_MenuSprit.Size = new System.Drawing.Size(95, 24);
            this.Referanslar_MenuSprit.Text = "Referanslar";
            // 
            // Logout_MenuSplit
            // 
            this.Logout_MenuSplit.Name = "Logout_MenuSplit";
            this.Logout_MenuSplit.Size = new System.Drawing.Size(216, 26);
            this.Logout_MenuSplit.Text = "Logout";
            this.Logout_MenuSplit.Click += new System.EventHandler(this.Logout_MenuSplit_Click);
            // 
            // PoliklinikTanıtma_MenuSplit
            // 
            this.PoliklinikTanıtma_MenuSplit.Name = "PoliklinikTanıtma_MenuSplit";
            this.PoliklinikTanıtma_MenuSplit.Size = new System.Drawing.Size(216, 26);
            this.PoliklinikTanıtma_MenuSplit.Text = "Poliklinik Tanıtma";
            this.PoliklinikTanıtma_MenuSplit.Click += new System.EventHandler(this.PoliklinikTanıtma_MenuSplit_Click);
            // 
            // KullanıcıTanıtma_MenuSplit
            // 
            this.KullanıcıTanıtma_MenuSplit.Name = "KullanıcıTanıtma_MenuSplit";
            this.KullanıcıTanıtma_MenuSplit.Size = new System.Drawing.Size(216, 26);
            this.KullanıcıTanıtma_MenuSplit.Text = "Kullanıcı Tanıtma";
            this.KullanıcıTanıtma_MenuSplit.Click += new System.EventHandler(this.KullanıcıTanıtma_MenuSplit_Click);
            // 
            // Cıkıs_MenuSplit
            // 
            this.Cıkıs_MenuSplit.Name = "Cıkıs_MenuSplit";
            this.Cıkıs_MenuSplit.Size = new System.Drawing.Size(216, 26);
            this.Cıkıs_MenuSplit.Text = "Çıkış";
            this.Cıkıs_MenuSplit.Click += new System.EventHandler(this.Cıkıs_MenuSplit_Click);
            // 
            // HastaKabul_MenuStrip
            // 
            this.HastaKabul_MenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HastaIslemleri_MenuSplit});
            this.HastaKabul_MenuStrip.Name = "HastaKabul_MenuStrip";
            this.HastaKabul_MenuStrip.Size = new System.Drawing.Size(101, 24);
            this.HastaKabul_MenuStrip.Text = "Hasta Kabul";
            // 
            // HastaIslemleri_MenuSplit
            // 
            this.HastaIslemleri_MenuSplit.Name = "HastaIslemleri_MenuSplit";
            this.HastaIslemleri_MenuSplit.Size = new System.Drawing.Size(182, 26);
            this.HastaIslemleri_MenuSplit.Text = "Hasta İşlemleri";
            this.HastaIslemleri_MenuSplit.Click += new System.EventHandler(this.HastaIslemleri_MenuSplit_Click);
            // 
            // Raporlar_MenuSprit
            // 
            this.Raporlar_MenuSprit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Raporlar_MenuSplit});
            this.Raporlar_MenuSprit.Name = "Raporlar_MenuSprit";
            this.Raporlar_MenuSprit.Size = new System.Drawing.Size(78, 24);
            this.Raporlar_MenuSprit.Text = "Raporlar";
            // 
            // Raporlar_MenuSplit
            // 
            this.Raporlar_MenuSplit.Name = "Raporlar_MenuSplit";
            this.Raporlar_MenuSplit.Size = new System.Drawing.Size(141, 26);
            this.Raporlar_MenuSplit.Text = "Raporlar";
            this.Raporlar_MenuSplit.Click += new System.EventHandler(this.Raporlar_MenuSplit_Click);
            // 
            // panel_PoliklinikTanıtma
            // 
            this.panel_PoliklinikTanıtma.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel_PoliklinikTanıtma.Controls.Add(this.button1);
            this.panel_PoliklinikTanıtma.Controls.Add(this.comboBox_PoliklinikAdı);
            this.panel_PoliklinikTanıtma.Controls.Add(this.checkBox_GecerliGecersiz);
            this.panel_PoliklinikTanıtma.Controls.Add(this.label2);
            this.panel_PoliklinikTanıtma.Controls.Add(this.label4);
            this.panel_PoliklinikTanıtma.Location = new System.Drawing.Point(355, 84);
            this.panel_PoliklinikTanıtma.Name = "panel_PoliklinikTanıtma";
            this.panel_PoliklinikTanıtma.Size = new System.Drawing.Size(380, 150);
            this.panel_PoliklinikTanıtma.TabIndex = 0;
            this.panel_PoliklinikTanıtma.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_PoliklinikTanıtma_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Green;
            this.button1.Location = new System.Drawing.Point(46, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(312, 29);
            this.button1.TabIndex = 8;
            this.button1.Text = "Yeni Poliklinik Ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox_PoliklinikAdı
            // 
            this.comboBox_PoliklinikAdı.FormattingEnabled = true;
            this.comboBox_PoliklinikAdı.Location = new System.Drawing.Point(135, 52);
            this.comboBox_PoliklinikAdı.Name = "comboBox_PoliklinikAdı";
            this.comboBox_PoliklinikAdı.Size = new System.Drawing.Size(223, 24);
            this.comboBox_PoliklinikAdı.TabIndex = 6;
            this.comboBox_PoliklinikAdı.SelectedIndexChanged += new System.EventHandler(this.comboBox_PoliklinikAdı_SelectedIndexChanged);
            this.comboBox_PoliklinikAdı.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_PoliklinikAdı_KeyPress);
            this.comboBox_PoliklinikAdı.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox_PoliklinikAdı_MouseClick);
            // 
            // checkBox_GecerliGecersiz
            // 
            this.checkBox_GecerliGecersiz.AutoSize = true;
            this.checkBox_GecerliGecersiz.Location = new System.Drawing.Point(135, 81);
            this.checkBox_GecerliGecersiz.Name = "checkBox_GecerliGecersiz";
            this.checkBox_GecerliGecersiz.Size = new System.Drawing.Size(135, 21);
            this.checkBox_GecerliGecersiz.TabIndex = 5;
            this.checkBox_GecerliGecersiz.Text = "Geçerli/Geçersiz";
            this.checkBox_GecerliGecersiz.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(380, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "  SOHATS-Poliklinik Tanıtma";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Poliklinik Adı";
            // 
            // panel_KullanıcıTanıtma
            // 
            this.panel_KullanıcıTanıtma.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel_KullanıcıTanıtma.Controls.Add(this.button_YeniKullanıcıEkle);
            this.panel_KullanıcıTanıtma.Controls.Add(this.comboBox_KullanıcıAdı);
            this.panel_KullanıcıTanıtma.Controls.Add(this.label3);
            this.panel_KullanıcıTanıtma.Controls.Add(this.label5);
            this.panel_KullanıcıTanıtma.Location = new System.Drawing.Point(34, 84);
            this.panel_KullanıcıTanıtma.Name = "panel_KullanıcıTanıtma";
            this.panel_KullanıcıTanıtma.Size = new System.Drawing.Size(281, 109);
            this.panel_KullanıcıTanıtma.TabIndex = 0;
            // 
            // button_YeniKullanıcıEkle
            // 
            this.button_YeniKullanıcıEkle.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button_YeniKullanıcıEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_YeniKullanıcıEkle.ForeColor = System.Drawing.Color.Green;
            this.button_YeniKullanıcıEkle.Location = new System.Drawing.Point(31, 71);
            this.button_YeniKullanıcıEkle.Name = "button_YeniKullanıcıEkle";
            this.button_YeniKullanıcıEkle.Size = new System.Drawing.Size(231, 29);
            this.button_YeniKullanıcıEkle.TabIndex = 7;
            this.button_YeniKullanıcıEkle.Text = "Yeni Kullanıcı Ekle";
            this.button_YeniKullanıcıEkle.UseVisualStyleBackColor = false;
            this.button_YeniKullanıcıEkle.Click += new System.EventHandler(this.button_YeniKullanıcıEkle_Click);
            // 
            // comboBox_KullanıcıAdı
            // 
            this.comboBox_KullanıcıAdı.FormattingEnabled = true;
            this.comboBox_KullanıcıAdı.Location = new System.Drawing.Point(131, 41);
            this.comboBox_KullanıcıAdı.Name = "comboBox_KullanıcıAdı";
            this.comboBox_KullanıcıAdı.Size = new System.Drawing.Size(131, 24);
            this.comboBox_KullanıcıAdı.TabIndex = 6;
            this.comboBox_KullanıcıAdı.SelectedIndexChanged += new System.EventHandler(this.comboBox_KullanııcKodu_SelectedIndexChanged);
            this.comboBox_KullanıcıAdı.Click += new System.EventHandler(this.comboBox_KullanııcKodu_Click);
            this.comboBox_KullanıcıAdı.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_KullanııcKodu_KeyPress);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(281, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "  SOHATS-Kullanıcı Tanıtma";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Kullanıcı Adı";
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1103, 758);
            this.Controls.Add(this.panel_KullanıcıTanıtma);
            this.Controls.Add(this.panel_PoliklinikTanıtma);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Login.ResumeLayout(false);
            this.Login.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel_PoliklinikTanıtma.ResumeLayout(false);
            this.panel_PoliklinikTanıtma.PerformLayout();
            this.panel_KullanıcıTanıtma.ResumeLayout(false);
            this.panel_KullanıcıTanıtma.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Login;
        private System.Windows.Forms.Button button_Cıkıs;
        private System.Windows.Forms.Button button_Temizle;
        private System.Windows.Forms.Button button_Giris;
        private System.Windows.Forms.TextBox textBox_Sifre;
        private System.Windows.Forms.TextBox textBox_KullanıcıAdı;
        private System.Windows.Forms.Label label_Sifre;
        private System.Windows.Forms.Label label_KullanıcıAdı;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Referanslar_MenuSprit;
        private System.Windows.Forms.ToolStripMenuItem HastaKabul_MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem Logout_MenuSplit;
        private System.Windows.Forms.ToolStripMenuItem PoliklinikTanıtma_MenuSplit;
        private System.Windows.Forms.ToolStripMenuItem KullanıcıTanıtma_MenuSplit;
        private System.Windows.Forms.ToolStripMenuItem Cıkıs_MenuSplit;
        private System.Windows.Forms.ToolStripMenuItem HastaIslemleri_MenuSplit;
        private System.Windows.Forms.ToolStripMenuItem Raporlar_MenuSprit;
        private System.Windows.Forms.ToolStripMenuItem Raporlar_MenuSplit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_PoliklinikTanıtma;
        private System.Windows.Forms.CheckBox checkBox_GecerliGecersiz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_PoliklinikAdı;
        private System.Windows.Forms.Panel panel_KullanıcıTanıtma;
        private System.Windows.Forms.ComboBox comboBox_KullanıcıAdı;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_YeniKullanıcıEkle;
        private System.Windows.Forms.Button button1;
    }
}


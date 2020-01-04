using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SaglıkOcagıOtomasyonu
{
    public partial class AnaForm : Form
    {
        BlockIncorrectInput _blockIncorrectInput = new BlockIncorrectInput();
        DatabaseTransactions _databaseTransactions = new DatabaseTransactions();        
        public AnaForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;                       
            MenuSplitKontrol(false);
            panel_PoliklinikTanıtma.Visible = false;
            panel_KullanıcıTanıtma.Visible = false;
        }

        public void PoliklinikAdi()
        {
            comboBox_PoliklinikAdı.Items.Clear();
            _databaseTransactions.GetAllPoliklinikInformation();
            for (int i = 0; i < _databaseTransactions._polikliniks.Count; i++)
            {
                comboBox_PoliklinikAdı.Items.Add(_databaseTransactions._polikliniks[i].PoliklinikAdi);
            }
        }

        public void KullaniciKodu()
        {
            comboBox_KullanıcıAdı.Items.Clear();
            _databaseTransactions.GetAllUsers();
            for (int i = 0; i < _databaseTransactions._users.Count; i++)
            {
                comboBox_KullanıcıAdı.Items.Add(_databaseTransactions._users[i].KullaniciAdi);
            }
        }

        private void MenuSplitKontrol(Boolean B)
        {
            Referanslar_MenuSprit.Visible = B;
            HastaKabul_MenuStrip.Enabled = B;
            Raporlar_MenuSprit.Enabled = B;
        }

        private void PanelKontrol(Boolean B)
        {
            panel_KullanıcıTanıtma.Visible = B;
            panel_PoliklinikTanıtma.Visible = B;
        }

        private void button_Giris_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_KullanıcıAdı.Text) || String.IsNullOrEmpty(textBox_Sifre.Text))
            {
                MessageBox.Show("Lütfen kullanıcı adınızı ve şifrenizi eksiksiz giriniz.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool Bulma = false;
                string KullanıcıAdı = textBox_KullanıcıAdı.Text;
                string Sifre = textBox_Sifre.Text.ToString();
                _databaseTransactions.UserInputControler();
                for (int i = 0; i < _databaseTransactions._UserInputControler.Count; i++)
                {
                    if (_databaseTransactions._UserInputControler[i].KullaniciAdi==KullanıcıAdı && _databaseTransactions._UserInputControler[i].Sifre==Sifre)
                    {
                        MessageBox.Show("Giriş Başarılı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Login.Visible = false;
                        MenuSplitKontrol(true);
                        Bulma = true;
                        if (_databaseTransactions._UserInputControler[i].Yetki=="true")
                        {
                            Referanslar_MenuSprit.Visible = true;
                        }
                        else
                        {
                            Referanslar_MenuSprit.Visible = false;
                        }
                        break;
                    }                    
                }
                if (Bulma==false)
                {
                    MessageBox.Show("Yanlış kullanıcı adı ve/veya şifre.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }               
            }
        }

        private void button_Temizle_Click(object sender, EventArgs e)
        {
            textBox_KullanıcıAdı.Clear();
            textBox_Sifre.Clear();
        }

        private void button_Cıkıs_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HastaIslemleri_MenuSplit_Click(object sender, EventArgs e)
        {
            PanelKontrol(false);
            this.IsMdiContainer = true;
            Hasta_İslemleri hasta_İslemleri = new Hasta_İslemleri();
            hasta_İslemleri.MdiParent = this;
            hasta_İslemleri.StartPosition = FormStartPosition.CenterScreen;
            hasta_İslemleri.Show();
        }

        private void Cıkıs_MenuSplit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PoliklinikTanıtma_MenuSplit_Click(object sender, EventArgs e)
        {
            comboBox_PoliklinikAdı.Items.Clear();
            PoliklinikAdi();            
            comboBox_PoliklinikAdı.Text = "";            
            panel_KullanıcıTanıtma.Visible = false;
            panel_PoliklinikTanıtma.Visible = true;
        }

        private void Raporlar_MenuSplit_Click(object sender, EventArgs e)
        {
            PanelKontrol(false);
            Raporlama raporlama = new Raporlama();
            raporlama.ShowDialog();
        }

        private void comboBox_KullanııcKodu_SelectedIndexChanged(object sender, EventArgs e){            
        }

        private void KullanıcıTanıtma_MenuSplit_Click(object sender, EventArgs e)
        {
            comboBox_KullanıcıAdı.Items.Clear();
            KullaniciKodu();
            panel_PoliklinikTanıtma.Visible = false;
            panel_KullanıcıTanıtma.Visible = true;
        }        

        private void panel_PoliklinikTanıtma_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox_PoliklinikAdı_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < _databaseTransactions._polikliniks.Count; i++)
            {
                if (comboBox_PoliklinikAdı.Text == _databaseTransactions._polikliniks[i].PoliklinikAdi)
                {
                    checkBox_GecerliGecersiz.Checked = true;
                    checkBox_GecerliGecersiz.Enabled = false;
                }
            }
        }

        private void textBox_Sifre_TextChanged(object sender, EventArgs e)
        {
            textBox_Sifre.PasswordChar = '*';
        }

        private void textBox_Sifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            _blockIncorrectInput.HarfGirisEngelle(e);
            _blockIncorrectInput.KarakterGirisiEngelle(e);
        }

        private void comboBox_KullanııcKodu_Click(object sender, EventArgs e)
        {

        }       

        private void comboBox_PoliklinikAdı_KeyPress(object sender, KeyPressEventArgs e)
        {            
            if (e.KeyChar == 13)
            {
                if (!String.IsNullOrEmpty(comboBox_PoliklinikAdı.Text))
                {
                    panel_PoliklinikTanıtma.Visible = false;
                    bool Value = false;
                    if (checkBox_GecerliGecersiz.Checked == true)
                    {
                        Value = true;
                    }
                    PoliklinikForm poliklinik = new PoliklinikForm(comboBox_PoliklinikAdı.Text.ToString(), Value);
                    poliklinik.ShowDialog();
                }                
            }
        }

        private void comboBox_KullanııcKodu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {                
                if (!(String.IsNullOrEmpty(comboBox_KullanıcıAdı.Text)))
                {
                    panel_KullanıcıTanıtma.Visible = false;                    
                    Users users = new Users
                    {
                        KullaniciAdi = comboBox_KullanıcıAdı.Text.ToString(),
                    };
                    KullanıcıTanıtma kullanıcıTanıtma = new KullanıcıTanıtma(users);
                    kullanıcıTanıtma.ShowDialog();
                }                
            }
        }

        private void button_YeniKullanıcıEkle_Click(object sender, EventArgs e)
        {
            int DataAdeti = _databaseTransactions._users.Count;            
            int YeniKullanıcıKodu = Convert.ToInt32(_databaseTransactions._users[DataAdeti - 1].KullaniciKodu) + 1;            
            KullanıcıTanıtma kullanıcıTanıtma = new KullanıcıTanıtma(YeniKullanıcıKodu);
            panel_KullanıcıTanıtma.Visible = false;
            kullanıcıTanıtma.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Logout_MenuSplit_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel_PoliklinikTanıtma.Visible = false;            
            NewPolyclinicAdd newPolyclinicAdd = new NewPolyclinicAdd();
            newPolyclinicAdd.ShowDialog();
        }

        private void comboBox_PoliklinikAdı_MouseClick(object sender, MouseEventArgs e)
        {
           
        }
    }
}
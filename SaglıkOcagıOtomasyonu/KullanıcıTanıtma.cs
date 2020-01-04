using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaglıkOcagıOtomasyonu
{
    public partial class KullanıcıTanıtma : Form
    {
        DatabaseTransactions _databaseTransactions = new DatabaseTransactions();
        int id;
        int YeniKullanıcıKodu;
        public KullanıcıTanıtma()
        {
            InitializeComponent();            ;
        } 

        public KullanıcıTanıtma(Users users)
        {
            InitializeComponent();
            textBox_KullanıcıAdı.Text = users.KullaniciAdi;
        }
        
        public KullanıcıTanıtma(int KullanıcıKodu)
        {
            InitializeComponent();
            textBox_KullanıcıKodu.Text = KullanıcıKodu.ToString();
        }

        private void KullanıcıTanıtma_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            _databaseTransactions.GetAllUsers();
            VerileriGetir();
            checkBox_YetkiliKullanıcı.Enabled = false;            
            if (!(String.IsNullOrEmpty(textBox_TCNo.Text)))
            {
                button_YeniKullanıcıEkle.Enabled = false;
            }            
        }        

        public void VerileriGetir()
        {                       
            for (int i = 0; i < _databaseTransactions._users.Count; i++)
            {                
                if (textBox_KullanıcıAdı.Text == _databaseTransactions._users[i].KullaniciAdi)
                {
                    id = _databaseTransactions._users[i].ID;
                    textBox_KullanıcıKodu.Text = _databaseTransactions._users[i].KullaniciKodu.ToString();
                    textBox_TCNo.Text = _databaseTransactions._users[i].TC.ToString();
                    textBox_AnneAdı.Text = _databaseTransactions._users[i].AnneAdi;
                    textBox_BabaAdı.Text = _databaseTransactions._users[i].BabaAdi;
                    textBox_DogumYeri.Text = _databaseTransactions._users[i].DogumYeri;
                    textBox_GSM.Text = _databaseTransactions._users[i].CepTel.ToString();
                    textBox_TelefonNo.Text = _databaseTransactions._users[i].EvTel.ToString();                    
                    textBox_Maas.Text = _databaseTransactions._users[i].Maas.ToString();
                    textBox_Sifre.Text = _databaseTransactions._users[i].Sifre.ToString();
                    textBox_Soyadı.Text = _databaseTransactions._users[i].Soyad;
                    textBox_Adı.Text = _databaseTransactions._users[i].Ad;
                    dateTimePicker_IseBaslama.Text = _databaseTransactions._users[i].IseBaslama.ToLongDateString();
                    dateTimePicker_DogumTarihi.Text = _databaseTransactions._users[i].DogumTarihi.ToLongDateString();
                    richTextBox_Adres.Text = _databaseTransactions._users[i].Adres;
                    comboBox_Unvan.Text = _databaseTransactions._users[i].Unvan;
                    comboBox_Cinsiyet.Text = _databaseTransactions._users[i].Cinsiyet.ToString();
                    comboBox_MedeniHali.Text = _databaseTransactions._users[i].MedeniHali.ToString();
                    comboBox_KanGrubu.Text = _databaseTransactions._users[i].KanGrubu.ToString();
                    if (_databaseTransactions._users[i].Yetki=="true")
                    {
                        checkBox_YetkiliKullanıcı.Checked = true;
                    }
                    else
                    {
                        checkBox_YetkiliKullanıcı.Checked = false;
                    }
                }
            }            
            textBox_KullanıcıKodu.Enabled = false;
        }

        private void button_Güncelle_Click(object sender, EventArgs e)
        {            
            Users users = new Users
            {
                ID = id,
                Ad=textBox_Adı.Text.ToString(),
                Soyad = textBox_Soyadı.Text.ToString(),
                Sifre = textBox_Sifre.Text.ToString(),
                EvTel = Convert.ToDecimal(textBox_TelefonNo.Text),
                CepTel = Convert.ToDecimal(textBox_GSM.Text),
                Adres = richTextBox_Adres.Text.ToString(),
                IseBaslama=Convert.ToDateTime(dateTimePicker_IseBaslama.Text),
                Maas=Convert.ToDecimal(textBox_Maas.Text),
                DogumYeri=textBox_DogumYeri.Text.ToString(),
                AnneAdi=textBox_AnneAdı.Text.ToString(),
                BabaAdi=textBox_BabaAdı.Text.ToString(),
                DogumTarihi=Convert.ToDateTime(dateTimePicker_DogumTarihi.Text),
                TC=textBox_TCNo.Text.ToString(),
                KullaniciAdi=textBox_KullanıcıAdı.Text.ToString(),
                Unvan=comboBox_Unvan.Text.ToString(),   
                Cinsiyet=comboBox_Cinsiyet.Text.ToString(),
                MedeniHali=comboBox_MedeniHali.Text.ToString(),
                KanGrubu=comboBox_KanGrubu.Text.ToString(),                
            };
            if (checkBox_YetkiliKullanıcı.Checked==true)
            {
                users.Yetki = "true";
            }
            else
            {
                users.Yetki = "false";
            }
            _databaseTransactions.UpdateKullanıcıTanıtma(users);
            MessageBox.Show("Güncelleme tamamlandı", "UPDATED", MessageBoxButtons.OK, MessageBoxIcon.Information);            
        }

        private void button_Cıkıs_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Sil_Click(object sender, EventArgs e)
        {
            _databaseTransactions.DeleteUser(id);
            this.Close();
        }

        private void button_YeniKullanıcıEkle_Click(object sender, EventArgs e)
        {
            bool Bulma=false;             
            for (int i = 0; i < _databaseTransactions._users.Count; i++)
            {
                if (textBox_TCNo.Text==_databaseTransactions._users[i].TC)
                {
                    Bulma = true;
                    MessageBox.Show("Bu kullanıcı zaten sistemde mevcut", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (Bulma == false)
            {
                Users users = new Users
                {
                    TC=textBox_TCNo.Text,
                    Unvan=comboBox_Unvan.Text,
                    Ad=textBox_Adı.Text,
                    Soyad=textBox_Soyadı.Text,
                    DogumYeri=textBox_DogumYeri.Text,
                    BabaAdi=textBox_BabaAdı.Text,
                    AnneAdi=textBox_AnneAdı.Text,
                    Maas=Convert.ToDecimal(textBox_Maas.Text),
                    EvTel=Convert.ToDecimal(textBox_TelefonNo.Text),
                    CepTel=Convert.ToDecimal(textBox_GSM.Text),                    
                    IseBaslama=Convert.ToDateTime(dateTimePicker_IseBaslama.Text),
                    DogumTarihi=Convert.ToDateTime(dateTimePicker_DogumTarihi.Text),
                    Adres=richTextBox_Adres.Text,
                    KullaniciAdi=textBox_KullanıcıAdı.Text,
                    Sifre=textBox_Sifre.Text.ToString(),
                    KullaniciKodu=Convert.ToInt32(textBox_KullanıcıKodu.Text),
                    Cinsiyet=comboBox_Cinsiyet.Text.ToString(),
                    MedeniHali=comboBox_MedeniHali.Text.ToString(),
                    KanGrubu=comboBox_KanGrubu.Text.ToString()
                };
                if (checkBox_YetkiliKullanıcı.Checked==true)
                {
                    users.Yetki = "true";
                }
                else
                {
                    users.Yetki = "false";
                }
                _databaseTransactions.AddNewUsers(users);
            }
        }

        private void button_Temizle_Click(object sender, EventArgs e)
        {
            textBox_KullanıcıKodu.Text = "";
            textBox_AnneAdı.Text = "";
            textBox_TCNo.Text = "";
            textBox_DogumYeri.Text = "";
            textBox_BabaAdı.Text = "";
            textBox_TelefonNo.Text = "";
            textBox_GSM.Text = "";
            textBox_Adı.Text = "";
            textBox_KullanıcıAdı.Text = "";
            textBox_Maas.Text = "";
            textBox_Sifre.Text = "";
            textBox_Soyadı.Text = "";
            comboBox_Cinsiyet.Text = "";
            comboBox_KanGrubu.Text = "";
            comboBox_MedeniHali.Text = "";
            comboBox_Unvan.Text = "";
            dateTimePicker_DogumTarihi.Text = "";
            dateTimePicker_IseBaslama.Text = "";
            richTextBox_Adres.Text = "";
            checkBox_YetkiliKullanıcı.Text = null;
        }

        private void comboBox_Unvan_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void comboBox_Unvan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Unvan.Text == "Doktor")
            {
                checkBox_YetkiliKullanıcı.Checked = true;
            }
            else
            {
                checkBox_YetkiliKullanıcı.Checked = false;
            }
        }
    }
}

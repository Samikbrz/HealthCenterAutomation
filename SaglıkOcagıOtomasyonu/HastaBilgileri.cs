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
    public partial class HastaBilgileri : Form
    {
        DatabaseTransactions _databaseTransactions = new DatabaseTransactions();
        public HastaBilgileri()
        {
            InitializeComponent();            
        }

        public HastaBilgileri(string NewFilesNumber)
        {
            InitializeComponent();
            textBox_DosyaNo.Enabled = false;
            textBox_DosyaNo.Text = NewFilesNumber.ToString();
        }

        public HastaBilgileri(Patient patient)
        {
            InitializeComponent();
            _databaseTransactions.GetALLPatient();
            for (int i = 0; i < _databaseTransactions._patients.Count; i++)
            {
                if (patient.TC == _databaseTransactions._patients[i].TC)
                {
                    textBox_DosyaNo.Text = _databaseTransactions._patients[i].DosyaNo;
                    textBox_Ad.Text = _databaseTransactions._patients[i].Ad;
                    textBox_Soyad.Text = _databaseTransactions._patients[i].Soyad;
                    maskedTextBox_TCKimlikNo.Text = _databaseTransactions._patients[i].TC;
                    textBox_DogumYeri.Text = _databaseTransactions._patients[i].DogumYeri;
                    textBox_BabaAdı.Text = _databaseTransactions._patients[i].BabaAdi;
                    textBox_AnneAdı.Text = _databaseTransactions._patients[i].AnneAdi;
                    dateTimePicker_DogumTarihi.Text = _databaseTransactions._patients[i].DogumTarihi.ToLongDateString();
                    richTextBox_Adres.Text = _databaseTransactions._patients[i].Adres;
                    textBox_TelefonNo.Text = _databaseTransactions._patients[i].CepTel.ToString();
                    textBox_YakinTelefonNo.Text = _databaseTransactions._patients[i].YakınTel.ToString();
                    textBox_KurumSicilNo.Text = _databaseTransactions._patients[i].KurumSicilNo.ToString();
                    textBox_KurumSicilNoTwo.Text = _databaseTransactions._patients[i].YakınKurumSicilNo.ToString();
                    textBox_KurumAdı.Text = _databaseTransactions._patients[i].KurumAdi;
                    textBox_KurumAdıTwo.Text = _databaseTransactions._patients[i].YakınKurumAdi;
                    comboBox_Cinsiyet.Text = _databaseTransactions._patients[i].Cinsiyet.ToString();
                    comboBox_KanGrubu.Text = _databaseTransactions._patients[i].KanGrubu.ToString();
                    comboBox_MedeniHali.Text = _databaseTransactions._patients[i].MedeniHali.ToString();
                }
            }
        }

        private void HastaBilgileri_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            if (String.IsNullOrEmpty(textBox_DosyaNo.Text))
            {
                textBox_DosyaNo.Enabled = true;                
            }
            else
            {
                textBox_DosyaNo.Enabled = false;                
            }
            if (String.IsNullOrEmpty(maskedTextBox_TCKimlikNo.Text))
            {
                button_Güncelle.Enabled = false;
            }
            if(!(String.IsNullOrEmpty(maskedTextBox_TCKimlikNo.Text)))
            {
                button_Kaydet.Enabled = false;
            }
        }

        private void button_Cıkıs_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Kaydet_Click(object sender, EventArgs e)
        {
            Boolean Bulma = false;
            if (!(String.IsNullOrEmpty(maskedTextBox_TCKimlikNo.Text)))
            {
                _databaseTransactions.GetALLPatient();
                for (int i = 0; i < _databaseTransactions._patients.Count; i++)
                {
                    if (_databaseTransactions._patients[i].TC == maskedTextBox_TCKimlikNo.Text.ToString())
                    {
                        Bulma = true;
                        MessageBox.Show("Böyle bir hasta zaten bulunmaktadır", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        maskedTextBox_TCKimlikNo.Text = "";
                    }
                }
                if (Bulma==false)
                {
                    Patient patient = new Patient
                    {
                        TC = maskedTextBox_TCKimlikNo.Text.ToString(),
                        Ad = textBox_Ad.Text,
                        Soyad = textBox_Soyad.Text,
                        DogumTarihi = Convert.ToDateTime(dateTimePicker_DogumTarihi.Text),
                        DogumYeri = textBox_DogumYeri.Text,
                        BabaAdi = textBox_BabaAdı.Text,
                        AnneAdi = textBox_AnneAdı.Text,
                        Adres = richTextBox_Adres.Text,
                        CepTel = Convert.ToDecimal(textBox_TelefonNo.Text),
                        KurumSicilNo = Convert.ToInt32(textBox_KurumSicilNo.Text),
                        KurumAdi = textBox_KurumAdı.Text,
                        YakınTel = Convert.ToDecimal(textBox_YakinTelefonNo.Text),
                        YakınKurumSicilNo = Convert.ToInt32(textBox_KurumSicilNoTwo.Text),
                        YakınKurumAdi = textBox_KurumAdıTwo.Text,
                        Cinsiyet=comboBox_Cinsiyet.Text.ToString(),
                        MedeniHali=comboBox_MedeniHali.Text.ToString(),
                        KanGrubu=comboBox_KanGrubu.Text.ToString()
                    };                   
                    _databaseTransactions.NewPatientInformationSave(patient);
                    MessageBox.Show("Kaydetme işlemi tamamlandı", "Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button_Yeni_Click(object sender, EventArgs e)
        {
            _databaseTransactions.GetALLPatient();
            int DataNumber = _databaseTransactions._patients.Count;
            int EnBüyükDeger = Convert.ToInt32(_databaseTransactions._patients[0].DosyaNo);
            for (int i = 0; i < _databaseTransactions._patients.Count; i++)
            {
                if (Convert.ToInt32(_databaseTransactions._patients[i].DosyaNo) > EnBüyükDeger)
                {
                    EnBüyükDeger = Convert.ToInt32(_databaseTransactions._patients[i].DosyaNo);
                }
            }
            string NewFilesNumber = (EnBüyükDeger + 1).ToString();
            textBox_DosyaNo.Text = NewFilesNumber;
            textBox_Ad.Text = "";
            textBox_AnneAdı.Text = "";
            textBox_BabaAdı.Text = "";
            textBox_DogumYeri.Text = "";
            textBox_KurumAdı.Text = "";
            textBox_KurumAdıTwo.Text = "";
            textBox_KurumSicilNo.Text = "";
            textBox_KurumSicilNoTwo.Text = "";
            textBox_Soyad.Text = "";
            textBox_TelefonNo.Text = "";
            textBox_YakinTelefonNo.Text = "";
            comboBox_Cinsiyet.Text = "";
            comboBox_KanGrubu.Text = "";
            comboBox_MedeniHali.Text = "";
            richTextBox_Adres.Text = "";
            maskedTextBox_TCKimlikNo.Text = "";
            dateTimePicker_DogumTarihi.Text = "";

        }

        private void button_Güncelle_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(maskedTextBox_TCKimlikNo.Text)))
            {
                Patient patient = new Patient
                {
                    Ad = textBox_Ad.Text.ToString(),
                    Soyad = textBox_Soyad.Text.ToString(),
                    TC = maskedTextBox_TCKimlikNo.Text,
                    DogumYeri = textBox_DogumYeri.Text.ToString(),
                    BabaAdi = textBox_BabaAdı.Text.ToString(),
                    AnneAdi = textBox_AnneAdı.Text.ToString(),
                    DogumTarihi = Convert.ToDateTime(dateTimePicker_DogumTarihi.Text),
                    Adres = richTextBox_Adres.Text,
                    CepTel = Convert.ToDecimal(textBox_TelefonNo.Text),
                    YakınTel = Convert.ToDecimal(textBox_YakinTelefonNo.Text),
                    KurumSicilNo = Convert.ToInt32(textBox_KurumSicilNo.Text),
                    KurumAdi = textBox_KurumAdı.Text.ToString(),
                    YakınKurumSicilNo = Convert.ToInt32(textBox_KurumSicilNoTwo.Text),
                    YakınKurumAdi = textBox_KurumAdıTwo.Text.ToString(),
                    DosyaNo = textBox_DosyaNo.Text.ToString(),
                    Cinsiyet=comboBox_Cinsiyet.Text.ToString(),
                    MedeniHali=comboBox_MedeniHali.Text.ToString(),
                    KanGrubu=comboBox_KanGrubu.Text.ToString()
                };
                _databaseTransactions.SavePatient(patient);
                label_Bilgilendirme.Text = "<Güncelleme işlemi başarılı>";
            }
            else
            {
                MessageBox.Show("Kişi bilgileri için TC no gerekmektedir!", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

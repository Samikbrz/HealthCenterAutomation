using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.IO;
using System.Diagnostics;
using DGVPrinterHelper;

namespace SaglıkOcagıOtomasyonu
{
    public partial class Hasta_İslemleri : Form
    {
        private DatabaseTransactions _databaseTransactions = new DatabaseTransactions();

        int id, Toplam;
        public Hasta_İslemleri()
        {
            InitializeComponent();
        }

        private void Hasta_İslemleri_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            _databaseTransactions.GetAllSevk();
            SiraNo();
            YapılanIslem();           
        }

        public void SiraNo()
        {            
            int EnBuyuk = _databaseTransactions._sevks[0].Sira;
            for (int i = 0; i < _databaseTransactions._sevks.Count; i++)
            {
                if (_databaseTransactions._sevks[i].Sira>EnBuyuk)
                {
                    EnBuyuk = _databaseTransactions._sevks[i].Sira;
                }
            }
            textBox_SıraNo.Text = (EnBuyuk + 1).ToString();
        }

        public void YapılanIslem()
        {
            _databaseTransactions.GetAllOperationAndPrice();            
            for (int i = 0; i < _databaseTransactions._operations.Count; i++)
            {
                comboBox_YapılanIslemler.Items.Add(_databaseTransactions._operations[i].IslemAdi);                
            }
        }     
        
        public void BeforeOperationDates()
        {
            comboBox_OncekiIslemler.Items.Clear();            
            for (int i = 0; i < _databaseTransactions._sevks.Count; i++)
            {
                if (_databaseTransactions._sevks[i].TCKimlikNo == textBox_TCKimlikNo.Text)
                {
                    comboBox_OncekiIslemler.Items.Add(_databaseTransactions._sevks[i].SevkTarihi.ToShortDateString());
                }
            }
        }

        public void ToplamTutarHesapla(DateTime date)
        {
            Toplam = 0;            
            for (int i = 0; i < _databaseTransactions._sevks.Count; i++)
            {
                if (date==_databaseTransactions._sevks[i].SevkTarihi)
                {
                    Toplam = Toplam + (_databaseTransactions._sevks[i].Miktar)*(_databaseTransactions._sevks[i].BirimFiyat);
                }                   
            }
            label_ToplamTutar.Text = Toplam.ToString();            
        }

        private void DataGridViewSorgu()
        {
            dataGridView_YapilanTahlilVeIslemler.DataSource = _databaseTransactions._sevks.ToList();
        }

        private void button_Cıkıs_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ClearData()
        {
            comboBox_Poliklinik.Text = "";
            textBox_SıraNo.Text = "";
            comboBox_YapılanIslemler.Text = "";
            comboBox__Miktar.Text = "";
            textBox_BirimFiyat.Text = "";
            comboBox_DrKodu.Text = "";
        }

        private void button_Ekle_Click(object sender, EventArgs e)
        {
            Boolean Bulma = false;
            if (String.IsNullOrEmpty(comboBox_Poliklinik.Text.ToString()) || String.IsNullOrEmpty(comboBox_YapılanIslemler.Text.ToString())
                || String.IsNullOrEmpty(textBox_BirimFiyat.Text) || String.IsNullOrEmpty(comboBox__Miktar.Text) || String.IsNullOrEmpty(textBox_SıraNo.Text) ||
                String.IsNullOrEmpty(comboBox_DrKodu.Text))
            {
                MessageBox.Show("Ekleme için gerekli yerleri doldurunuz", "İSLEM HATASI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for (int i = 0; i < _databaseTransactions._sevks.Count; i++)
                {
                    if (_databaseTransactions._sevks[i].Sira == Convert.ToInt32(textBox_SıraNo.Text))
                    {
                        Bulma = true;
                        MessageBox.Show("Bu sıradaya sahip farklı kişi bulunmaktadır farklı bir numara giriniz!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (Bulma==false)
                {
                    DateTime zaman = DateTime.Now;
                    string DosyaNumarası="";
                    for (int i = 0; i < _databaseTransactions._sevks.Count; i++)
                    {
                        if (_databaseTransactions._sevks[i].TCKimlikNo==textBox_TCKimlikNo.Text)
                        {
                            DosyaNumarası = (_databaseTransactions._sevks[i].DosyaNo);
                        }
                    }
                    _databaseTransactions.AddSevk(new Sevk
                    {
                        SevkTarihi=Convert.ToDateTime(dateTimePicker_SevkTarihi.Text),
                        ToplamTutar=Convert.ToInt32(label_ToplamTutar.Text),
                        TCKimlikNo = textBox_TCKimlikNo.Text,
                        Saat = Convert.ToDateTime(zaman.ToShortTimeString()),
                        Poliklinik = comboBox_Poliklinik.Text,
                        Sira = Convert.ToInt32(textBox_SıraNo.Text),
                        YapılanIslem = comboBox_YapılanIslemler.Text,
                        DrKodu = comboBox__Miktar.Text,
                        BirimFiyat = Convert.ToInt32(textBox_BirimFiyat.Text),
                        Miktar=Convert.ToInt32(comboBox__Miktar.Text),
                        DosyaNo= DosyaNumarası.ToString(),
                    });
                    MessageBox.Show("Ekleme tamamlandı", "COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearData();                    
                }
                SiraNo();
            }            
        }

        private void button_Bul_Click(object sender, EventArgs e)
        {
            comboBox_OncekiIslemler.Items.Clear();
            if (String.IsNullOrEmpty(textBox_TCKimlikNo.Text))
            {
                DosyaBul dosyaBul = new DosyaBul();
                dosyaBul.StartPosition = FormStartPosition.CenterScreen;
                dosyaBul.Show();
            }
            else
            {
                BeforeOperationDates();
                _databaseTransactions.GetALLPatient();                
                _databaseTransactions.SearchWithTC(textBox_TCKimlikNo.Text.ToString());
                for (int i = 0; i < _databaseTransactions._patients.Count; i++)
                {
                    if (_databaseTransactions._patients[i].TC == textBox_TCKimlikNo.Text)
                    {
                        textBox_HastaAdi.Text = _databaseTransactions._patients[i].Ad;
                        textBox_Soyadi.Text = _databaseTransactions._patients[i].Soyad;
                        textBox_KurumAdi.Text = _databaseTransactions._patients[i].KurumAdi;                        
                    }                    
                }
                _databaseTransactions.GetAllExit();
                for (int i = 0; i < _databaseTransactions._exits.Count; i++)
                {
                    if (_databaseTransactions._exits[i].TC==textBox_TCKimlikNo.Text)
                    {
                        //dateTimePicker_SevkTarihi.Text = _databaseTransactions._exits[i].SevkTarihi.ToLongDateString();
                    }
                }
            }            
        }

        private void button_Taburcu_Click(object sender, EventArgs e)
        {
            bool Bulma = false;
            _databaseTransactions.GetAllExit();
            if (!(String.IsNullOrEmpty(textBox_TCKimlikNo.Text)))
            {
                for (int i = 0; i < _databaseTransactions._exits.Count; i++)
                {
                    if (_databaseTransactions._exits[i].TC ==textBox_TCKimlikNo.Text)
                    {
                        Bulma = true;
                        MessageBox.Show("Bu hasta zaten sevk edilmiş", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }                            
                }
                if (Bulma==false)
                {
                    Sevk sevk = new Sevk
                    {
                        DosyaNo = textBox_TCKimlikNo.Text,
                        ToplamTutar = Toplam,
                    };
                    Taburcu taburcu = new Taburcu(sevk);
                    taburcu.ShowDialog();
                }               
            }
            else
            {
                MessageBox.Show("Lütfen TC kimlik numarasını giriniz!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }        
        private void button_BaskıOnizleme_Click(object sender, EventArgs e)
        {              
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Hasta Sevk İşlemleri: " + textBox_HastaAdi.Text +" "+ textBox_Soyadi.Text;            
            printer.TitleFont= new Font("Tahoma", 12, FontStyle.Bold, GraphicsUnit.Point);
            printer.TableAlignment = DGVPrinter.Alignment.Center;
            printer.Footer = GetSignatureFooter(Convert.ToInt32(label_ToplamTutar.Text));            
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.FooterSpacing = 15;            
            printer.PrintDataGridView(dataGridView_YapilanTahlilVeIslemler);          
            printer
        }
        private string GetSignatureFooter(int ToplamTutar)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Toplam Tutar: "+ToplamTutar.ToString()+"TL");             
            return sb.ToString();
        }
        private void printDocumnet1_PrintPage(object sender, PrintPageEventArgs e)
        {
            
        }

        private void dataGridView_YapilanTahlilVeIslemler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_Yeni_Click(object sender, EventArgs e)
        {
            _databaseTransactions.GetALLPatient();
            int DataNumber = _databaseTransactions._patients.Count;
            int EnBüyükDeger =Convert.ToInt32(_databaseTransactions._patients[0].DosyaNo);
            for (int i = 0; i < _databaseTransactions._patients.Count; i++)
            {
                if (Convert.ToInt32(_databaseTransactions._patients[i].DosyaNo)>EnBüyükDeger)
                {
                    EnBüyükDeger = Convert.ToInt32(_databaseTransactions._patients[i].DosyaNo);
                }
            }
            string NewFilesNumber = (EnBüyükDeger + 1).ToString();
            HastaBilgileri hastaBilgileri = new HastaBilgileri(NewFilesNumber);
            hastaBilgileri.ShowDialog();
        }

        private void button_SecSel_Click(object sender, EventArgs e)
        {
            if (id == 1)
            {
                id = Convert.ToInt32(dataGridView_YapilanTahlilVeIslemler.CurrentRow.Cells[0].Value);
                _databaseTransactions.DeleteSevk(id);
                MessageBox.Show("Hasta silindi.", "DELETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataGridViewSorgu();
            }
            else
            {
                MessageBox.Show("Lütfen seçim yapınız", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }       

        private void comboBox_YapılanIslemler_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Islem = comboBox_YapılanIslemler.Text.ToString();
            for (int i = 0; i < _databaseTransactions._operations.Count; i++)
            {                
                if (Islem == _databaseTransactions._operations[i].IslemAdi)
                {
                    textBox_BirimFiyat.Text = _databaseTransactions._operations[i].BirimFiyat.ToString();
                }
            }
        }

        private void button_HastaBilgileri_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(textBox_TCKimlikNo.Text)))
            {
                Patient patient = new Patient
                {
                    TC = textBox_TCKimlikNo.Text,
                };
                HastaBilgileri hastaBilgileri = new HastaBilgileri(patient);
                hastaBilgileri.Show();
            }
            else
            {
                MessageBox.Show("Lütfen hastanın TC kimlik numarasını giriniz!", "TC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_Git_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(comboBox_OncekiIslemler.Text)))
            {
                dataGridView_YapilanTahlilVeIslemler.DataSource = null;
                var result = _databaseTransactions.GetAllSevkSearch().Where(p => p.SevkTarihi.ToShortDateString().Contains(comboBox_OncekiIslemler.Text)).ToList();
                dataGridView_YapilanTahlilVeIslemler.DataSource = result;
                ToplamTutarHesapla(Convert.ToDateTime(comboBox_OncekiIslemler.Text));
            }
            if (dataGridView_YapilanTahlilVeIslemler.DataSource!=null)
            {
                dataGridView_YapilanTahlilVeIslemler.Columns["DosyaNo"].Visible = false;
                dataGridView_YapilanTahlilVeIslemler.Columns["ID"].Visible = false;
                dataGridView_YapilanTahlilVeIslemler.Columns["ToplamTutar"].Visible = false;
                dataGridView_YapilanTahlilVeIslemler.Columns["TCKimlikNo"].Visible = false;
                dataGridView_YapilanTahlilVeIslemler.Columns["SevkTarihi"].Visible = false;                
                dataGridView_YapilanTahlilVeIslemler.Columns["Taburcu"].Visible = false;
            }                     
        }

        private void button_Yazdır_Click(object sender, EventArgs e)
        {
            var dlg = new PrintDialog();
            dlg.ShowDialog();
        }

        private void dataGridView_YapilanTahlilVeIslemler_CellClick(object sender, DataGridViewCellEventArgs e)
        {            
            id = 1;            
        }
    }
}

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
    public partial class DosyaBul : Form
    {
        DatabaseTransactions _databaseTransactions = new DatabaseTransactions();
        public DosyaBul()
        {
            InitializeComponent();
        }

        //var result = _databaseTransactions.GetAllSevkSearch().Where(p => p.taburcu.ToLower().Contains("Taburcu Oldu".ToLower())).ToList();
        //dataGridView_TaburcuBilgileri.DataSource = result;

        private void button_Bul_Click(object sender, EventArgs e)
        {            
            if (!(String.IsNullOrEmpty(comboBox_AramaKriterleri.Text)))
            {
                _databaseTransactions.GetALLPatientSearch();
                if (comboBox_AramaKriterleri.Text=="Dosya No")
                {
                    dataGridView_AramaSonucları.DataSource = null;
                    var result = _databaseTransactions.GetALLPatientSearch().Where(p => p.DosyaNo.ToLower().Contains(textBox_AramaKriteri.Text.ToLower())).ToList();
                    dataGridView_AramaSonucları.DataSource = result;
                }
                else if (comboBox_AramaKriterleri.Text=="Hasta Adı Soyadı")
                {
                    dataGridView_AramaSonucları.DataSource = null;
                    var result = _databaseTransactions.GetALLPatientSearch().Where(p => p.Ad.ToLower().Contains(textBox_AramaKriteri.Text.ToLower())).ToList();
                    dataGridView_AramaSonucları.DataSource = result;
                }
                else if (comboBox_AramaKriterleri.Text=="Kurum Sicil No")
                {
                    dataGridView_AramaSonucları.DataSource = null;
                    var result = _databaseTransactions.GetALLPatientSearch().Where(p => p.KurumSicilNo.ToString().Contains(textBox_AramaKriteri.Text.ToLower())).ToList();
                    dataGridView_AramaSonucları.DataSource = result;
                }
            }
            else
            {
                MessageBox.Show("Lütfen arama kriterini giriniz!!!", "Eksik veri", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            comboBox_AramaKriterleri.Text = "";
        }

        private void DosyaBul_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }

        private void comboBox_AramaKriterleri_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_AramaKriterleri.Text=="Dosya No")
            {
                checkBox_Ve.Visible = false;
                label_Ve.Visible = false;
                textBox_AramaKriteriTwo.Visible = false;
                textBox_AramaKriteri.Width = 230;
            }
            else if (comboBox_AramaKriterleri.Text=="Kurum Sicil No")
            {
                checkBox_Ve.Visible = false;
                label_Ve.Visible = false;
                textBox_AramaKriteriTwo.Visible = false;
                textBox_AramaKriteri.Width = 230;
            }
            else if (comboBox_AramaKriterleri.Text=="Hasta Adı Soyadı")
            {
                checkBox_Ve.Visible = true;
                label_Ve.Visible = true;
                textBox_AramaKriteriTwo.Visible = true;
                textBox_AramaKriteri.Width = 80;
            }
        }
    }
}

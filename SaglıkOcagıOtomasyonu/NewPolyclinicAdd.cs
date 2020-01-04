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
    public partial class NewPolyclinicAdd : Form
    {
        DatabaseTransactions _databaseTransactions = new DatabaseTransactions();
        public NewPolyclinicAdd()
        {
            InitializeComponent();
        }

        private void NewPolyclinicAdd_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void button_Ekle_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(textBox_PoliklinikAdi.Text)) && !(String.IsNullOrEmpty(richTextBox_Acıklama.Text)))
            {
                _databaseTransactions.GetAllPoliklinikInformation();
                bool Bulma = false;
                for (int i = 0; i < _databaseTransactions._polikliniks.Count; i++)
                {
                    if (_databaseTransactions._polikliniks[i].PoliklinikAdi==textBox_PoliklinikAdi.Text)
                    {
                        Bulma = true;
                        MessageBox.Show("Bu poliklinik zaten mevcut!","Poliklinik mevcut", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (Bulma==false)
                {
                    Poliklinik poliklinik = new Poliklinik
                    {
                        PoliklinikAdi = textBox_PoliklinikAdi.Text,
                        Acıklama = richTextBox_Acıklama.Text,
                    };
                    if (checkBox_Gecerlilik.Checked == true)
                    {
                        poliklinik.Durum = "true";
                    }
                    else
                    {
                        poliklinik.Durum = "false";
                    }
                    DatabaseTransactions databaseTransactions = new DatabaseTransactions();
                    databaseTransactions.AddNewPolylinic(poliklinik);
                }                
            }
            else
            {
                MessageBox.Show("Lütfen tüm  boş alanları eksiksiz doldurunuz!!!", "EksikVeri", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_Cıkıs_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

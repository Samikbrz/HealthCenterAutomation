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
    public partial class PoliklinikForm : Form
    {
        private DatabaseTransactions _databaseTransactions = new DatabaseTransactions();
        int ID;
        public PoliklinikForm()
        {
            InitializeComponent();
        }

        public PoliklinikForm(string Value,bool ValueTwo)
        {
            InitializeComponent();
            textBox_PoliklinikAdi.Text = Value;
            checkBox_Gecerlilik.Checked = ValueTwo;            
        }        
       
        private void Poliklinik_Load(object sender, EventArgs e)
        {
            textBox_PoliklinikAdi.Enabled = false;
            checkBox_Gecerlilik.Enabled = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            _databaseTransactions.GetAllPoliklinikInformation();
            for (int i = 0; i < _databaseTransactions._polikliniks.Count; i++)
            {
                if (textBox_PoliklinikAdi.Text==_databaseTransactions._polikliniks[i].PoliklinikAdi)
                {
                    richTextBox_Acıklama.Text = _databaseTransactions._polikliniks[i].Acıklama.ToString();
                    ID = _databaseTransactions._polikliniks[i].ID;
                }
            }           
        }
        private void textBox_PoliklinikAdi_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button_Guncelle_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(textBox_PoliklinikAdi.Text)))
            {
                Poliklinik poliklinik = new Poliklinik
                {
                    PoliklinikAdi = textBox_PoliklinikAdi.Text,
                    Acıklama = richTextBox_Acıklama.Text.ToString(),
                    Durum=checkBox_Gecerlilik.Checked.ToString(),
                    ID = ID
                };
                _databaseTransactions.UpdatePolikliniks(poliklinik);
                MessageBox.Show("Güncelleme tamamlandı", "TAMAMLANDI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }            
        }

        private void button__Sil_Click(object sender, EventArgs e)
        {
            _databaseTransactions.DeletePoliklinik(ID);
            textBox_PoliklinikAdi.Text = "";
            richTextBox_Acıklama.Text = "";
            this.Close();
        }

        private void button_Cıkıs_Click(object sender, EventArgs e)
        {
            this.Close();
        }       
    }
}

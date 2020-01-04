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
    public partial class Taburcu : Form
    {
        DatabaseTransactions _databaseTransactions = new DatabaseTransactions();
        public Taburcu()
        {
            InitializeComponent();
        }

        public Taburcu(Sevk sevk)
        {
            InitializeComponent();
            textBox_TCKimlikNo.Text = sevk.DosyaNo.ToString();
            textBox_ToplamTutar.Text = sevk.BirimFiyat.ToString();            
        }     

        private void Taburcu_Load(object sender, EventArgs e)
        {
            textBox_TCKimlikNo.Enabled = false;
            textBox_ToplamTutar.Enabled = false;
            dateTimePicker_SevkTarihi.Enabled = false;
            dateTimePicker_CıkısTarihi.Enabled = false;
        }

        private void button_Kaydet_Click(object sender, EventArgs e)
        {
            DateTime zaman = DateTime.Now;
            Exit exits = new Exit
            {
                TC=textBox_TCKimlikNo.Text.ToString(),
                SevkTarihi=Convert.ToDateTime(dateTimePicker_SevkTarihi.Text),
                CıkısTarihi=Convert.ToDateTime(zaman.ToShortTimeString()),
                Odeme=comboBox_OdemeSekli.Text.ToString(),
                ToplamTutar=Convert.ToDecimal(textBox_ToplamTutar.Text)
            };
            _databaseTransactions.ExitSave(exits);
        }

        private void button_Vazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

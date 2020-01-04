using DGVPrinterHelper;
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
    public partial class Raporlama : Form
    {
        DatabaseTransactions _databaseTransactions = new DatabaseTransactions();        
        public Raporlama()
        {
            InitializeComponent();
        }

        private void button_Cıkıs_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Raporlama_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            Tarihler();
        }

        public void Tarihler()
        {
            _databaseTransactions.GetAllSevk();
            for (int i = 0; i < _databaseTransactions._sevks.Count; i++)
            {
                comboBox_BaslagıcTarihi.Items.Add(_databaseTransactions._sevks[i].SevkTarihi);
                comboBox_BitisTarihi.Items.Add(_databaseTransactions._sevks[i].SevkTarihi);
            }
        }
        //Tarhiler ve taburcu olmuş
        //Tarihler ve taburcu olmamış
        //Hepsi

        private void button_Sorgula_Click(object sender, EventArgs e)
        {        
            if (!(String.IsNullOrEmpty(comboBox_BaslagıcTarihi.Text)) && !(String.IsNullOrEmpty(comboBox_BitisTarihi.Text)) && (radioButton_TaburcuOlmus.Checked == true))
            {
                dataGridView_TaburcuBilgileri.DataSource = null;
                DateTime Baslangıc = Convert.ToDateTime(comboBox_BaslagıcTarihi.Text);
                DateTime Bitis = Convert.ToDateTime(comboBox_BitisTarihi.Text);
                var result = _databaseTransactions.GetAllSevkSearch().Where(p => p.taburcu.Contains("Taburcu Oldu") && p.SevkTarihi >= Baslangıc && p.SevkTarihi <= Bitis).ToList();
                dataGridView_TaburcuBilgileri.DataSource = result;
            }
            else if (!(String.IsNullOrEmpty(comboBox_BaslagıcTarihi.Text)) && !(String.IsNullOrEmpty(comboBox_BitisTarihi.Text)) && (radioButton_TaburcuOlmamıs.Checked == true))
            {
                dataGridView_TaburcuBilgileri.DataSource = null;
                DateTime Baslangıc = Convert.ToDateTime(comboBox_BaslagıcTarihi.Text);
                DateTime Bitis = Convert.ToDateTime(comboBox_BitisTarihi.Text);
                var result = _databaseTransactions.GetAllSevkSearch().Where(p => p.taburcu.Contains("Taburcu Olmadı") && p.SevkTarihi >= Baslangıc && p.SevkTarihi <= Bitis).ToList();
                dataGridView_TaburcuBilgileri.DataSource = result;
            }
            else if (!(String.IsNullOrEmpty(comboBox_BaslagıcTarihi.Text)) && !(String.IsNullOrEmpty(comboBox_BitisTarihi.Text)))
            {
                dataGridView_TaburcuBilgileri.DataSource = null;
                TarihİleAra(Convert.ToDateTime(comboBox_BaslagıcTarihi.Text), Convert.ToDateTime(comboBox_BitisTarihi.Text));
            }
            else if (radioButton_Hepsi.Checked == true)
            {
                dataGridView_TaburcuBilgileri.DataSource = null;
                dataGridView_TaburcuBilgileri.DataSource = _databaseTransactions.GetAllSevkSearch();
            }
            else if (radioButton_TaburcuOlmus.Checked == true)
            {
                dataGridView_TaburcuBilgileri.DataSource = null;
                var result = _databaseTransactions.GetAllSevkSearch().Where(p => p.taburcu.Contains("Taburcu Oldu")).ToList();
                dataGridView_TaburcuBilgileri.DataSource = result;
            }
            else if (radioButton_TaburcuOlmamıs.Checked == true)
            {
                dataGridView_TaburcuBilgileri.DataSource = null;
                var result = _databaseTransactions.GetAllSevkSearch().Where(p => p.taburcu.Contains("Taburcu Olmadı")).ToList();
                dataGridView_TaburcuBilgileri.DataSource = result;
            }            
            else
            {
                MessageBox.Show("Aramak istediğiniz tarih aralıklarını seçiniz!", "Eksik veri", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dataGridView_TaburcuBilgileri.Columns["ID"].Visible = false;            
        }

        public void TarihİleAra(DateTime Baslangıc,DateTime Bitis)
        {
            var result = _databaseTransactions.GetAllSevkSearch().Where(p => p.SevkTarihi >= Baslangıc && p.SevkTarihi <= Bitis).ToList();
            dataGridView_TaburcuBilgileri.DataSource = result;
        }

        private void button_Temizle_Click(object sender, EventArgs e)
        {
            comboBox_BaslagıcTarihi.Text = "";
            comboBox_BitisTarihi.Text = "";
            radioButton_Hepsi.Checked =false;
            radioButton_TaburcuOlmamıs.Checked = false;
            radioButton_TaburcuOlmus.Checked = false;
            dataGridView_TaburcuBilgileri.DataSource = null;
        }

        private void button_Yazdır_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Rapor İşlemleri ";
            printer.TitleFont = new Font("Tahoma", 14, FontStyle.Bold, GraphicsUnit.Point);
            printer.TableAlignment = DGVPrinter.Alignment.Center;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.FooterSpacing = 10;
            printer.PrintDataGridView(dataGridView_TaburcuBilgileri);
        }
    }
}

using HEYS.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using Workbook = Microsoft.Office.Interop.Excel.Workbook;

namespace HEYS
{
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }
        DbHEYSEntities db = new DbHEYSEntities();

        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            EnvanterListele();
            txtAramaIsim.Text = "Ara";
            txtAramaSoyisim.Text = "Ara";
        }
        public void EnvanterListele()
        {
            dataGridPersonel.DataSource = db.TBLPersonel.ToList();
            dataGridPersonel.Columns[9].Visible = false;
            dataGridPersonel.Columns[10].Visible = false;
            lblPersonelSayisi.Text = Convert.ToString(dataGridPersonel.RowCount);
            var sorgu = from p in db.TBLPersonel
                        where p.BagliEnvanter != null
                        select p;
            int a = 0;
            if (sorgu.Any())
            {
                for (int i = 0; i < sorgu.Count(); i++)
                {
                    a++;
                }
                lblEnvanterSayisi.Text = Convert.ToString(a);
            }
        }
        public void DeletePersonel(int id)
        {
            var sorgu = db.TBLPersonel.Find(id);
            db.TBLPersonel.Remove(sorgu);
            db.SaveChanges();
            MessageBox.Show(id + "Nolu Personel Silindi. ");
        }
        private void btnCikis_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmMenu frmMenu = new FrmMenu();
            this.Hide();
            frmMenu.Show();
        }
        private void txtAramaIsim_Click(object sender, EventArgs e)
        {
            if (txtAramaIsim.Text == "Ara")
            {
                txtAramaIsim.Text = "";
            }
        }

        private void txtAramaIsim_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAramaIsim.Text))
            {
                txtAramaIsim.Text = "Ara";
            }
        }
        private void txtAramaSoyisim_Click(object sender, EventArgs e)
        {
            if (txtAramaSoyisim.Text == "Ara")
            {
                txtAramaSoyisim.Text = "";
            }
        }
        private void txtAramaSoyisim_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAramaSoyisim.Text))
            {
                txtAramaSoyisim.Text = "Ara";
            }
        }
        private void btnAra_Click(object sender, EventArgs e)
        {
            dataGridPersonel.DataSource = db.TBLPersonel.Where(x => x.Ad == txtAramaIsim.Text & x.Soyad == txtAramaSoyisim.Text).ToList();
        }
        private void btnEnvanterSirala_Click(object sender, EventArgs e)
        {
            if (rbtnAdaGore.Checked == true)
            {
                List<TBLPersonel> liste1 = db.TBLPersonel.OrderBy(p => p.Ad).ToList();
                dataGridPersonel.DataSource = liste1;
            }
            if (rbtnAdaGoreTers.Checked == true)
            {
                List<TBLPersonel> liste2 = db.TBLPersonel.OrderByDescending(p => p.Ad).ToList();
                dataGridPersonel.DataSource = liste2;
            }
            if (rbtnSoyadaGore.Checked == true)
            {
                List<TBLPersonel> liste3 = db.TBLPersonel.OrderBy(p => p.Soyad).ToList();
                dataGridPersonel.DataSource = liste3;
            }
            if (rbtnSoyadaGoreTers.Checked == true)
            {
                List<TBLPersonel> liste4 = db.TBLPersonel.OrderByDescending(p => p.Soyad).ToList();
                dataGridPersonel.DataSource = liste4;
            }
        }
        private void btnSiralaYenile_Click(object sender, EventArgs e)
        {
            EnvanterListele();
        }
        private void btnExcel_Click(object sender, EventArgs e)
        {
            Excel.Application excel = new Excel.Application();
            excel.Visible = true;
            object Missing = Type.Missing;
            Workbook workbook = excel.Workbooks.Add(Missing);
            Worksheet sheet1 = (Worksheet)workbook.Sheets[1];
            int StartCol = 0;
            int StartRow = 1;
            for (int j = 1; j < dataGridPersonel.Columns.Count - 2; j++)
            {
                Range myRange = (Range)sheet1.Cells[StartRow, StartCol + j];
                myRange.Value2 = dataGridPersonel.Columns[j].HeaderText;
            }
            StartRow++;
            for (int i = 0; i < dataGridPersonel.Rows.Count; i++)
            {
                for (int j = 1; j < dataGridPersonel.Columns.Count - 2; j++)
                {
                    Range myRange = (Range)sheet1.Cells[StartRow + i, StartCol + j];
                    myRange.Value2 = dataGridPersonel[j, i].Value == null ? " " : dataGridPersonel[j, i].Value;
                    myRange.Select();
                }
            }
        }
        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            try
            {
                TBLPersonel Personel = new TBLPersonel();
                Personel.Ad = tbAd.Text;
                Personel.Soyad = tbSoyad.Text;
                Personel.TC = tbTC.Text;
                Personel.Mail = tbMail.Text;
                Personel.Bolum = Convert.ToInt32(tbBolum.Text);
                Personel.Birim = tbBirim.Text;
                db.TBLPersonel.Add(Personel);
                db.SaveChanges();
                MessageBox.Show("Eklendi!");
                EnvanterListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata!" + ex.Message);

            }
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            tbAd.Text = "";
            tbSoyad.Text = "";
            tbTC.Text = "";
            tbMail.Text = "";
            tbBolum.Text = "";
            tbBirim.Text = "";
        }

        private void dataGridPersonel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                int id = Convert.ToInt32(dataGridPersonel.CurrentRow.Cells[1].Value.ToString());
                DeletePersonel(id);
                EnvanterListele();   
            }
        }
    }
}

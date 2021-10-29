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
    public partial class FrmEnvanter : Form
    {
        public FrmEnvanter()
        {
            InitializeComponent();
        }
        DbHEYSEntities db = new DbHEYSEntities();
        private void FrmEnvanter_Load(object sender, EventArgs e)
        {
            EnvanterListele();
            txtArama.Text = "Arama";
        }
        public void EnvanterListele()
        {
            dataGridEnvanter.DataSource = db.TBLEnvanter.ToList();
            dataGridEnvanter.Columns[9].Visible = false;
            dataGridEnvanter.Columns[10].Visible = false;
            dataGridEnvanter.Columns[11].Visible = false;
            dataGridEnvanter.Columns[12].Visible = false;
            var sorgu = from p in db.TBLEnvanter
                        where p.StokDurum != null
                        select p;
            int a = 0;
            if (sorgu.Any())
            {
                foreach (var p in sorgu)
                {
                    a += p.StokDurum.Value;
                }
                lblToplamStok.Text = Convert.ToString(a);
            }
            int g = dataGridEnvanter.RowCount;
            CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dataGridEnvanter.DataSource];
            currencyManager1.SuspendBinding();
            for (int i = 0; i < dataGridEnvanter.Rows.Count; i++)
            {
                if (Convert.ToInt32(dataGridEnvanter.Rows[i].Cells[4].Value) == 0)
                {
                    g--;
                    dataGridEnvanter.Rows[i].Visible = false;
                }
                lblEnvanterSayisi.Text = Convert.ToString(g);
            }
            currencyManager1.ResumeBinding();
        }
        private void btnEnvanterEkle_Click(object sender, EventArgs e)
        {
            try
            {
                TBLEnvanter envanter = new TBLEnvanter();
                envanter.UrunIsmi = tbEnvanterUrunIsim.Text;
                envanter.StokDurum = Convert.ToInt32(tbEnvanterAdet.Text);
                envanter.MalzemeDurum = cbEnvanterMalzemeDurum.SelectedItem.ToString();
                envanter.GirisTarihi = dtpEnvanterTarih.Value;
                envanter.BagliPersonel = tbEnvanterSorumluPersonel.Text;
                envanter.BagliBolum = tbEnvanterSorumluBolum.Text;
                db.TBLEnvanter.Add(envanter);
                db.SaveChanges();
                MessageBox.Show("Eklendi!");
                EnvanterListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("hata!" + ex.Message);
            }
        }
        public void DeleteEnvanter(int id)
        {

            var sorgu = db.TBLEnvanter.Find(id);
            db.TBLEnvanter.Remove(sorgu);
            db.SaveChanges();
            MessageBox.Show(id + "nolu envanter silindi. ");
        }
        private void btnEnvanterTemizle_Click(object sender, EventArgs e)
        {
            tbEnvanterUrunIsim.Text = "";
            tbEnvanterAdet.Text = "";
            tbEnvanterSorumluPersonel.Text = "";
            tbEnvanterSorumluBolum.Text = "";
        }
        public void EnvanterUpdate(int id)
        {
            var x = db.TBLEnvanter.Find(id);
            x.UrunIsmi = tbEnvanterUrunIsim.Text;
            x.StokDurum = Convert.ToInt32(tbEnvanterAdet.Text);
            x.MalzemeDurum = cbEnvanterMalzemeDurum.SelectedItem.ToString();
            x.GirisTarihi = dtpEnvanterTarih.Value;
            x.BagliPersonel = tbEnvanterSorumluPersonel.Text;
            x.BagliBolum = tbEnvanterSorumluBolum.Text;
            db.SaveChanges();
        }
        private void btnArizaGonder_Click(object sender, EventArgs e)
        {
            if (cbArizaBirim.SelectedItem.ToString() == "Teknik Servis")
            {
                int id = Convert.ToInt32(dataGridEnvanter.CurrentRow.Cells[2].Value.ToString());
                var env = db.TBLEnvanter.Find(id);
                TBLTeknikServis teknikServisEkle = new TBLTeknikServis();
                teknikServisEkle.EnvanterId = Convert.ToInt32(env.EnvanterID.ToString());
                teknikServisEkle.UrunIsmi = tbArizaUrunIsim.Text;
                teknikServisEkle.Adet = Convert.ToInt32(tbArizaAdet.Text);
                teknikServisEkle.GelisTarihi = dtpArizaTarih.Value;
                teknikServisEkle.GelisSebebi = tbArizaGonderimSebebi.Text;
                teknikServisEkle.Durum = "Beklemede";
                int a = env.StokDurum.Value - Convert.ToInt32(tbArizaAdet.Text);
                if (a < 0)
                {
                MessageBox.Show("Hata! Ürün Adedi Yanlış.");
                EnvanterListele();
                }
                else
                {
                db.TBLTeknikServis.Add(teknikServisEkle);
                db.SaveChanges();
                env.StokDurum = env.StokDurum.Value - Convert.ToInt32(tbArizaAdet.Text);
                }
                EnvanterListele();
            }
            else if (cbArizaBirim.SelectedItem.ToString() == "Bilgi İşlem")
            {
                int id = Convert.ToInt32(dataGridEnvanter.CurrentRow.Cells[2].Value.ToString());
                var env = db.TBLEnvanter.Find(id);
                TBLBilgiIslem bilgiIslemEkle = new TBLBilgiIslem();
                bilgiIslemEkle.EnvanterId = Convert.ToInt32(env.EnvanterID.ToString());
                bilgiIslemEkle.UrunIsmi = tbArizaUrunIsim.Text;
                bilgiIslemEkle.Adet = Convert.ToInt32(tbArizaAdet.Text);
                bilgiIslemEkle.GirisTarihi = dtpArizaTarih.Value;
                bilgiIslemEkle.GelisSebebi = tbArizaGonderimSebebi.Text;
                bilgiIslemEkle.Durum = "Beklemede";
                int a = env.StokDurum.Value - Convert.ToInt32(tbArizaAdet.Text);
                if (a < 0)
                {
                     MessageBox.Show("Hata! Ürün Adedi Yanlış.");
                     EnvanterListele();
                }
                else
                {
                     db.TBLBilgiIslem.Add(bilgiIslemEkle);
                     db.SaveChanges();
                     env.StokDurum = env.StokDurum.Value - Convert.ToInt32(tbArizaAdet.Text);
                }
                EnvanterListele();
            }
        }
        private void btnArizaTemizle_Click(object sender, EventArgs e)
        {
            tbArizaUrunIsim.Text = "";
            tbArizaAdet.Text = "";
            tbArizaGonderimSebebi.Text = "";
        }

        private void dataGridEnvanter_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                int id = Convert.ToInt32(dataGridEnvanter.CurrentRow.Cells[2].Value.ToString());
                DeleteEnvanter(id);
                EnvanterListele();
                tbArizaUrunIsim.Text = "";
                tbArizaAdet.Text = "";
            }
            if (e.ColumnIndex == 1)
            {
                int id = Convert.ToInt32(dataGridEnvanter.CurrentRow.Cells[2].Value.ToString());
                EnvanterUpdate(id);
            }
            tbArizaUrunIsim.Text = dataGridEnvanter.CurrentRow.Cells[3].Value.ToString();
            tbArizaAdet.Text = dataGridEnvanter.CurrentRow.Cells[4].Value.ToString();
            dtpArizaTarih.Value = (DateTime)dataGridEnvanter.CurrentRow.Cells[6].Value;

            tbEnvanterUrunIsim.Text = dataGridEnvanter.CurrentRow.Cells[3].Value.ToString();
            tbEnvanterAdet.Text = dataGridEnvanter.CurrentRow.Cells[4].Value.ToString();
            cbEnvanterMalzemeDurum.SelectedItem = dataGridEnvanter.CurrentRow.Cells[5].Value.ToString();
            dtpEnvanterTarih.Value = (DateTime)dataGridEnvanter.CurrentRow.Cells[6].Value;
            tbEnvanterSorumluPersonel.Text = dataGridEnvanter.CurrentRow.Cells[7].Value.ToString();
            tbEnvanterSorumluBolum.Text = dataGridEnvanter.CurrentRow.Cells[8].Value.ToString();
        }
        private void btnEnvanterSirala_Click(object sender, EventArgs e)
        {
            if (rbtnAdaGore.Checked == true)
            {
                List<TBLEnvanter> liste1 = db.TBLEnvanter.OrderBy(p => p.UrunIsmi).ToList();
                dataGridEnvanter.DataSource = liste1;
            }
            if (rbtnAdaGoreTers.Checked == true)
            {
                List<TBLEnvanter> liste2 = db.TBLEnvanter.OrderByDescending(p => p.UrunIsmi).ToList();
                dataGridEnvanter.DataSource = liste2;
            }
            if (rbtnArtanStok.Checked == true)
            {
                List<TBLEnvanter> liste3 = db.TBLEnvanter.OrderBy(p => p.StokDurum).ToList();
                dataGridEnvanter.DataSource = liste3;
            }
            if (rbtnAzalanStok.Checked == true)
            {
                List<TBLEnvanter> liste4 = db.TBLEnvanter.OrderByDescending(p => p.StokDurum).ToList();
                dataGridEnvanter.DataSource = liste4;
            }
            if (rbtnTarihYeni.Checked == true)
            {
                List<TBLEnvanter> liste5 = db.TBLEnvanter.OrderBy(p => p.GirisTarihi).ToList();
                dataGridEnvanter.DataSource = liste5;
            }
            if (rbtnTarihEski.Checked == true)
            {
                List<TBLEnvanter> liste6 = db.TBLEnvanter.OrderByDescending(p => p.GirisTarihi).ToList();
                dataGridEnvanter.DataSource = liste6;
            }
        }


        private void btnSiralaYenile_Click(object sender, EventArgs e)
        {
            EnvanterListele();
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
        private void txtArama_Click(object sender, EventArgs e)
        {
            if (txtArama.Text == "Arama")
            {
                txtArama.Text = "";
            }
        }

        private void txtArama_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtArama.Text))
            {
                txtArama.Text = "Arama";
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            dataGridEnvanter.DataSource = db.TBLEnvanter.Where(x => x.UrunIsmi == txtArama.Text).ToList();
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
            for (int j = 1; j < dataGridEnvanter.Columns.Count - 4; j++)
            {
                Range myRange = (Range)sheet1.Cells[StartRow, StartCol + j];
                myRange.Value2 = dataGridEnvanter.Columns[j].HeaderText;
            }
            StartRow++;
            for (int i = 0; i < dataGridEnvanter.Rows.Count; i++)
            {
                for (int j = 1; j < dataGridEnvanter.Columns.Count - 4; j++)
                {
                    Range myRange = (Range)sheet1.Cells[StartRow + i, StartCol + j];
                    myRange.Value2 = dataGridEnvanter[j, i].Value == null ? " " : dataGridEnvanter[j, i].Value;
                    myRange.Select();
                }
            }
        }
    }
}

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

namespace HEYS
{
    public partial class FrmTeknikServis : Form
    {
        public FrmTeknikServis()
        {
            InitializeComponent();
        }
        DbHEYSEntities db = new DbHEYSEntities();
        private void FrmTeknikServis_Load(object sender, EventArgs e)
        {
            EnvanterListele();
            txtArama.Text = "Arama";
        }
        public void EnvanterListele()
        {
            dataGridTeknikServis.DataSource = db.TBLTeknikServis.ToList();
            dataGridTeknikServis.Columns[8].Visible = false;
        }
        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmEnvanter frmEnvanter = new FrmEnvanter();
            this.Hide();
            frmEnvanter.Show();
        }

        private void btnAyarlaraGit_Click(object sender, EventArgs e)
        {
            FrmAyarlar frmAyarlar = new FrmAyarlar();
            this.Hide();
            frmAyarlar.Show();
                    
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
            dataGridTeknikServis.DataSource = db.TBLTeknikServis.Where(x => x.UrunIsmi == txtArama.Text).ToList();
        }

        private void btnEnvanterSirala_Click(object sender, EventArgs e)
        {
            if (rbtnAdaGore.Checked == true)
            {
                List<TBLTeknikServis> liste1 = db.TBLTeknikServis.OrderBy(p => p.UrunIsmi).ToList();
                dataGridTeknikServis.DataSource = liste1;
            }
            if (rbtnAdaGoreTers.Checked == true)
            {
                List<TBLTeknikServis> liste2 = db.TBLTeknikServis.OrderByDescending(p => p.UrunIsmi).ToList();
                dataGridTeknikServis.DataSource = liste2;
            }
            if (rbtnArtanStok.Checked == true)
            {
                List<TBLTeknikServis> liste3 = db.TBLTeknikServis.OrderBy(p => p.Adet).ToList();
                dataGridTeknikServis.DataSource = liste3;
            }
            if (rbtnAzalanStok.Checked == true)
            {
                List<TBLTeknikServis> liste4 = db.TBLTeknikServis.OrderByDescending(p => p.Adet).ToList();
                dataGridTeknikServis.DataSource = liste4;
            }
            if (rbtnTarihYeni.Checked == true)
            {
                List<TBLTeknikServis> liste5 = db.TBLTeknikServis.OrderBy(p => p.GelisTarihi).ToList();
                dataGridTeknikServis.DataSource = liste5;
            }
            if (rbtnTarihEski.Checked == true)
            {
                List<TBLTeknikServis> liste6 = db.TBLTeknikServis.OrderByDescending(p => p.GelisTarihi).ToList();
                dataGridTeknikServis.DataSource = liste6;
            }
        }

        private void btnSiralaYenile_Click(object sender, EventArgs e)
        {
            EnvanterListele();
        }

        private void dataGridTeknikServis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbEnvantereGonderUrunIsim.Text = dataGridTeknikServis.CurrentRow.Cells[2].Value.ToString();
            tbEnvanterGonderAdet.Text = dataGridTeknikServis.CurrentRow.Cells[3].Value.ToString();

            lblUrunAd.Text = dataGridTeknikServis.CurrentRow.Cells[2].Value.ToString();
            lblAdet.Text = dataGridTeknikServis.CurrentRow.Cells[3].Value.ToString();
            lblArıza.Text = dataGridTeknikServis.CurrentRow.Cells[5].Value.ToString();
            lblDurum.Text = dataGridTeknikServis.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            int idenv = Convert.ToInt32(dataGridTeknikServis.CurrentRow.Cells[1].Value.ToString());
            int idts = Convert.ToInt32(dataGridTeknikServis.CurrentRow.Cells[0].Value.ToString());
            var ts = db.TBLTeknikServis.Find(idts);
            var env = db.TBLEnvanter.Find(idenv);
            env.EnvanterID = Convert.ToInt32(ts.EnvanterId.ToString());
            env.UrunIsmi = tbEnvantereGonderUrunIsim.Text;
            env.StokDurum = env.StokDurum.Value + Convert.ToInt32(tbEnvanterGonderAdet.Text);
            ts.CikisTarihi = DateTime.Now;
            int a = ts.Adet.Value - Convert.ToInt32(tbEnvanterGonderAdet.Text);
            if (a < 0)
            {
                MessageBox.Show("Hata! Ürün Adedi Yanlış.");
                EnvanterListele();
            }
            else
            {
                ts.Adet = ts.Adet.Value - Convert.ToInt32(tbEnvanterGonderAdet.Text);
                if (ts.Adet.Value == 0)
                {
                    ts.Durum = "İşlem Tamamlandı";
                }
                db.SaveChanges();
            }
            EnvanterListele();
        }

        private void BtnIslemeAl_Click(object sender, EventArgs e)
        {
            if (dataGridTeknikServis.CurrentRow.Cells[6].Value.ToString() == "Beklemede")
            {
                int id = Convert.ToInt32(dataGridTeknikServis.CurrentRow.Cells[0].Value.ToString());
                var durum = db.TBLTeknikServis.Find(id);
                durum.Durum = "İşleme Alındı";
                db.SaveChanges();
                EnvanterListele();
                MessageBox.Show("Ürün İşleme Alını !");
            }
            else if (dataGridTeknikServis.CurrentRow.Cells[6].Value.ToString() == "İşleme Alındı")
            {
                MessageBox.Show("Ürün Zaten İşlemde !");
            }
            else if (dataGridTeknikServis.CurrentRow.Cells[6].Value.ToString() == "İşlem Tamamlandı")
            {
                MessageBox.Show("Ürün İşlemi Zaten Tamamlanmış !");
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            tbEnvantereGonderUrunIsim.Text = "";
            tbEnvanterGonderAdet.Text = "";
        }
    }
}

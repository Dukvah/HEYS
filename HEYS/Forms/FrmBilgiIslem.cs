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
    public partial class FrmBilgiIslem : Form
    {
        public FrmBilgiIslem()
        {
            InitializeComponent();
        }
        DbHEYSEntities db = new DbHEYSEntities();
        private void FrmBilgiIslem_Load(object sender, EventArgs e)
        {
            EnvanterListele();
            txtArama.Text = "Arama";
        }
        public void EnvanterListele()
        {
            dataGridBilgiIslem.DataSource = db.TBLBilgiIslem.ToList();
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
            dataGridBilgiIslem.DataSource = db.TBLBilgiIslem.Where(x => x.UrunIsmi == txtArama.Text).ToList();
        }

        private void btnEnvanterSirala_Click(object sender, EventArgs e)
        {
            if (rbtnAdaGore.Checked == true)
            {
                List<TBLBilgiIslem> liste1 = db.TBLBilgiIslem.OrderBy(p => p.UrunIsmi).ToList();
                dataGridBilgiIslem.DataSource = liste1;
            }
            if (rbtnAdaGoreTers.Checked == true)
            {
                List<TBLBilgiIslem> liste2 = db.TBLBilgiIslem.OrderByDescending(p => p.UrunIsmi).ToList();
                dataGridBilgiIslem.DataSource = liste2;
            }
            if (rbtnArtanStok.Checked == true)
            {
                List<TBLBilgiIslem> liste3 = db.TBLBilgiIslem.OrderBy(p => p.Adet).ToList();
                dataGridBilgiIslem.DataSource = liste3;
            }
            if (rbtnAzalanStok.Checked == true)
            {
                List<TBLBilgiIslem> liste4 = db.TBLBilgiIslem.OrderByDescending(p => p.Adet).ToList();
                dataGridBilgiIslem.DataSource = liste4;
            }
            if (rbtnTarihYeni.Checked == true)
            {
                List<TBLBilgiIslem> liste5 = db.TBLBilgiIslem.OrderBy(p => p.GirisTarihi).ToList();
                dataGridBilgiIslem.DataSource = liste5;
            }
            if (rbtnTarihEski.Checked == true)
            {
                List<TBLBilgiIslem> liste6 = db.TBLBilgiIslem.OrderByDescending(p => p.GirisTarihi).ToList();
                dataGridBilgiIslem.DataSource = liste6;
            }
        }

        private void btnSiralaYenile_Click(object sender, EventArgs e)
        {
            EnvanterListele();
        }
    }
}

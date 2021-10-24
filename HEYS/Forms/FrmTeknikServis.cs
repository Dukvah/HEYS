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
    }
}

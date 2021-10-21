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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }
        private void btnEnvanter_Click(object sender, EventArgs e)
        {
            FrmEnvanter frmenvanter = new FrmEnvanter();
            this.Hide();
            frmenvanter.Show();
        }

        private void btnBilgiIslem_Click(object sender, EventArgs e)
        {
            FrmBilgiIslem frmBilgiIslem = new FrmBilgiIslem();
            this.Hide();
            frmBilgiIslem.Show();
        }

        private void btnTeknikServis_Click(object sender, EventArgs e)
        {
            FrmTeknikServis frmTeknikServis = new FrmTeknikServis();
            this.Hide();
            frmTeknikServis.Show();
        }

        private void btnPersonel_Click(object sender, EventArgs e)
        {
            FrmPersonel frmPersonel = new FrmPersonel();
            this.Hide();
            frmPersonel.Show();
        }

        private void btnBölümler_Click(object sender, EventArgs e)
        {
            FrmBolumler frmBolumler = new FrmBolumler();
            this.Hide();
            frmBolumler.Show();
        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            FrmAyarlar frmAyarlar = new FrmAyarlar();
            this.Hide();
            frmAyarlar.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

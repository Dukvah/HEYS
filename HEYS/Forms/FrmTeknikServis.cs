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
    }
}

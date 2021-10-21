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
            dataGridEnvanter.Columns[8].Visible = false;
            dataGridEnvanter.Columns[9].Visible = false;
            dataGridEnvanter.Columns[10].Visible = false;
            dataGridEnvanter.Columns[11].Visible = false;
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
        public void DeleteMusteri(int id)
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

        private void btnArizaGonder_Click(object sender, EventArgs e)
        {
            if (cbArizaBirim.SelectedItem.ToString() == "Teknik Servis")
            {
                TBLTeknikServis teknikServis = new TBLTeknikServis();
                teknikServis.UrunIsmi = tbArizaUrunIsim.Text;
                teknikServis.Adet = Convert.ToInt32(tbArizaAdet.Text);
                teknikServis.GelisTarihi = dtpArizaTarih.Value;
                teknikServis.GelisSebebi = tbArizaGonderimSebebi.Text;
                db.TBLTeknikServis.Add(teknikServis);
                db.SaveChanges();

            }
            else if (cbArizaBirim.SelectedItem.ToString() == "Bilgi İşlem")
            {
                TBLBilgiIslem bilgiIslem = new TBLBilgiIslem();
                bilgiIslem.UrunIsmi = tbArizaUrunIsim.Text;
                bilgiIslem.Adet = Convert.ToInt32(tbArizaAdet.Text);
                bilgiIslem.GirisTarihi = dtpArizaTarih.Value;
                bilgiIslem.GelisSebebi = tbArizaGonderimSebebi.Text;
                db.TBLBilgiIslem.Add(bilgiIslem);
                db.SaveChanges();

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
            tbArizaUrunIsim.Text = dataGridEnvanter.CurrentRow.Cells[2].Value.ToString();
            tbArizaAdet.Text = dataGridEnvanter.CurrentRow.Cells[3].Value.ToString();
            if (e.ColumnIndex == 0)
            {
                int id = Convert.ToInt32(dataGridEnvanter.CurrentRow.Cells[1].Value.ToString());
                DeleteMusteri(id);
                EnvanterListele();
                tbArizaUrunIsim.Text = "";
                tbArizaAdet.Text = "";
            }
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
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmMenu frmMenu = new FrmMenu();
            this.Hide();
            frmMenu.Show();
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class FrmKullanıcıGiris : Form
    {
        public FrmKullanıcıGiris()
        {
            InitializeComponent();
        }
        DbHEYSEntities db = new DbHEYSEntities();
        public static TBLKullanıcı USER;

        private void FrmKullanıcıGiris_Load(object sender, EventArgs e)
        {
            txtKullaniciAdi.Text = "Kullanıcı adınızı giriniz";
            txtSifre.Text = "Şifrenizi giriniz";

        }
        private void txtKullaniciAdi_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text == "Kullanıcı adınızı giriniz")
            {
                txtKullaniciAdi.Text = "";
            }
        }
            private void txtKullaniciAdi_Leave(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtKullaniciAdi.Text))
            {
                txtKullaniciAdi.Text = "Kullanıcı adınızı giriniz";
            }
        }
       
        
        private void txtSifre_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSifre.Text))
            {
                txtSifre.Text = "Şifrenizi giriniz";
                txtSifre.UseSystemPasswordChar = false;
            }

        }
        private void txtSifre_Click(object sender, EventArgs e)
        {
            if (txtSifre.Text == "Şifrenizi giriniz")
            {
                txtSifre.UseSystemPasswordChar = true;
                txtSifre.Text = "";
            }
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (KullaniciKontrol(txtKullaniciAdi.Text, txtSifre.Text))
            {
                MessageBox.Show("Giriş Başarılı!");
                FrmMenu envanter = new FrmMenu();
                this.Hide();
                envanter.Show();
            }
            else
            {
                MessageBox.Show("Hatalı giriş");
            }
        }
        public bool KullaniciKontrol(string kAdi, string kParola)
        {
            var sorgu = from p in db.TBLKullanıcı
                        where p.TCNo == kAdi
                         && p.Parola == kParola
                        select p;
            if (sorgu.Any())
            {
                USER = new TBLKullanıcı();
                foreach (var p in sorgu)
                {
                    USER.Ad = p.Ad;
                    USER.ID = p.ID;
                    USER.YetkiDurumu = p.YetkiDurumu;
                    USER.TCNo = p.TCNo;
                    USER.Soyad = p.Soyad;
                    USER.Parola = p.Parola;
                    USER.Mail = p.Mail;
                    USER.DahiliNo = p.DahiliNo;
                    USER.CalistigiBirim = p.CalistigiBirim;
                    USER.Fotograf = p.Fotograf;
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
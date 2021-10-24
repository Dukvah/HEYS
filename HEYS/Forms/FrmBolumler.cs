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
    public partial class FrmBolumler : Form
    {
        public FrmBolumler()
        {
            InitializeComponent();
        }
        DbHEYSEntities db = new DbHEYSEntities();
        private void FrmBolumler_Load(object sender, EventArgs e)
        {
            EnvanterListele();
            txtArama.Text = "Ara";
        }
        public void EnvanterListele()
        {
            dataGridBolumler.DataSource = db.TBLHastaneBolum.ToList();
            dataGridBolumler.Columns[6].Visible = false;
            dataGridBolumler.Columns[7].Visible = false;
            lblBolumSayisi.Text = Convert.ToString(dataGridBolumler.RowCount);
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
            if (txtArama.Text == "Ara")
            {
                txtArama.Text = "";
            }
        }

        private void txtArama_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtArama.Text))
            {
                txtArama.Text = "Ara";
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            dataGridBolumler.DataSource = db.TBLHastaneBolum.Where(x => x.BolumIsmi == txtArama.Text).ToList();
        }

        private void btnEnvanterSirala_Click(object sender, EventArgs e)
        {
            if (rbtnAdaGore.Checked == true)
            {
                List<TBLHastaneBolum> liste1 = db.TBLHastaneBolum.OrderBy(p => p.BolumIsmi).ToList();
                dataGridBolumler.DataSource = liste1;
            }
            if (rbtnAdaGoreTers.Checked == true)
            {
                List<TBLHastaneBolum> liste2 = db.TBLHastaneBolum.OrderByDescending(p => p.BolumIsmi).ToList();
                dataGridBolumler.DataSource = liste2;
            }
            if (rbtnArtanPersonel.Checked == true)
            {
                List<TBLHastaneBolum> liste3 = db.TBLHastaneBolum.OrderBy(p => p.PersonelSayisi).ToList();
                dataGridBolumler.DataSource = liste3;
            }
            if (rbtnAzalanPersonel.Checked == true)
            {
                List<TBLHastaneBolum> liste4 = db.TBLHastaneBolum.OrderByDescending(p => p.PersonelSayisi).ToList();
                dataGridBolumler.DataSource = liste4;
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
            for (int j = 1; j < dataGridBolumler.Columns.Count - 2; j++)
            {
                Range myRange = (Range)sheet1.Cells[StartRow, StartCol + j];
                myRange.Value2 = dataGridBolumler.Columns[j].HeaderText;
            }
            StartRow++;
            for (int i = 0; i < dataGridBolumler.Rows.Count; i++)
            {
                for (int j = 1; j < dataGridBolumler.Columns.Count - 2; j++)
                {
                    Range myRange = (Range)sheet1.Cells[StartRow + i, StartCol + j];
                    myRange.Value2 = dataGridBolumler[j, i].Value == null ? " " : dataGridBolumler[j, i].Value;
                    myRange.Select();
                }
            }
        }
    }
}

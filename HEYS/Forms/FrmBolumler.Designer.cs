
namespace HEYS
{
    partial class FrmBolumler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBolumler));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.dataGridBolumler = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbtnAzalanPersonel = new System.Windows.Forms.RadioButton();
            this.rbtnArtanPersonel = new System.Windows.Forms.RadioButton();
            this.rbtnAdaGoreTers = new System.Windows.Forms.RadioButton();
            this.rbtnAdaGore = new System.Windows.Forms.RadioButton();
            this.btnSiralaYenile = new System.Windows.Forms.Button();
            this.btnEnvanterSirala = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblBolumSayisi = new System.Windows.Forms.Label();
            this.btnExcel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBolumler)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBack.ForeColor = System.Drawing.Color.Transparent;
            this.btnBack.Location = new System.Drawing.Point(1832, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(40, 40);
            this.btnBack.TabIndex = 25;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCikis.BackColor = System.Drawing.Color.DarkRed;
            this.btnCikis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCikis.BackgroundImage")));
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.Color.White;
            this.btnCikis.Location = new System.Drawing.Point(1888, 12);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(40, 40);
            this.btnCikis.TabIndex = 24;
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // dataGridBolumler
            // 
            this.dataGridBolumler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridBolumler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBolumler.Location = new System.Drawing.Point(67, 112);
            this.dataGridBolumler.Name = "dataGridBolumler";
            this.dataGridBolumler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridBolumler.Size = new System.Drawing.Size(1483, 903);
            this.dataGridBolumler.TabIndex = 26;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btnAra);
            this.groupBox3.Controls.Add(this.txtArama);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(1623, 79);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(256, 170);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Arama";
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(128)))));
            this.btnAra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAra.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.Location = new System.Drawing.Point(176, 98);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(60, 33);
            this.btnAra.TabIndex = 15;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // txtArama
            // 
            this.txtArama.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtArama.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtArama.Location = new System.Drawing.Point(61, 54);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(175, 25);
            this.txtArama.TabIndex = 3;
            this.txtArama.TabStop = false;
            this.txtArama.Click += new System.EventHandler(this.txtArama_Click);
            this.txtArama.Leave += new System.EventHandler(this.txtArama_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.rbtnAzalanPersonel);
            this.groupBox4.Controls.Add(this.rbtnArtanPersonel);
            this.groupBox4.Controls.Add(this.rbtnAdaGoreTers);
            this.groupBox4.Controls.Add(this.rbtnAdaGore);
            this.groupBox4.Controls.Add(this.btnSiralaYenile);
            this.groupBox4.Controls.Add(this.btnEnvanterSirala);
            this.groupBox4.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(1623, 273);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(256, 409);
            this.groupBox4.TabIndex = 28;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sırala";
            // 
            // rbtnAzalanPersonel
            // 
            this.rbtnAzalanPersonel.AutoSize = true;
            this.rbtnAzalanPersonel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnAzalanPersonel.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtnAzalanPersonel.Location = new System.Drawing.Point(32, 252);
            this.rbtnAzalanPersonel.Name = "rbtnAzalanPersonel";
            this.rbtnAzalanPersonel.Size = new System.Drawing.Size(217, 27);
            this.rbtnAzalanPersonel.TabIndex = 20;
            this.rbtnAzalanPersonel.TabStop = true;
            this.rbtnAzalanPersonel.Text = "Azalan Personel Sayısı";
            this.rbtnAzalanPersonel.UseVisualStyleBackColor = true;
            // 
            // rbtnArtanPersonel
            // 
            this.rbtnArtanPersonel.AutoSize = true;
            this.rbtnArtanPersonel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnArtanPersonel.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtnArtanPersonel.Location = new System.Drawing.Point(32, 186);
            this.rbtnArtanPersonel.Name = "rbtnArtanPersonel";
            this.rbtnArtanPersonel.Size = new System.Drawing.Size(209, 27);
            this.rbtnArtanPersonel.TabIndex = 17;
            this.rbtnArtanPersonel.TabStop = true;
            this.rbtnArtanPersonel.Text = "Artan Personel Sayısı";
            this.rbtnArtanPersonel.UseVisualStyleBackColor = true;
            // 
            // rbtnAdaGoreTers
            // 
            this.rbtnAdaGoreTers.AutoSize = true;
            this.rbtnAdaGoreTers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnAdaGoreTers.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtnAdaGoreTers.Location = new System.Drawing.Point(32, 116);
            this.rbtnAdaGoreTers.Name = "rbtnAdaGoreTers";
            this.rbtnAdaGoreTers.Size = new System.Drawing.Size(138, 27);
            this.rbtnAdaGoreTers.TabIndex = 16;
            this.rbtnAdaGoreTers.TabStop = true;
            this.rbtnAdaGoreTers.Text = "İsim (Z -> A)\r\n";
            this.rbtnAdaGoreTers.UseVisualStyleBackColor = true;
            // 
            // rbtnAdaGore
            // 
            this.rbtnAdaGore.AutoSize = true;
            this.rbtnAdaGore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnAdaGore.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtnAdaGore.Location = new System.Drawing.Point(32, 51);
            this.rbtnAdaGore.Name = "rbtnAdaGore";
            this.rbtnAdaGore.Size = new System.Drawing.Size(138, 27);
            this.rbtnAdaGore.TabIndex = 15;
            this.rbtnAdaGore.TabStop = true;
            this.rbtnAdaGore.Text = "İsim (A -> Z)\r\n";
            this.rbtnAdaGore.UseVisualStyleBackColor = true;
            // 
            // btnSiralaYenile
            // 
            this.btnSiralaYenile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(128)))));
            this.btnSiralaYenile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSiralaYenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiralaYenile.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiralaYenile.Location = new System.Drawing.Point(135, 356);
            this.btnSiralaYenile.Name = "btnSiralaYenile";
            this.btnSiralaYenile.Size = new System.Drawing.Size(101, 31);
            this.btnSiralaYenile.TabIndex = 14;
            this.btnSiralaYenile.Text = "Yenile";
            this.btnSiralaYenile.UseVisualStyleBackColor = false;
            this.btnSiralaYenile.Click += new System.EventHandler(this.btnSiralaYenile_Click);
            // 
            // btnEnvanterSirala
            // 
            this.btnEnvanterSirala.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(128)))));
            this.btnEnvanterSirala.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnvanterSirala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnvanterSirala.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEnvanterSirala.Location = new System.Drawing.Point(15, 356);
            this.btnEnvanterSirala.Name = "btnEnvanterSirala";
            this.btnEnvanterSirala.Size = new System.Drawing.Size(101, 31);
            this.btnEnvanterSirala.TabIndex = 13;
            this.btnEnvanterSirala.Text = "Sırala";
            this.btnEnvanterSirala.UseVisualStyleBackColor = false;
            this.btnEnvanterSirala.Click += new System.EventHandler(this.btnEnvanterSirala_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.lblBolumSayisi);
            this.groupBox2.Controls.Add(this.btnExcel);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(1623, 710);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 290);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rapor";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(183, 130);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(65, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // lblBolumSayisi
            // 
            this.lblBolumSayisi.AutoSize = true;
            this.lblBolumSayisi.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBolumSayisi.Location = new System.Drawing.Point(179, 67);
            this.lblBolumSayisi.Name = "lblBolumSayisi";
            this.lblBolumSayisi.Size = new System.Drawing.Size(17, 23);
            this.lblBolumSayisi.TabIndex = 15;
            this.lblBolumSayisi.Text = "-";
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(128)))));
            this.btnExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExcel.Location = new System.Drawing.Point(13, 141);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(164, 40);
            this.btnExcel.TabIndex = 14;
            this.btnExcel.Text = "Excele Aktar";
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(9, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "Bölüm Sayısı :";
            // 
            // FrmBolumler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1940, 1061);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataGridBolumler);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCikis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBolumler";
            this.Text = "FrmBolumler";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmBolumler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBolumler)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.DataGridView dataGridBolumler;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbtnAzalanPersonel;
        private System.Windows.Forms.RadioButton rbtnArtanPersonel;
        private System.Windows.Forms.RadioButton rbtnAdaGoreTers;
        private System.Windows.Forms.RadioButton rbtnAdaGore;
        private System.Windows.Forms.Button btnSiralaYenile;
        private System.Windows.Forms.Button btnEnvanterSirala;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblBolumSayisi;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Label label6;
    }
}
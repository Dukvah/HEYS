
namespace HEYS
{
    partial class FrmTeknikServis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTeknikServis));
            this.dataGridTeknikServis = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbEnvanterGonderAdet = new System.Windows.Forms.TextBox();
            this.tbEnvantereGonderUrunIsim = new System.Windows.Forms.TextBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnGonder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbtnTarihEski = new System.Windows.Forms.RadioButton();
            this.rbtnAzalanStok = new System.Windows.Forms.RadioButton();
            this.rbtnArtanStok = new System.Windows.Forms.RadioButton();
            this.rbtnTarihYeni = new System.Windows.Forms.RadioButton();
            this.rbtnAdaGoreTers = new System.Windows.Forms.RadioButton();
            this.rbtnAdaGore = new System.Windows.Forms.RadioButton();
            this.btnSiralaYenile = new System.Windows.Forms.Button();
            this.btnEnvanterSirala = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblDurum = new System.Windows.Forms.Label();
            this.lblArıza = new System.Windows.Forms.Label();
            this.lblAdet = new System.Windows.Forms.Label();
            this.lblUrunAd = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnIslemeAl = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTeknikServis)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridTeknikServis
            // 
            this.dataGridTeknikServis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridTeknikServis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTeknikServis.Location = new System.Drawing.Point(447, 112);
            this.dataGridTeknikServis.Name = "dataGridTeknikServis";
            this.dataGridTeknikServis.ReadOnly = true;
            this.dataGridTeknikServis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridTeknikServis.Size = new System.Drawing.Size(1103, 903);
            this.dataGridTeknikServis.TabIndex = 0;
            this.dataGridTeknikServis.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridTeknikServis_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.tbEnvanterGonderAdet);
            this.groupBox1.Controls.Add(this.tbEnvantereGonderUrunIsim);
            this.groupBox1.Controls.Add(this.btnTemizle);
            this.groupBox1.Controls.Add(this.btnGonder);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(38, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 279);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Envantere Gönder";
            // 
            // tbEnvanterGonderAdet
            // 
            this.tbEnvanterGonderAdet.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbEnvanterGonderAdet.Location = new System.Drawing.Point(183, 134);
            this.tbEnvanterGonderAdet.Name = "tbEnvanterGonderAdet";
            this.tbEnvanterGonderAdet.Size = new System.Drawing.Size(138, 29);
            this.tbEnvanterGonderAdet.TabIndex = 17;
            // 
            // tbEnvantereGonderUrunIsim
            // 
            this.tbEnvantereGonderUrunIsim.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbEnvantereGonderUrunIsim.Location = new System.Drawing.Point(183, 64);
            this.tbEnvantereGonderUrunIsim.Name = "tbEnvantereGonderUrunIsim";
            this.tbEnvantereGonderUrunIsim.Size = new System.Drawing.Size(138, 29);
            this.tbEnvantereGonderUrunIsim.TabIndex = 16;
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(128)))));
            this.btnTemizle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizle.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Location = new System.Drawing.Point(36, 207);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(120, 40);
            this.btnTemizle.TabIndex = 15;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnGonder
            // 
            this.btnGonder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(128)))));
            this.btnGonder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGonder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGonder.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGonder.Location = new System.Drawing.Point(183, 207);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(120, 40);
            this.btnGonder.TabIndex = 14;
            this.btnGonder.Text = "Gönder";
            this.btnGonder.UseVisualStyleBackColor = false;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(9, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gönderim Adedi :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(9, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün Adı :";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.rbtnTarihEski);
            this.groupBox4.Controls.Add(this.rbtnAzalanStok);
            this.groupBox4.Controls.Add(this.rbtnArtanStok);
            this.groupBox4.Controls.Add(this.rbtnTarihYeni);
            this.groupBox4.Controls.Add(this.rbtnAdaGoreTers);
            this.groupBox4.Controls.Add(this.rbtnAdaGore);
            this.groupBox4.Controls.Add(this.btnSiralaYenile);
            this.groupBox4.Controls.Add(this.btnEnvanterSirala);
            this.groupBox4.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(1623, 407);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(276, 608);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sırala";
            // 
            // rbtnTarihEski
            // 
            this.rbtnTarihEski.AutoSize = true;
            this.rbtnTarihEski.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnTarihEski.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtnTarihEski.Location = new System.Drawing.Point(32, 278);
            this.rbtnTarihEski.Name = "rbtnTarihEski";
            this.rbtnTarihEski.Size = new System.Drawing.Size(156, 27);
            this.rbtnTarihEski.TabIndex = 20;
            this.rbtnTarihEski.TabStop = true;
            this.rbtnTarihEski.Text = "Eskiden Yeniye";
            this.rbtnTarihEski.UseVisualStyleBackColor = true;
            // 
            // rbtnAzalanStok
            // 
            this.rbtnAzalanStok.AutoSize = true;
            this.rbtnAzalanStok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnAzalanStok.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtnAzalanStok.Location = new System.Drawing.Point(32, 414);
            this.rbtnAzalanStok.Name = "rbtnAzalanStok";
            this.rbtnAzalanStok.Size = new System.Drawing.Size(128, 27);
            this.rbtnAzalanStok.TabIndex = 19;
            this.rbtnAzalanStok.TabStop = true;
            this.rbtnAzalanStok.Text = "Azalan Stok";
            this.rbtnAzalanStok.UseVisualStyleBackColor = true;
            // 
            // rbtnArtanStok
            // 
            this.rbtnArtanStok.AutoSize = true;
            this.rbtnArtanStok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnArtanStok.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtnArtanStok.Location = new System.Drawing.Point(32, 344);
            this.rbtnArtanStok.Name = "rbtnArtanStok";
            this.rbtnArtanStok.Size = new System.Drawing.Size(120, 27);
            this.rbtnArtanStok.TabIndex = 18;
            this.rbtnArtanStok.TabStop = true;
            this.rbtnArtanStok.Text = "Artan Stok";
            this.rbtnArtanStok.UseVisualStyleBackColor = true;
            // 
            // rbtnTarihYeni
            // 
            this.rbtnTarihYeni.AutoSize = true;
            this.rbtnTarihYeni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnTarihYeni.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtnTarihYeni.Location = new System.Drawing.Point(32, 210);
            this.rbtnTarihYeni.Name = "rbtnTarihYeni";
            this.rbtnTarihYeni.Size = new System.Drawing.Size(156, 27);
            this.rbtnTarihYeni.TabIndex = 17;
            this.rbtnTarihYeni.TabStop = true;
            this.rbtnTarihYeni.Text = "Yeniden Eskiye";
            this.rbtnTarihYeni.UseVisualStyleBackColor = true;
            // 
            // rbtnAdaGoreTers
            // 
            this.rbtnAdaGoreTers.AutoSize = true;
            this.rbtnAdaGoreTers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnAdaGoreTers.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtnAdaGoreTers.Location = new System.Drawing.Point(32, 141);
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
            this.rbtnAdaGore.Location = new System.Drawing.Point(32, 70);
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
            this.btnSiralaYenile.Location = new System.Drawing.Point(135, 543);
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
            this.btnEnvanterSirala.Location = new System.Drawing.Point(15, 543);
            this.btnEnvanterSirala.Name = "btnEnvanterSirala";
            this.btnEnvanterSirala.Size = new System.Drawing.Size(101, 31);
            this.btnEnvanterSirala.TabIndex = 13;
            this.btnEnvanterSirala.Text = "Sırala";
            this.btnEnvanterSirala.UseVisualStyleBackColor = false;
            this.btnEnvanterSirala.Click += new System.EventHandler(this.btnEnvanterSirala_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btnAra);
            this.groupBox3.Controls.Add(this.txtArama);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(1623, 79);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(276, 298);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Arama";
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(128)))));
            this.btnAra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAra.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.Location = new System.Drawing.Point(176, 150);
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
            this.txtArama.Location = new System.Drawing.Point(61, 105);
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
            this.pictureBox1.Location = new System.Drawing.Point(15, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            this.btnCikis.TabIndex = 25;
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
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
            this.btnBack.TabIndex = 26;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lblDurum);
            this.groupBox2.Controls.Add(this.lblArıza);
            this.groupBox2.Controls.Add(this.lblAdet);
            this.groupBox2.Controls.Add(this.lblUrunAd);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.BtnIslemeAl);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lbl);
            this.groupBox2.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(38, 394);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(338, 355);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Durum Güncelle";
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDurum.Location = new System.Drawing.Point(154, 204);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(17, 23);
            this.lblDurum.TabIndex = 21;
            this.lblDurum.Text = "-";
            // 
            // lblArıza
            // 
            this.lblArıza.AutoSize = true;
            this.lblArıza.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblArıza.Location = new System.Drawing.Point(154, 156);
            this.lblArıza.Name = "lblArıza";
            this.lblArıza.Size = new System.Drawing.Size(17, 23);
            this.lblArıza.TabIndex = 20;
            this.lblArıza.Text = "-";
            // 
            // lblAdet
            // 
            this.lblAdet.AutoSize = true;
            this.lblAdet.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdet.Location = new System.Drawing.Point(154, 113);
            this.lblAdet.Name = "lblAdet";
            this.lblAdet.Size = new System.Drawing.Size(17, 23);
            this.lblAdet.TabIndex = 19;
            this.lblAdet.Text = "-";
            // 
            // lblUrunAd
            // 
            this.lblUrunAd.AutoSize = true;
            this.lblUrunAd.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunAd.Location = new System.Drawing.Point(154, 68);
            this.lblUrunAd.Name = "lblUrunAd";
            this.lblUrunAd.Size = new System.Drawing.Size(17, 23);
            this.lblUrunAd.TabIndex = 18;
            this.lblUrunAd.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(9, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "Durum :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(9, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Arızası :";
            // 
            // BtnIslemeAl
            // 
            this.BtnIslemeAl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(128)))));
            this.BtnIslemeAl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnIslemeAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIslemeAl.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnIslemeAl.Location = new System.Drawing.Point(188, 290);
            this.BtnIslemeAl.Name = "BtnIslemeAl";
            this.BtnIslemeAl.Size = new System.Drawing.Size(120, 40);
            this.BtnIslemeAl.TabIndex = 14;
            this.BtnIslemeAl.Text = "İşleme Al";
            this.BtnIslemeAl.UseVisualStyleBackColor = false;
            this.BtnIslemeAl.Click += new System.EventHandler(this.BtnIslemeAl_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(9, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adedi :";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl.Location = new System.Drawing.Point(9, 67);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(110, 25);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "Ürün Adı :";
            // 
            // FrmTeknikServis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1940, 1061);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridTeknikServis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTeknikServis";
            this.Text = "FrmTeknikServis";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmTeknikServis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTeknikServis)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridTeknikServis;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbtnTarihEski;
        private System.Windows.Forms.RadioButton rbtnAzalanStok;
        private System.Windows.Forms.RadioButton rbtnArtanStok;
        private System.Windows.Forms.RadioButton rbtnTarihYeni;
        private System.Windows.Forms.RadioButton rbtnAdaGoreTers;
        private System.Windows.Forms.RadioButton rbtnAdaGore;
        private System.Windows.Forms.Button btnSiralaYenile;
        private System.Windows.Forms.Button btnEnvanterSirala;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbEnvanterGonderAdet;
        private System.Windows.Forms.TextBox tbEnvantereGonderUrunIsim;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblArıza;
        private System.Windows.Forms.Label lblAdet;
        private System.Windows.Forms.Label lblUrunAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnIslemeAl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblDurum;
    }
}
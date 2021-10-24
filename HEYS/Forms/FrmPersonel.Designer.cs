
namespace HEYS
{
    partial class FrmPersonel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonel));
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.dataGridPersonel = new System.Windows.Forms.DataGridView();
            this.Sil = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtAramaSoyisim = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAra = new System.Windows.Forms.Button();
            this.txtAramaIsim = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbtnSoyadaGoreTers = new System.Windows.Forms.RadioButton();
            this.rbtnSoyadaGore = new System.Windows.Forms.RadioButton();
            this.rbtnAdaGoreTers = new System.Windows.Forms.RadioButton();
            this.rbtnAdaGore = new System.Windows.Forms.RadioButton();
            this.btnSiralaYenile = new System.Windows.Forms.Button();
            this.btnEnvanterSirala = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbBirim = new System.Windows.Forms.TextBox();
            this.tbBolum = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.tbTC = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbSoyad = new System.Windows.Forms.TextBox();
            this.tbAd = new System.Windows.Forms.TextBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnPersonelEkle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblEnvanterSayisi = new System.Windows.Forms.Label();
            this.lblPersonelSayisi = new System.Windows.Forms.Label();
            this.btnExcel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPersonel)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.btnCikis.TabIndex = 22;
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
            this.btnBack.TabIndex = 23;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dataGridPersonel
            // 
            this.dataGridPersonel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridPersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPersonel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sil});
            this.dataGridPersonel.Location = new System.Drawing.Point(447, 112);
            this.dataGridPersonel.Name = "dataGridPersonel";
            this.dataGridPersonel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPersonel.Size = new System.Drawing.Size(1103, 903);
            this.dataGridPersonel.TabIndex = 24;
            this.dataGridPersonel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPersonel_CellContentClick);
            // 
            // Sil
            // 
            this.Sil.HeaderText = "";
            this.Sil.Name = "Sil";
            this.Sil.Text = "Sil";
            this.Sil.ToolTipText = "Sil";
            this.Sil.UseColumnTextForButtonValue = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.txtAramaSoyisim);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.btnAra);
            this.groupBox3.Controls.Add(this.txtAramaIsim);
            this.groupBox3.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(1623, 79);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(256, 227);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Arama";
            // 
            // txtAramaSoyisim
            // 
            this.txtAramaSoyisim.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAramaSoyisim.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAramaSoyisim.Location = new System.Drawing.Point(105, 123);
            this.txtAramaSoyisim.Name = "txtAramaSoyisim";
            this.txtAramaSoyisim.Size = new System.Drawing.Size(134, 25);
            this.txtAramaSoyisim.TabIndex = 19;
            this.txtAramaSoyisim.TabStop = false;
            this.txtAramaSoyisim.Click += new System.EventHandler(this.txtAramaSoyisim_Click);
            this.txtAramaSoyisim.Leave += new System.EventHandler(this.txtAramaSoyisim_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(11, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 23);
            this.label7.TabIndex = 18;
            this.label7.Text = "Soyisim :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(11, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 23);
            this.label4.TabIndex = 17;
            this.label4.Text = "İsim :";
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(128)))));
            this.btnAra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAra.BackgroundImage")));
            this.btnAra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAra.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.Location = new System.Drawing.Point(196, 165);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(40, 40);
            this.btnAra.TabIndex = 16;
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // txtAramaIsim
            // 
            this.txtAramaIsim.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAramaIsim.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAramaIsim.Location = new System.Drawing.Point(105, 71);
            this.txtAramaIsim.Name = "txtAramaIsim";
            this.txtAramaIsim.Size = new System.Drawing.Size(134, 25);
            this.txtAramaIsim.TabIndex = 3;
            this.txtAramaIsim.TabStop = false;
            this.txtAramaIsim.Click += new System.EventHandler(this.txtAramaIsim_Click);
            this.txtAramaIsim.Leave += new System.EventHandler(this.txtAramaIsim_Leave);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.rbtnSoyadaGoreTers);
            this.groupBox4.Controls.Add(this.rbtnSoyadaGore);
            this.groupBox4.Controls.Add(this.rbtnAdaGoreTers);
            this.groupBox4.Controls.Add(this.rbtnAdaGore);
            this.groupBox4.Controls.Add(this.btnSiralaYenile);
            this.groupBox4.Controls.Add(this.btnEnvanterSirala);
            this.groupBox4.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(1623, 331);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(256, 413);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sırala";
            // 
            // rbtnSoyadaGoreTers
            // 
            this.rbtnSoyadaGoreTers.AutoSize = true;
            this.rbtnSoyadaGoreTers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnSoyadaGoreTers.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtnSoyadaGoreTers.Location = new System.Drawing.Point(32, 278);
            this.rbtnSoyadaGoreTers.Name = "rbtnSoyadaGoreTers";
            this.rbtnSoyadaGoreTers.Size = new System.Drawing.Size(167, 27);
            this.rbtnSoyadaGoreTers.TabIndex = 20;
            this.rbtnSoyadaGoreTers.TabStop = true;
            this.rbtnSoyadaGoreTers.Text = "Soyisim (Z -> A)";
            this.rbtnSoyadaGoreTers.UseVisualStyleBackColor = true;
            // 
            // rbtnSoyadaGore
            // 
            this.rbtnSoyadaGore.AutoSize = true;
            this.rbtnSoyadaGore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnSoyadaGore.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtnSoyadaGore.Location = new System.Drawing.Point(32, 210);
            this.rbtnSoyadaGore.Name = "rbtnSoyadaGore";
            this.rbtnSoyadaGore.Size = new System.Drawing.Size(172, 27);
            this.rbtnSoyadaGore.TabIndex = 17;
            this.rbtnSoyadaGore.TabStop = true;
            this.rbtnSoyadaGore.Text = "Soyisim ( A -> Z)";
            this.rbtnSoyadaGore.UseVisualStyleBackColor = true;
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
            this.btnSiralaYenile.Location = new System.Drawing.Point(135, 346);
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
            this.btnEnvanterSirala.Location = new System.Drawing.Point(15, 346);
            this.btnEnvanterSirala.Name = "btnEnvanterSirala";
            this.btnEnvanterSirala.Size = new System.Drawing.Size(101, 31);
            this.btnEnvanterSirala.TabIndex = 13;
            this.btnEnvanterSirala.Text = "Sırala";
            this.btnEnvanterSirala.UseVisualStyleBackColor = false;
            this.btnEnvanterSirala.Click += new System.EventHandler(this.btnEnvanterSirala_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.tbBirim);
            this.groupBox1.Controls.Add(this.tbBolum);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tbMail);
            this.groupBox1.Controls.Add(this.tbTC);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbSoyad);
            this.groupBox1.Controls.Add(this.tbAd);
            this.groupBox1.Controls.Add(this.btnTemizle);
            this.groupBox1.Controls.Add(this.btnPersonelEkle);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(38, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 455);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Ekle";
            // 
            // tbBirim
            // 
            this.tbBirim.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbBirim.Location = new System.Drawing.Point(139, 342);
            this.tbBirim.Name = "tbBirim";
            this.tbBirim.Size = new System.Drawing.Size(182, 29);
            this.tbBirim.TabIndex = 24;
            // 
            // tbBolum
            // 
            this.tbBolum.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbBolum.Location = new System.Drawing.Point(139, 286);
            this.tbBolum.Name = "tbBolum";
            this.tbBolum.Size = new System.Drawing.Size(182, 29);
            this.tbBolum.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(26, 345);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 23);
            this.label10.TabIndex = 22;
            this.label10.Text = "Birim :";
            // 
            // tbMail
            // 
            this.tbMail.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbMail.Location = new System.Drawing.Point(139, 228);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(182, 29);
            this.tbMail.TabIndex = 21;
            // 
            // tbTC
            // 
            this.tbTC.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbTC.Location = new System.Drawing.Point(139, 172);
            this.tbTC.Name = "tbTC";
            this.tbTC.Size = new System.Drawing.Size(182, 29);
            this.tbTC.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(26, 289);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 23);
            this.label9.TabIndex = 19;
            this.label9.Text = "Bölüm :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(26, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 23);
            this.label8.TabIndex = 18;
            this.label8.Text = "Mail :";
            // 
            // tbSoyad
            // 
            this.tbSoyad.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbSoyad.Location = new System.Drawing.Point(139, 116);
            this.tbSoyad.Name = "tbSoyad";
            this.tbSoyad.Size = new System.Drawing.Size(182, 29);
            this.tbSoyad.TabIndex = 17;
            // 
            // tbAd
            // 
            this.tbAd.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbAd.Location = new System.Drawing.Point(139, 64);
            this.tbAd.Name = "tbAd";
            this.tbAd.Size = new System.Drawing.Size(182, 29);
            this.tbAd.TabIndex = 16;
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(128)))));
            this.btnTemizle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizle.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Location = new System.Drawing.Point(30, 393);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(120, 40);
            this.btnTemizle.TabIndex = 15;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnPersonelEkle
            // 
            this.btnPersonelEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(128)))));
            this.btnPersonelEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPersonelEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonelEkle.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelEkle.Location = new System.Drawing.Point(183, 393);
            this.btnPersonelEkle.Name = "btnPersonelEkle";
            this.btnPersonelEkle.Size = new System.Drawing.Size(120, 40);
            this.btnPersonelEkle.TabIndex = 14;
            this.btnPersonelEkle.Text = "Ekle";
            this.btnPersonelEkle.UseVisualStyleBackColor = false;
            this.btnPersonelEkle.Click += new System.EventHandler(this.btnPersonelEkle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(26, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "TC No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(26, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyisim :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(26, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "İsim :";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.lblEnvanterSayisi);
            this.groupBox2.Controls.Add(this.lblPersonelSayisi);
            this.groupBox2.Controls.Add(this.btnExcel);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(1623, 768);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 247);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rapor";
            // 
            // lblEnvanterSayisi
            // 
            this.lblEnvanterSayisi.AutoSize = true;
            this.lblEnvanterSayisi.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEnvanterSayisi.Location = new System.Drawing.Point(192, 114);
            this.lblEnvanterSayisi.Name = "lblEnvanterSayisi";
            this.lblEnvanterSayisi.Size = new System.Drawing.Size(17, 23);
            this.lblEnvanterSayisi.TabIndex = 16;
            this.lblEnvanterSayisi.Text = "-";
            // 
            // lblPersonelSayisi
            // 
            this.lblPersonelSayisi.AutoSize = true;
            this.lblPersonelSayisi.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersonelSayisi.Location = new System.Drawing.Point(192, 56);
            this.lblPersonelSayisi.Name = "lblPersonelSayisi";
            this.lblPersonelSayisi.Size = new System.Drawing.Size(17, 23);
            this.lblPersonelSayisi.TabIndex = 15;
            this.lblPersonelSayisi.Text = "-";
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(128)))));
            this.btnExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExcel.Location = new System.Drawing.Point(13, 168);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(164, 40);
            this.btnExcel.TabIndex = 14;
            this.btnExcel.Text = "Excele Aktar";
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(28, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "Envanter Sayısı :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(22, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "Personel Sayısı :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(183, 157);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // FrmPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1940, 1061);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataGridPersonel);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCikis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPersonel";
            this.Text = "FrmPersonel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPersonel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPersonel)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dataGridPersonel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtAramaIsim;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbtnSoyadaGoreTers;
        private System.Windows.Forms.RadioButton rbtnSoyadaGore;
        private System.Windows.Forms.RadioButton rbtnAdaGoreTers;
        private System.Windows.Forms.RadioButton rbtnAdaGore;
        private System.Windows.Forms.Button btnSiralaYenile;
        private System.Windows.Forms.Button btnEnvanterSirala;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbSoyad;
        private System.Windows.Forms.TextBox tbAd;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnPersonelEkle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAramaSoyisim;
        private System.Windows.Forms.Label lblEnvanterSayisi;
        private System.Windows.Forms.Label lblPersonelSayisi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbBirim;
        private System.Windows.Forms.TextBox tbBolum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.TextBox tbTC;
        private System.Windows.Forms.DataGridViewButtonColumn Sil;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
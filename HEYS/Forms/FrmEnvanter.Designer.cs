
namespace HEYS
{
    partial class FrmEnvanter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEnvanter));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEnvanterTemizle = new System.Windows.Forms.Button();
            this.btnEnvanterEkle = new System.Windows.Forms.Button();
            this.tbEnvanterSorumluBolum = new System.Windows.Forms.TextBox();
            this.tbEnvanterSorumluPersonel = new System.Windows.Forms.TextBox();
            this.dtpEnvanterTarih = new System.Windows.Forms.DateTimePicker();
            this.cbEnvanterMalzemeDurum = new System.Windows.Forms.ComboBox();
            this.tbEnvanterAdet = new System.Windows.Forms.TextBox();
            this.tbEnvanterUrunIsim = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridEnvanter = new System.Windows.Forms.DataGridView();
            this.Sil = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbArizaBirim = new System.Windows.Forms.ComboBox();
            this.btnArizaTemizle = new System.Windows.Forms.Button();
            this.btnArizaGonder = new System.Windows.Forms.Button();
            this.tbArizaGonderimSebebi = new System.Windows.Forms.TextBox();
            this.dtpArizaTarih = new System.Windows.Forms.DateTimePicker();
            this.tbArizaAdet = new System.Windows.Forms.TextBox();
            this.tbArizaUrunIsim = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSiralaYenile = new System.Windows.Forms.Button();
            this.btnEnvanterSirala = new System.Windows.Forms.Button();
            this.rbtnAdaGore = new System.Windows.Forms.RadioButton();
            this.rbtnAdaGoreTers = new System.Windows.Forms.RadioButton();
            this.rbtnTarihYeni = new System.Windows.Forms.RadioButton();
            this.rbtnArtanStok = new System.Windows.Forms.RadioButton();
            this.rbtnAzalanStok = new System.Windows.Forms.RadioButton();
            this.rbtnTarihEski = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEnvanter)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnEnvanterTemizle);
            this.groupBox1.Controls.Add(this.btnEnvanterEkle);
            this.groupBox1.Controls.Add(this.tbEnvanterSorumluBolum);
            this.groupBox1.Controls.Add(this.tbEnvanterSorumluPersonel);
            this.groupBox1.Controls.Add(this.dtpEnvanterTarih);
            this.groupBox1.Controls.Add(this.cbEnvanterMalzemeDurum);
            this.groupBox1.Controls.Add(this.tbEnvanterAdet);
            this.groupBox1.Controls.Add(this.tbEnvanterUrunIsim);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(2, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 459);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Envanter Ekle";
            // 
            // btnEnvanterTemizle
            // 
            this.btnEnvanterTemizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(128)))));
            this.btnEnvanterTemizle.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEnvanterTemizle.Location = new System.Drawing.Point(12, 394);
            this.btnEnvanterTemizle.Name = "btnEnvanterTemizle";
            this.btnEnvanterTemizle.Size = new System.Drawing.Size(135, 44);
            this.btnEnvanterTemizle.TabIndex = 13;
            this.btnEnvanterTemizle.Text = "Temizle";
            this.btnEnvanterTemizle.UseVisualStyleBackColor = false;
            this.btnEnvanterTemizle.Click += new System.EventHandler(this.btnEnvanterTemizle_Click);
            // 
            // btnEnvanterEkle
            // 
            this.btnEnvanterEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(128)))));
            this.btnEnvanterEkle.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEnvanterEkle.Location = new System.Drawing.Point(178, 394);
            this.btnEnvanterEkle.Name = "btnEnvanterEkle";
            this.btnEnvanterEkle.Size = new System.Drawing.Size(135, 44);
            this.btnEnvanterEkle.TabIndex = 12;
            this.btnEnvanterEkle.Text = "Ekle";
            this.btnEnvanterEkle.UseVisualStyleBackColor = false;
            this.btnEnvanterEkle.Click += new System.EventHandler(this.btnEnvanterEkle_Click);
            // 
            // tbEnvanterSorumluBolum
            // 
            this.tbEnvanterSorumluBolum.Location = new System.Drawing.Point(175, 341);
            this.tbEnvanterSorumluBolum.Name = "tbEnvanterSorumluBolum";
            this.tbEnvanterSorumluBolum.Size = new System.Drawing.Size(138, 29);
            this.tbEnvanterSorumluBolum.TabIndex = 11;
            // 
            // tbEnvanterSorumluPersonel
            // 
            this.tbEnvanterSorumluPersonel.Location = new System.Drawing.Point(175, 287);
            this.tbEnvanterSorumluPersonel.Name = "tbEnvanterSorumluPersonel";
            this.tbEnvanterSorumluPersonel.Size = new System.Drawing.Size(138, 29);
            this.tbEnvanterSorumluPersonel.TabIndex = 10;
            // 
            // dtpEnvanterTarih
            // 
            this.dtpEnvanterTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnvanterTarih.Location = new System.Drawing.Point(175, 226);
            this.dtpEnvanterTarih.Name = "dtpEnvanterTarih";
            this.dtpEnvanterTarih.Size = new System.Drawing.Size(138, 29);
            this.dtpEnvanterTarih.TabIndex = 9;
            // 
            // cbEnvanterMalzemeDurum
            // 
            this.cbEnvanterMalzemeDurum.FormattingEnabled = true;
            this.cbEnvanterMalzemeDurum.Items.AddRange(new object[] {
            "Demirbaş",
            "Sarf"});
            this.cbEnvanterMalzemeDurum.Location = new System.Drawing.Point(175, 168);
            this.cbEnvanterMalzemeDurum.Name = "cbEnvanterMalzemeDurum";
            this.cbEnvanterMalzemeDurum.Size = new System.Drawing.Size(138, 31);
            this.cbEnvanterMalzemeDurum.TabIndex = 8;
            // 
            // tbEnvanterAdet
            // 
            this.tbEnvanterAdet.Location = new System.Drawing.Point(175, 108);
            this.tbEnvanterAdet.Name = "tbEnvanterAdet";
            this.tbEnvanterAdet.Size = new System.Drawing.Size(138, 29);
            this.tbEnvanterAdet.TabIndex = 7;
            // 
            // tbEnvanterUrunIsim
            // 
            this.tbEnvanterUrunIsim.Location = new System.Drawing.Point(175, 49);
            this.tbEnvanterUrunIsim.Name = "tbEnvanterUrunIsim";
            this.tbEnvanterUrunIsim.Size = new System.Drawing.Size(138, 29);
            this.tbEnvanterUrunIsim.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(8, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Bağlı Bölüm :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(8, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Bağlı Personel :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(8, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giriş Tarihi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(8, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Malzeme Durum :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(8, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stok Adedi :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(8, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı :";
            // 
            // dataGridEnvanter
            // 
            this.dataGridEnvanter.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridEnvanter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEnvanter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sil});
            this.dataGridEnvanter.Location = new System.Drawing.Point(370, 76);
            this.dataGridEnvanter.Name = "dataGridEnvanter";
            this.dataGridEnvanter.Size = new System.Drawing.Size(555, 417);
            this.dataGridEnvanter.TabIndex = 1;
            this.dataGridEnvanter.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridEnvanter_CellContentClick);
            // 
            // Sil
            // 
            this.Sil.HeaderText = "";
            this.Sil.Name = "Sil";
            this.Sil.Text = "Sil";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cbArizaBirim);
            this.groupBox2.Controls.Add(this.btnArizaTemizle);
            this.groupBox2.Controls.Add(this.btnArizaGonder);
            this.groupBox2.Controls.Add(this.tbArizaGonderimSebebi);
            this.groupBox2.Controls.Add(this.dtpArizaTarih);
            this.groupBox2.Controls.Add(this.tbArizaAdet);
            this.groupBox2.Controls.Add(this.tbArizaUrunIsim);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(2, 541);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(331, 459);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Arıza Kaydı Oluştur";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(8, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 23);
            this.label7.TabIndex = 15;
            this.label7.Text = "İlgili Servis :";
            // 
            // cbArizaBirim
            // 
            this.cbArizaBirim.FormattingEnabled = true;
            this.cbArizaBirim.Items.AddRange(new object[] {
            "Teknik Servis",
            "Bilgi İşlem"});
            this.cbArizaBirim.Location = new System.Drawing.Point(178, 282);
            this.cbArizaBirim.Name = "cbArizaBirim";
            this.cbArizaBirim.Size = new System.Drawing.Size(138, 31);
            this.cbArizaBirim.TabIndex = 14;
            // 
            // btnArizaTemizle
            // 
            this.btnArizaTemizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(128)))));
            this.btnArizaTemizle.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnArizaTemizle.Location = new System.Drawing.Point(12, 344);
            this.btnArizaTemizle.Name = "btnArizaTemizle";
            this.btnArizaTemizle.Size = new System.Drawing.Size(135, 44);
            this.btnArizaTemizle.TabIndex = 13;
            this.btnArizaTemizle.Text = "Temizle";
            this.btnArizaTemizle.UseVisualStyleBackColor = false;
            this.btnArizaTemizle.Click += new System.EventHandler(this.btnArizaTemizle_Click);
            // 
            // btnArizaGonder
            // 
            this.btnArizaGonder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(128)))));
            this.btnArizaGonder.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnArizaGonder.Location = new System.Drawing.Point(181, 344);
            this.btnArizaGonder.Name = "btnArizaGonder";
            this.btnArizaGonder.Size = new System.Drawing.Size(135, 44);
            this.btnArizaGonder.TabIndex = 12;
            this.btnArizaGonder.Text = "Arıza Gönder";
            this.btnArizaGonder.UseVisualStyleBackColor = false;
            this.btnArizaGonder.Click += new System.EventHandler(this.btnArizaGonder_Click);
            // 
            // tbArizaGonderimSebebi
            // 
            this.tbArizaGonderimSebebi.Location = new System.Drawing.Point(178, 228);
            this.tbArizaGonderimSebebi.Multiline = true;
            this.tbArizaGonderimSebebi.Name = "tbArizaGonderimSebebi";
            this.tbArizaGonderimSebebi.Size = new System.Drawing.Size(138, 29);
            this.tbArizaGonderimSebebi.TabIndex = 10;
            // 
            // dtpArizaTarih
            // 
            this.dtpArizaTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpArizaTarih.Location = new System.Drawing.Point(178, 170);
            this.dtpArizaTarih.Name = "dtpArizaTarih";
            this.dtpArizaTarih.Size = new System.Drawing.Size(138, 29);
            this.dtpArizaTarih.TabIndex = 9;
            // 
            // tbArizaAdet
            // 
            this.tbArizaAdet.Location = new System.Drawing.Point(178, 108);
            this.tbArizaAdet.Name = "tbArizaAdet";
            this.tbArizaAdet.Size = new System.Drawing.Size(138, 29);
            this.tbArizaAdet.TabIndex = 7;
            // 
            // tbArizaUrunIsim
            // 
            this.tbArizaUrunIsim.Location = new System.Drawing.Point(178, 49);
            this.tbArizaUrunIsim.Name = "tbArizaUrunIsim";
            this.tbArizaUrunIsim.Size = new System.Drawing.Size(138, 29);
            this.tbArizaUrunIsim.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(8, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 23);
            this.label8.TabIndex = 4;
            this.label8.Text = "Gönderim Sebebi :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(8, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 23);
            this.label9.TabIndex = 3;
            this.label9.Text = "Arıza Tarihi :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(8, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 23);
            this.label11.TabIndex = 1;
            this.label11.Text = "Ürün Adedi :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(8, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 23);
            this.label12.TabIndex = 0;
            this.label12.Text = "Ürün Adı :";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(370, 533);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(732, 145);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filtrele";
            // 
            // groupBox4
            // 
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
            this.groupBox4.Location = new System.Drawing.Point(958, 49);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(231, 379);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sırala";
            // 
            // btnSiralaYenile
            // 
            this.btnSiralaYenile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(128)))));
            this.btnSiralaYenile.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiralaYenile.Location = new System.Drawing.Point(123, 329);
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
            this.btnEnvanterSirala.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEnvanterSirala.Location = new System.Drawing.Point(16, 329);
            this.btnEnvanterSirala.Name = "btnEnvanterSirala";
            this.btnEnvanterSirala.Size = new System.Drawing.Size(101, 31);
            this.btnEnvanterSirala.TabIndex = 13;
            this.btnEnvanterSirala.Text = "Sırala";
            this.btnEnvanterSirala.UseVisualStyleBackColor = false;
            this.btnEnvanterSirala.Click += new System.EventHandler(this.btnEnvanterSirala_Click);
            // 
            // rbtnAdaGore
            // 
            this.rbtnAdaGore.AutoSize = true;
            this.rbtnAdaGore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnAdaGore.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtnAdaGore.Location = new System.Drawing.Point(32, 52);
            this.rbtnAdaGore.Name = "rbtnAdaGore";
            this.rbtnAdaGore.Size = new System.Drawing.Size(138, 27);
            this.rbtnAdaGore.TabIndex = 15;
            this.rbtnAdaGore.TabStop = true;
            this.rbtnAdaGore.Text = "İsim (A -> Z)\r\n";
            this.rbtnAdaGore.UseVisualStyleBackColor = true;
            // 
            // rbtnAdaGoreTers
            // 
            this.rbtnAdaGoreTers.AutoSize = true;
            this.rbtnAdaGoreTers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnAdaGoreTers.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtnAdaGoreTers.Location = new System.Drawing.Point(32, 98);
            this.rbtnAdaGoreTers.Name = "rbtnAdaGoreTers";
            this.rbtnAdaGoreTers.Size = new System.Drawing.Size(138, 27);
            this.rbtnAdaGoreTers.TabIndex = 16;
            this.rbtnAdaGoreTers.TabStop = true;
            this.rbtnAdaGoreTers.Text = "İsim (Z -> A)\r\n";
            this.rbtnAdaGoreTers.UseVisualStyleBackColor = true;
            // 
            // rbtnTarihYeni
            // 
            this.rbtnTarihYeni.AutoSize = true;
            this.rbtnTarihYeni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnTarihYeni.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtnTarihYeni.Location = new System.Drawing.Point(32, 142);
            this.rbtnTarihYeni.Name = "rbtnTarihYeni";
            this.rbtnTarihYeni.Size = new System.Drawing.Size(156, 27);
            this.rbtnTarihYeni.TabIndex = 17;
            this.rbtnTarihYeni.TabStop = true;
            this.rbtnTarihYeni.Text = "Yeniden Eskiye";
            this.rbtnTarihYeni.UseVisualStyleBackColor = true;
            // 
            // rbtnArtanStok
            // 
            this.rbtnArtanStok.AutoSize = true;
            this.rbtnArtanStok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnArtanStok.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtnArtanStok.Location = new System.Drawing.Point(32, 230);
            this.rbtnArtanStok.Name = "rbtnArtanStok";
            this.rbtnArtanStok.Size = new System.Drawing.Size(120, 27);
            this.rbtnArtanStok.TabIndex = 18;
            this.rbtnArtanStok.TabStop = true;
            this.rbtnArtanStok.Text = "Artan Stok";
            this.rbtnArtanStok.UseVisualStyleBackColor = true;
            // 
            // rbtnAzalanStok
            // 
            this.rbtnAzalanStok.AutoSize = true;
            this.rbtnAzalanStok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnAzalanStok.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtnAzalanStok.Location = new System.Drawing.Point(32, 274);
            this.rbtnAzalanStok.Name = "rbtnAzalanStok";
            this.rbtnAzalanStok.Size = new System.Drawing.Size(128, 27);
            this.rbtnAzalanStok.TabIndex = 19;
            this.rbtnAzalanStok.TabStop = true;
            this.rbtnAzalanStok.Text = "Azalan Stok";
            this.rbtnAzalanStok.UseVisualStyleBackColor = true;
            // 
            // rbtnTarihEski
            // 
            this.rbtnTarihEski.AutoSize = true;
            this.rbtnTarihEski.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnTarihEski.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtnTarihEski.Location = new System.Drawing.Point(32, 185);
            this.rbtnTarihEski.Name = "rbtnTarihEski";
            this.rbtnTarihEski.Size = new System.Drawing.Size(156, 27);
            this.rbtnTarihEski.TabIndex = 20;
            this.rbtnTarihEski.TabStop = true;
            this.rbtnTarihEski.Text = "Eskiden Yeniye";
            this.rbtnTarihEski.UseVisualStyleBackColor = true;
            // 
            // FrmEnvanter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1217, 684);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridEnvanter);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmEnvanter";
            this.Text = "FrmEnvanter";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmEnvanter_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEnvanter)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridEnvanter;
        private System.Windows.Forms.TextBox tbEnvanterSorumluBolum;
        private System.Windows.Forms.TextBox tbEnvanterSorumluPersonel;
        private System.Windows.Forms.DateTimePicker dtpEnvanterTarih;
        private System.Windows.Forms.ComboBox cbEnvanterMalzemeDurum;
        private System.Windows.Forms.TextBox tbEnvanterAdet;
        private System.Windows.Forms.TextBox tbEnvanterUrunIsim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEnvanterEkle;
        private System.Windows.Forms.Button btnEnvanterTemizle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnArizaTemizle;
        private System.Windows.Forms.Button btnArizaGonder;
        private System.Windows.Forms.TextBox tbArizaGonderimSebebi;
        private System.Windows.Forms.DateTimePicker dtpArizaTarih;
        private System.Windows.Forms.TextBox tbArizaAdet;
        private System.Windows.Forms.TextBox tbArizaUrunIsim;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbArizaBirim;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSiralaYenile;
        private System.Windows.Forms.Button btnEnvanterSirala;
        private System.Windows.Forms.DataGridViewButtonColumn Sil;
        private System.Windows.Forms.RadioButton rbtnAdaGore;
        private System.Windows.Forms.RadioButton rbtnTarihYeni;
        private System.Windows.Forms.RadioButton rbtnAdaGoreTers;
        private System.Windows.Forms.RadioButton rbtnAzalanStok;
        private System.Windows.Forms.RadioButton rbtnArtanStok;
        private System.Windows.Forms.RadioButton rbtnTarihEski;
    }
}
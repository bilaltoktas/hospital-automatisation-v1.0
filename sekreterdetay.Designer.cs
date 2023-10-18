
namespace WindowsFormsApp3
{
    partial class sekreterdetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sekreterdetay));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOluştur = new System.Windows.Forms.Button();
            this.richDuyuru = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.radioDolu = new System.Windows.Forms.RadioButton();
            this.radioBoş = new System.Windows.Forms.RadioButton();
            this.cmbDoktor = new System.Windows.Forms.ComboBox();
            this.cmbBranş = new System.Windows.Forms.ComboBox();
            this.mskTCkimlik = new System.Windows.Forms.MaskedTextBox();
            this.mskSaat = new System.Windows.Forms.MaskedTextBox();
            this.mskTarih = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataBranş = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataDoktor = new System.Windows.Forms.DataGridView();
            this.lblTC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lnkBilgi = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnRandevu = new System.Windows.Forms.Button();
            this.btnBranş = new System.Windows.Forms.Button();
            this.btnDoktor = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBranş)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDoktor)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnOluştur);
            this.groupBox2.Controls.Add(this.richDuyuru);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(12, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(262, 221);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DUYURU OLUŞTUR";
            // 
            // btnOluştur
            // 
            this.btnOluştur.BackColor = System.Drawing.Color.MistyRose;
            this.btnOluştur.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOluştur.Location = new System.Drawing.Point(19, 192);
            this.btnOluştur.Name = "btnOluştur";
            this.btnOluştur.Size = new System.Drawing.Size(220, 23);
            this.btnOluştur.TabIndex = 3;
            this.btnOluştur.Text = "OLUŞTUR";
            this.btnOluştur.UseVisualStyleBackColor = false;
            this.btnOluştur.Click += new System.EventHandler(this.btnOluştur_Click);
            // 
            // richDuyuru
            // 
            this.richDuyuru.BackColor = System.Drawing.Color.MistyRose;
            this.richDuyuru.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richDuyuru.Location = new System.Drawing.Point(6, 40);
            this.richDuyuru.Name = "richDuyuru";
            this.richDuyuru.Size = new System.Drawing.Size(250, 146);
            this.richDuyuru.TabIndex = 4;
            this.richDuyuru.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnKaydet);
            this.groupBox3.Controls.Add(this.radioDolu);
            this.groupBox3.Controls.Add(this.radioBoş);
            this.groupBox3.Controls.Add(this.cmbDoktor);
            this.groupBox3.Controls.Add(this.cmbBranş);
            this.groupBox3.Controls.Add(this.mskTCkimlik);
            this.groupBox3.Controls.Add(this.mskSaat);
            this.groupBox3.Controls.Add(this.mskTarih);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtID);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(280, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(266, 394);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "RANDEVU PANELİ";
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.MistyRose;
            this.btnKaydet.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(22, 349);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(220, 33);
            this.btnKaydet.TabIndex = 11;
            this.btnKaydet.Text = "RANDEVUYU KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // radioDolu
            // 
            this.radioDolu.AutoSize = true;
            this.radioDolu.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioDolu.Location = new System.Drawing.Point(175, 236);
            this.radioDolu.Name = "radioDolu";
            this.radioDolu.Size = new System.Drawing.Size(60, 20);
            this.radioDolu.TabIndex = 10;
            this.radioDolu.TabStop = true;
            this.radioDolu.Text = "DOLU";
            this.radioDolu.UseVisualStyleBackColor = true;
            // 
            // radioBoş
            // 
            this.radioBoş.AutoSize = true;
            this.radioBoş.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioBoş.Location = new System.Drawing.Point(117, 236);
            this.radioBoş.Name = "radioBoş";
            this.radioBoş.Size = new System.Drawing.Size(52, 20);
            this.radioBoş.TabIndex = 9;
            this.radioBoş.TabStop = true;
            this.radioBoş.Text = "BOŞ";
            this.radioBoş.UseVisualStyleBackColor = true;
            // 
            // cmbDoktor
            // 
            this.cmbDoktor.BackColor = System.Drawing.Color.MistyRose;
            this.cmbDoktor.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDoktor.FormattingEnabled = true;
            this.cmbDoktor.Location = new System.Drawing.Point(117, 171);
            this.cmbDoktor.Name = "cmbDoktor";
            this.cmbDoktor.Size = new System.Drawing.Size(139, 25);
            this.cmbDoktor.TabIndex = 4;
            // 
            // cmbBranş
            // 
            this.cmbBranş.BackColor = System.Drawing.Color.MistyRose;
            this.cmbBranş.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBranş.FormattingEnabled = true;
            this.cmbBranş.Location = new System.Drawing.Point(117, 138);
            this.cmbBranş.Name = "cmbBranş";
            this.cmbBranş.Size = new System.Drawing.Size(139, 25);
            this.cmbBranş.TabIndex = 8;
            this.cmbBranş.SelectedIndexChanged += new System.EventHandler(this.cmbBranş_SelectedIndexChanged);
            // 
            // mskTCkimlik
            // 
            this.mskTCkimlik.BackColor = System.Drawing.Color.MistyRose;
            this.mskTCkimlik.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTCkimlik.Location = new System.Drawing.Point(117, 202);
            this.mskTCkimlik.Mask = "00000000000";
            this.mskTCkimlik.Name = "mskTCkimlik";
            this.mskTCkimlik.Size = new System.Drawing.Size(139, 22);
            this.mskTCkimlik.TabIndex = 6;
            this.mskTCkimlik.ValidatingType = typeof(int);
            // 
            // mskSaat
            // 
            this.mskSaat.BackColor = System.Drawing.Color.MistyRose;
            this.mskSaat.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskSaat.Location = new System.Drawing.Point(117, 107);
            this.mskSaat.Mask = "00:00";
            this.mskSaat.Name = "mskSaat";
            this.mskSaat.Size = new System.Drawing.Size(139, 22);
            this.mskSaat.TabIndex = 7;
            this.mskSaat.ValidatingType = typeof(System.DateTime);
            // 
            // mskTarih
            // 
            this.mskTarih.BackColor = System.Drawing.Color.MistyRose;
            this.mskTarih.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTarih.Location = new System.Drawing.Point(117, 75);
            this.mskTarih.Mask = "00/00/0000";
            this.mskTarih.Name = "mskTarih";
            this.mskTarih.Size = new System.Drawing.Size(139, 22);
            this.mskTarih.TabIndex = 5;
            this.mskTarih.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(7, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "T.C. KİMLİK NO:";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.MistyRose;
            this.txtID.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtID.Location = new System.Drawing.Point(117, 37);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(139, 22);
            this.txtID.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(46, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "DOKTOR:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(54, 238);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "DURUM:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(65, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "TARİH:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(59, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "BRANŞ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(85, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "ID: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(70, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "SAAT:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataBranş);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(565, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(410, 232);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "BRANŞLAR";
            // 
            // dataBranş
            // 
            this.dataBranş.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataBranş.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBranş.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataBranş.Location = new System.Drawing.Point(3, 23);
            this.dataBranş.Name = "dataBranş";
            this.dataBranş.Size = new System.Drawing.Size(404, 206);
            this.dataBranş.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataDoktor);
            this.groupBox5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox5.Location = new System.Drawing.Point(562, 250);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(410, 227);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "DOKTORLAR";
            // 
            // dataDoktor
            // 
            this.dataDoktor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataDoktor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDoktor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataDoktor.Location = new System.Drawing.Point(3, 23);
            this.dataDoktor.Name = "dataDoktor";
            this.dataDoktor.Size = new System.Drawing.Size(404, 201);
            this.dataDoktor.TabIndex = 0;
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTC.Location = new System.Drawing.Point(118, 56);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(85, 17);
            this.lblTC.TabIndex = 2;
            this.lblTC.Text = "00000000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(16, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "TC KİMLİK NO:";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.Location = new System.Drawing.Point(118, 88);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(90, 17);
            this.lblAd.TabIndex = 3;
            this.lblAd.Text = "(NULL) (NULL)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(34, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "AD SOYAD:";
            // 
            // lnkBilgi
            // 
            this.lnkBilgi.AutoSize = true;
            this.lnkBilgi.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lnkBilgi.Location = new System.Drawing.Point(6, 125);
            this.lnkBilgi.Name = "lnkBilgi";
            this.lnkBilgi.Size = new System.Drawing.Size(110, 15);
            this.lnkBilgi.TabIndex = 1;
            this.lnkBilgi.TabStop = true;
            this.lnkBilgi.Text = "BİLGİLERİ GÜNCELLE";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lnkBilgi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblAd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblTC);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 167);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SEKRETER BİLGİ";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button1);
            this.groupBox6.Controls.Add(this.btnRandevu);
            this.groupBox6.Controls.Add(this.btnBranş);
            this.groupBox6.Controls.Add(this.btnDoktor);
            this.groupBox6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox6.Location = new System.Drawing.Point(12, 412);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(534, 65);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "HIZLI ERİŞİM PANELİ";
            // 
            // btnRandevu
            // 
            this.btnRandevu.BackColor = System.Drawing.Color.MistyRose;
            this.btnRandevu.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRandevu.Location = new System.Drawing.Point(262, 29);
            this.btnRandevu.Name = "btnRandevu";
            this.btnRandevu.Size = new System.Drawing.Size(127, 29);
            this.btnRandevu.TabIndex = 2;
            this.btnRandevu.Text = "RANDEVU LİSTESİ";
            this.btnRandevu.UseVisualStyleBackColor = false;
            this.btnRandevu.Click += new System.EventHandler(this.btnRandevu_Click);
            // 
            // btnBranş
            // 
            this.btnBranş.BackColor = System.Drawing.Color.MistyRose;
            this.btnBranş.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBranş.Location = new System.Drawing.Point(143, 29);
            this.btnBranş.Name = "btnBranş";
            this.btnBranş.Size = new System.Drawing.Size(113, 29);
            this.btnBranş.TabIndex = 1;
            this.btnBranş.Text = "BRANŞ PANELİ";
            this.btnBranş.UseVisualStyleBackColor = false;
            this.btnBranş.Click += new System.EventHandler(this.btnBranş_Click);
            // 
            // btnDoktor
            // 
            this.btnDoktor.BackColor = System.Drawing.Color.MistyRose;
            this.btnDoktor.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDoktor.Location = new System.Drawing.Point(9, 29);
            this.btnDoktor.Name = "btnDoktor";
            this.btnDoktor.Size = new System.Drawing.Size(128, 29);
            this.btnDoktor.TabIndex = 0;
            this.btnDoktor.Text = "DOKTOR PANELİ";
            this.btnDoktor.UseVisualStyleBackColor = false;
            this.btnDoktor.Click += new System.EventHandler(this.btnDoktor_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MistyRose;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(395, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "DUYURU EKRANI";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sekreterdetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(996, 487);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "sekreterdetay";
            this.Text = "SEKRETER BİLGİ EKRANI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.sekreterdetay_FormClosing);
            this.Load += new System.EventHandler(this.sekreterdetay_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataBranş)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataDoktor)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOluştur;
        private System.Windows.Forms.RichTextBox richDuyuru;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.MaskedTextBox mskTarih;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.RadioButton radioDolu;
        private System.Windows.Forms.RadioButton radioBoş;
        private System.Windows.Forms.ComboBox cmbDoktor;
        private System.Windows.Forms.ComboBox cmbBranş;
        private System.Windows.Forms.MaskedTextBox mskTCkimlik;
        private System.Windows.Forms.MaskedTextBox mskSaat;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataBranş;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataDoktor;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel lnkBilgi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnRandevu;
        private System.Windows.Forms.Button btnBranş;
        private System.Windows.Forms.Button btnDoktor;
        private System.Windows.Forms.Button button1;
    }
}
namespace Araç_Kiralama
{
    partial class frmSözleşme
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSözleşme));
            this.grpMusteri = new System.Windows.Forms.GroupBox();
            this.txtTcAra = new System.Windows.Forms.TextBox();
            this.lblTcAra = new System.Windows.Forms.Label();
            this.txtE_VerildigiYer = new System.Windows.Forms.TextBox();
            this.txtEhliyetTarihi = new System.Windows.Forms.TextBox();
            this.txtEhliyetNo = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.lblE_VerildigiYer = new System.Windows.Forms.Label();
            this.lblEhliyetTarihi = new System.Windows.Forms.Label();
            this.lblEhliyetNo = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.dataGridViewListe3 = new System.Windows.Forms.DataGridView();
            this.grpArac = new System.Windows.Forms.GroupBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.dateTimePickerDonus = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerCikis = new System.Windows.Forms.DateTimePicker();
            this.cmbKiraSekli = new System.Windows.Forms.ComboBox();
            this.cmbAraclar = new System.Windows.Forms.ComboBox();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.txtGun = new System.Windows.Forms.TextBox();
            this.txtKiraUcreti = new System.Windows.Forms.TextBox();
            this.txtRenk = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtSeri = new System.Windows.Forms.TextBox();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblRenk = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblSeri = new System.Windows.Forms.Label();
            this.lblMarka = new System.Windows.Forms.Label();
            this.lblAraclar = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.grpMusteri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListe3)).BeginInit();
            this.grpArac.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMusteri
            // 
            this.grpMusteri.Controls.Add(this.txtTcAra);
            this.grpMusteri.Controls.Add(this.lblTcAra);
            this.grpMusteri.Controls.Add(this.txtE_VerildigiYer);
            this.grpMusteri.Controls.Add(this.txtEhliyetTarihi);
            this.grpMusteri.Controls.Add(this.txtEhliyetNo);
            this.grpMusteri.Controls.Add(this.txtTelefon);
            this.grpMusteri.Controls.Add(this.txtAdSoyad);
            this.grpMusteri.Controls.Add(this.txtTC);
            this.grpMusteri.Controls.Add(this.lblE_VerildigiYer);
            this.grpMusteri.Controls.Add(this.lblEhliyetTarihi);
            this.grpMusteri.Controls.Add(this.lblEhliyetNo);
            this.grpMusteri.Controls.Add(this.lblTelefon);
            this.grpMusteri.Controls.Add(this.lblAdSoyad);
            this.grpMusteri.Controls.Add(this.lblTC);
            this.grpMusteri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpMusteri.Location = new System.Drawing.Point(51, 12);
            this.grpMusteri.Name = "grpMusteri";
            this.grpMusteri.Size = new System.Drawing.Size(408, 316);
            this.grpMusteri.TabIndex = 0;
            this.grpMusteri.TabStop = false;
            this.grpMusteri.Text = "Müşteri Bilgileri";
            this.grpMusteri.Enter += new System.EventHandler(this.grpMusteri_Enter);
            // 
            // txtTcAra
            // 
            this.txtTcAra.Location = new System.Drawing.Point(181, 20);
            this.txtTcAra.Name = "txtTcAra";
            this.txtTcAra.Size = new System.Drawing.Size(221, 27);
            this.txtTcAra.TabIndex = 13;
            this.txtTcAra.TextChanged += new System.EventHandler(this.txtTcAra_TextChanged);
            // 
            // lblTcAra
            // 
            this.lblTcAra.AutoSize = true;
            this.lblTcAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTcAra.Location = new System.Drawing.Point(99, 23);
            this.lblTcAra.Name = "lblTcAra";
            this.lblTcAra.Size = new System.Drawing.Size(68, 20);
            this.lblTcAra.TabIndex = 12;
            this.lblTcAra.Text = "TC Ara";
            // 
            // txtE_VerildigiYer
            // 
            this.txtE_VerildigiYer.Location = new System.Drawing.Point(181, 278);
            this.txtE_VerildigiYer.Name = "txtE_VerildigiYer";
            this.txtE_VerildigiYer.Size = new System.Drawing.Size(221, 27);
            this.txtE_VerildigiYer.TabIndex = 11;
            // 
            // txtEhliyetTarihi
            // 
            this.txtEhliyetTarihi.Location = new System.Drawing.Point(181, 235);
            this.txtEhliyetTarihi.Name = "txtEhliyetTarihi";
            this.txtEhliyetTarihi.Size = new System.Drawing.Size(221, 27);
            this.txtEhliyetTarihi.TabIndex = 10;
            // 
            // txtEhliyetNo
            // 
            this.txtEhliyetNo.Location = new System.Drawing.Point(181, 192);
            this.txtEhliyetNo.Name = "txtEhliyetNo";
            this.txtEhliyetNo.Size = new System.Drawing.Size(221, 27);
            this.txtEhliyetNo.TabIndex = 9;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(181, 149);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(221, 27);
            this.txtTelefon.TabIndex = 8;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(181, 106);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(221, 27);
            this.txtAdSoyad.TabIndex = 7;
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(181, 63);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(221, 27);
            this.txtTC.TabIndex = 6;
            this.txtTC.TextChanged += new System.EventHandler(this.txtTC_TextChanged);
            // 
            // lblE_VerildigiYer
            // 
            this.lblE_VerildigiYer.AutoSize = true;
            this.lblE_VerildigiYer.Location = new System.Drawing.Point(48, 278);
            this.lblE_VerildigiYer.Name = "lblE_VerildigiYer";
            this.lblE_VerildigiYer.Size = new System.Drawing.Size(119, 20);
            this.lblE_VerildigiYer.TabIndex = 5;
            this.lblE_VerildigiYer.Text = "E_Verildiği Yer";
            // 
            // lblEhliyetTarihi
            // 
            this.lblEhliyetTarihi.AutoSize = true;
            this.lblEhliyetTarihi.Location = new System.Drawing.Point(61, 235);
            this.lblEhliyetTarihi.Name = "lblEhliyetTarihi";
            this.lblEhliyetTarihi.Size = new System.Drawing.Size(106, 20);
            this.lblEhliyetTarihi.TabIndex = 4;
            this.lblEhliyetTarihi.Text = "Ehliyet Tarihi";
            // 
            // lblEhliyetNo
            // 
            this.lblEhliyetNo.AutoSize = true;
            this.lblEhliyetNo.Location = new System.Drawing.Point(82, 192);
            this.lblEhliyetNo.Name = "lblEhliyetNo";
            this.lblEhliyetNo.Size = new System.Drawing.Size(85, 20);
            this.lblEhliyetNo.TabIndex = 3;
            this.lblEhliyetNo.Text = "Ehliyet No";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(103, 149);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(64, 20);
            this.lblTelefon.TabIndex = 2;
            this.lblTelefon.Text = "Telefon";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(87, 106);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(80, 20);
            this.lblAdSoyad.TabIndex = 1;
            this.lblAdSoyad.Text = "Ad Soyad";
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Location = new System.Drawing.Point(139, 63);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(31, 20);
            this.lblTC.TabIndex = 0;
            this.lblTC.Text = "TC";
            // 
            // dataGridViewListe3
            // 
            this.dataGridViewListe3.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewListe3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListe3.Location = new System.Drawing.Point(12, 334);
            this.dataGridViewListe3.Name = "dataGridViewListe3";
            this.dataGridViewListe3.RowHeadersWidth = 51;
            this.dataGridViewListe3.RowTemplate.Height = 24;
            this.dataGridViewListe3.Size = new System.Drawing.Size(1248, 382);
            this.dataGridViewListe3.TabIndex = 1;
            this.dataGridViewListe3.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListe3_CellDoubleClick);
            // 
            // grpArac
            // 
            this.grpArac.Controls.Add(this.btnTemizle);
            this.grpArac.Controls.Add(this.btnGuncelle);
            this.grpArac.Controls.Add(this.btnEkle);
            this.grpArac.Controls.Add(this.dateTimePickerDonus);
            this.grpArac.Controls.Add(this.dateTimePickerCikis);
            this.grpArac.Controls.Add(this.cmbKiraSekli);
            this.grpArac.Controls.Add(this.cmbAraclar);
            this.grpArac.Controls.Add(this.txtTutar);
            this.grpArac.Controls.Add(this.txtGun);
            this.grpArac.Controls.Add(this.txtKiraUcreti);
            this.grpArac.Controls.Add(this.txtRenk);
            this.grpArac.Controls.Add(this.txtModel);
            this.grpArac.Controls.Add(this.txtSeri);
            this.grpArac.Controls.Add(this.txtMarka);
            this.grpArac.Controls.Add(this.label11);
            this.grpArac.Controls.Add(this.label10);
            this.grpArac.Controls.Add(this.label9);
            this.grpArac.Controls.Add(this.label8);
            this.grpArac.Controls.Add(this.label7);
            this.grpArac.Controls.Add(this.label6);
            this.grpArac.Controls.Add(this.lblRenk);
            this.grpArac.Controls.Add(this.lblModel);
            this.grpArac.Controls.Add(this.lblSeri);
            this.grpArac.Controls.Add(this.lblMarka);
            this.grpArac.Controls.Add(this.lblAraclar);
            this.grpArac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpArac.Location = new System.Drawing.Point(544, 12);
            this.grpArac.Name = "grpArac";
            this.grpArac.Size = new System.Drawing.Size(549, 316);
            this.grpArac.TabIndex = 2;
            this.grpArac.TabStop = false;
            this.grpArac.Text = "Araç Bilgileri";
            this.grpArac.Enter += new System.EventHandler(this.grpArac_Enter);
            // 
            // btnTemizle
            // 
            this.btnTemizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTemizle.ImageIndex = 1;
            this.btnTemizle.ImageList = this.ımageList1;
            this.btnTemizle.Location = new System.Drawing.Point(378, 268);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(154, 32);
            this.btnTemizle.TabIndex = 24;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "add.png");
            this.ımageList1.Images.SetKeyName(1, "sil.png");
            this.ımageList1.Images.SetKeyName(2, "guncelle.png");
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuncelle.ImageIndex = 2;
            this.btnGuncelle.ImageList = this.ımageList1;
            this.btnGuncelle.Location = new System.Drawing.Point(185, 268);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(187, 32);
            this.btnGuncelle.TabIndex = 23;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkle.ImageIndex = 0;
            this.btnEkle.ImageList = this.ımageList1;
            this.btnEkle.Location = new System.Drawing.Point(18, 268);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(154, 32);
            this.btnEkle.TabIndex = 22;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // dateTimePickerDonus
            // 
            this.dateTimePickerDonus.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDonus.Location = new System.Drawing.Point(386, 230);
            this.dateTimePickerDonus.Name = "dateTimePickerDonus";
            this.dateTimePickerDonus.Size = new System.Drawing.Size(157, 27);
            this.dateTimePickerDonus.TabIndex = 21;
            // 
            // dateTimePickerCikis
            // 
            this.dateTimePickerCikis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerCikis.Location = new System.Drawing.Point(386, 190);
            this.dateTimePickerCikis.Name = "dateTimePickerCikis";
            this.dateTimePickerCikis.Size = new System.Drawing.Size(157, 27);
            this.dateTimePickerCikis.TabIndex = 20;
            // 
            // cmbKiraSekli
            // 
            this.cmbKiraSekli.FormattingEnabled = true;
            this.cmbKiraSekli.Items.AddRange(new object[] {
            "Günlük",
            "Haftalık",
            "Aylık"});
            this.cmbKiraSekli.Location = new System.Drawing.Point(387, 29);
            this.cmbKiraSekli.Name = "cmbKiraSekli";
            this.cmbKiraSekli.Size = new System.Drawing.Size(157, 28);
            this.cmbKiraSekli.TabIndex = 19;
            this.cmbKiraSekli.SelectedIndexChanged += new System.EventHandler(this.cmbKiraSekli_SelectedIndexChanged);
            // 
            // cmbAraclar
            // 
            this.cmbAraclar.FormattingEnabled = true;
            this.cmbAraclar.Location = new System.Drawing.Point(91, 37);
            this.cmbAraclar.Name = "cmbAraclar";
            this.cmbAraclar.Size = new System.Drawing.Size(130, 28);
            this.cmbAraclar.TabIndex = 18;
            this.cmbAraclar.SelectedIndexChanged += new System.EventHandler(this.cmbAraclar_SelectedIndexChanged);
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(387, 150);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(157, 27);
            this.txtTutar.TabIndex = 17;
            // 
            // txtGun
            // 
            this.txtGun.Location = new System.Drawing.Point(387, 110);
            this.txtGun.Name = "txtGun";
            this.txtGun.Size = new System.Drawing.Size(157, 27);
            this.txtGun.TabIndex = 16;
            // 
            // txtKiraUcreti
            // 
            this.txtKiraUcreti.Location = new System.Drawing.Point(387, 70);
            this.txtKiraUcreti.Name = "txtKiraUcreti";
            this.txtKiraUcreti.Size = new System.Drawing.Size(157, 27);
            this.txtKiraUcreti.TabIndex = 15;
            // 
            // txtRenk
            // 
            this.txtRenk.Location = new System.Drawing.Point(91, 226);
            this.txtRenk.Name = "txtRenk";
            this.txtRenk.Size = new System.Drawing.Size(130, 27);
            this.txtRenk.TabIndex = 14;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(91, 179);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(130, 27);
            this.txtModel.TabIndex = 13;
            // 
            // txtSeri
            // 
            this.txtSeri.Location = new System.Drawing.Point(91, 132);
            this.txtSeri.Name = "txtSeri";
            this.txtSeri.Size = new System.Drawing.Size(130, 27);
            this.txtSeri.TabIndex = 12;
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(91, 85);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(130, 27);
            this.txtMarka.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(275, 224);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "Dönüş Tarihi";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(287, 185);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Çıkış Tarihi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(332, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Tutar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(340, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Gün";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(291, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Kira Ücreti";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(300, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Kira Şekli";
            // 
            // lblRenk
            // 
            this.lblRenk.AutoSize = true;
            this.lblRenk.Location = new System.Drawing.Point(35, 225);
            this.lblRenk.Name = "lblRenk";
            this.lblRenk.Size = new System.Drawing.Size(47, 20);
            this.lblRenk.TabIndex = 4;
            this.lblRenk.Text = "Renk";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(28, 178);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(54, 20);
            this.lblModel.TabIndex = 3;
            this.lblModel.Text = "Model";
            // 
            // lblSeri
            // 
            this.lblSeri.AutoSize = true;
            this.lblSeri.Location = new System.Drawing.Point(43, 131);
            this.lblSeri.Name = "lblSeri";
            this.lblSeri.Size = new System.Drawing.Size(39, 20);
            this.lblSeri.TabIndex = 2;
            this.lblSeri.Text = "Seri";
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.Location = new System.Drawing.Point(27, 84);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(55, 20);
            this.lblMarka.TabIndex = 1;
            this.lblMarka.Text = "Marka";
            // 
            // lblAraclar
            // 
            this.lblAraclar.AutoSize = true;
            this.lblAraclar.Location = new System.Drawing.Point(19, 37);
            this.lblAraclar.Name = "lblAraclar";
            this.lblAraclar.Size = new System.Drawing.Size(63, 20);
            this.lblAraclar.TabIndex = 0;
            this.lblAraclar.Text = "Araçlar";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.Location = new System.Drawing.Point(1110, 23);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(150, 305);
            this.btnHesapla.TabIndex = 25;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // frmSözleşme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1272, 728);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.grpArac);
            this.Controls.Add(this.dataGridViewListe3);
            this.Controls.Add(this.grpMusteri);
            this.Name = "frmSözleşme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sözleşme ve Satışlar Sayfası";
            this.Load += new System.EventHandler(this.frmSözleşme_Load);
            this.grpMusteri.ResumeLayout(false);
            this.grpMusteri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListe3)).EndInit();
            this.grpArac.ResumeLayout(false);
            this.grpArac.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMusteri;
        private System.Windows.Forms.TextBox txtE_VerildigiYer;
        private System.Windows.Forms.TextBox txtEhliyetTarihi;
        private System.Windows.Forms.TextBox txtEhliyetNo;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.Label lblE_VerildigiYer;
        private System.Windows.Forms.Label lblEhliyetTarihi;
        private System.Windows.Forms.Label lblEhliyetNo;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.DataGridView dataGridViewListe3;
        private System.Windows.Forms.GroupBox grpArac;
        private System.Windows.Forms.DateTimePicker dateTimePickerDonus;
        private System.Windows.Forms.DateTimePicker dateTimePickerCikis;
        private System.Windows.Forms.ComboBox cmbKiraSekli;
        private System.Windows.Forms.ComboBox cmbAraclar;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.TextBox txtGun;
        private System.Windows.Forms.TextBox txtKiraUcreti;
        private System.Windows.Forms.TextBox txtRenk;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtSeri;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblRenk;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblSeri;
        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.Label lblAraclar;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.TextBox txtTcAra;
        private System.Windows.Forms.Label lblTcAra;
        private System.Windows.Forms.ImageList ımageList1;
    }
}
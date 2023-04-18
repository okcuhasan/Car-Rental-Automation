namespace Araç_Kiralama
{
    partial class frmAraçKayıt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAraçKayıt));
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.cmbMarka = new System.Windows.Forms.ComboBox();
            this.cmbSeri = new System.Windows.Forms.ComboBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtKm = new System.Windows.Forms.TextBox();
            this.txtRenk = new System.Windows.Forms.TextBox();
            this.cmbYakit = new System.Windows.Forms.ComboBox();
            this.txtKiraUcreti = new System.Windows.Forms.TextBox();
            this.lblPlaka = new System.Windows.Forms.Label();
            this.lblMarka = new System.Windows.Forms.Label();
            this.lblSeri = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblRenk = new System.Windows.Forms.Label();
            this.lblKm = new System.Windows.Forms.Label();
            this.lblYakıt = new System.Windows.Forms.Label();
            this.lblKiraUcreti = new System.Windows.Forms.Label();
            this.pictureBoxResim = new System.Windows.Forms.PictureBox();
            this.btnResimEkle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnKayit = new System.Windows.Forms.Button();
            this.btnİptal = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResim)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(139, 29);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(174, 22);
            this.txtPlaka.TabIndex = 0;
            // 
            // cmbMarka
            // 
            this.cmbMarka.FormattingEnabled = true;
            this.cmbMarka.Items.AddRange(new object[] {
            "Opel",
            "Renault",
            "Fiat",
            "Ford"});
            this.cmbMarka.Location = new System.Drawing.Point(139, 65);
            this.cmbMarka.Name = "cmbMarka";
            this.cmbMarka.Size = new System.Drawing.Size(174, 24);
            this.cmbMarka.TabIndex = 1;
            this.cmbMarka.SelectedIndexChanged += new System.EventHandler(this.cmbMarka_SelectedIndexChanged);
            // 
            // cmbSeri
            // 
            this.cmbSeri.FormattingEnabled = true;
            this.cmbSeri.Location = new System.Drawing.Point(139, 103);
            this.cmbSeri.Name = "cmbSeri";
            this.cmbSeri.Size = new System.Drawing.Size(174, 24);
            this.cmbSeri.TabIndex = 2;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(139, 141);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(174, 22);
            this.txtModel.TabIndex = 3;
            // 
            // txtKm
            // 
            this.txtKm.Location = new System.Drawing.Point(139, 213);
            this.txtKm.Name = "txtKm";
            this.txtKm.Size = new System.Drawing.Size(174, 22);
            this.txtKm.TabIndex = 4;
            // 
            // txtRenk
            // 
            this.txtRenk.Location = new System.Drawing.Point(139, 177);
            this.txtRenk.Name = "txtRenk";
            this.txtRenk.Size = new System.Drawing.Size(174, 22);
            this.txtRenk.TabIndex = 5;
            // 
            // cmbYakit
            // 
            this.cmbYakit.FormattingEnabled = true;
            this.cmbYakit.Items.AddRange(new object[] {
            "Dizel",
            "Benzin",
            "Benzin+Lpg"});
            this.cmbYakit.Location = new System.Drawing.Point(139, 249);
            this.cmbYakit.Name = "cmbYakit";
            this.cmbYakit.Size = new System.Drawing.Size(174, 24);
            this.cmbYakit.TabIndex = 6;
            // 
            // txtKiraUcreti
            // 
            this.txtKiraUcreti.Location = new System.Drawing.Point(139, 287);
            this.txtKiraUcreti.Name = "txtKiraUcreti";
            this.txtKiraUcreti.Size = new System.Drawing.Size(174, 22);
            this.txtKiraUcreti.TabIndex = 7;
            // 
            // lblPlaka
            // 
            this.lblPlaka.AutoSize = true;
            this.lblPlaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPlaka.Location = new System.Drawing.Point(78, 29);
            this.lblPlaka.Name = "lblPlaka";
            this.lblPlaka.Size = new System.Drawing.Size(50, 20);
            this.lblPlaka.TabIndex = 8;
            this.lblPlaka.Text = "Plaka";
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMarka.Location = new System.Drawing.Point(73, 65);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(55, 20);
            this.lblMarka.TabIndex = 9;
            this.lblMarka.Text = "Marka";
            // 
            // lblSeri
            // 
            this.lblSeri.AutoSize = true;
            this.lblSeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSeri.Location = new System.Drawing.Point(89, 101);
            this.lblSeri.Name = "lblSeri";
            this.lblSeri.Size = new System.Drawing.Size(39, 20);
            this.lblSeri.TabIndex = 10;
            this.lblSeri.Text = "Seri";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblModel.Location = new System.Drawing.Point(44, 137);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(84, 20);
            this.lblModel.TabIndex = 11;
            this.lblModel.Text = "Model(Yıl)";
            // 
            // lblRenk
            // 
            this.lblRenk.AutoSize = true;
            this.lblRenk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRenk.Location = new System.Drawing.Point(81, 173);
            this.lblRenk.Name = "lblRenk";
            this.lblRenk.Size = new System.Drawing.Size(47, 20);
            this.lblRenk.TabIndex = 12;
            this.lblRenk.Text = "Renk";
            // 
            // lblKm
            // 
            this.lblKm.AutoSize = true;
            this.lblKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKm.Location = new System.Drawing.Point(94, 209);
            this.lblKm.Name = "lblKm";
            this.lblKm.Size = new System.Drawing.Size(34, 20);
            this.lblKm.TabIndex = 13;
            this.lblKm.Text = "Km";
            // 
            // lblYakıt
            // 
            this.lblYakıt.AutoSize = true;
            this.lblYakıt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYakıt.Location = new System.Drawing.Point(83, 245);
            this.lblYakıt.Name = "lblYakıt";
            this.lblYakıt.Size = new System.Drawing.Size(45, 20);
            this.lblYakıt.TabIndex = 14;
            this.lblYakıt.Text = "Yakıt";
            // 
            // lblKiraUcreti
            // 
            this.lblKiraUcreti.AutoSize = true;
            this.lblKiraUcreti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKiraUcreti.Location = new System.Drawing.Point(39, 281);
            this.lblKiraUcreti.Name = "lblKiraUcreti";
            this.lblKiraUcreti.Size = new System.Drawing.Size(89, 20);
            this.lblKiraUcreti.TabIndex = 15;
            this.lblKiraUcreti.Text = "Kira Ücreti";
            // 
            // pictureBoxResim
            // 
            this.pictureBoxResim.Location = new System.Drawing.Point(330, 29);
            this.pictureBoxResim.Name = "pictureBoxResim";
            this.pictureBoxResim.Size = new System.Drawing.Size(422, 113);
            this.pictureBoxResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxResim.TabIndex = 16;
            this.pictureBoxResim.TabStop = false;
            // 
            // btnResimEkle
            // 
            this.btnResimEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnResimEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResimEkle.ImageIndex = 0;
            this.btnResimEkle.ImageList = this.ımageList1;
            this.btnResimEkle.Location = new System.Drawing.Point(469, 163);
            this.btnResimEkle.Name = "btnResimEkle";
            this.btnResimEkle.Size = new System.Drawing.Size(164, 48);
            this.btnResimEkle.TabIndex = 18;
            this.btnResimEkle.Text = "Resim Ekle";
            this.btnResimEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnResimEkle.UseVisualStyleBackColor = true;
            this.btnResimEkle.Click += new System.EventHandler(this.btnResimEkle_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "picture.jpg");
            this.ımageList1.Images.SetKeyName(1, "kayıt.png");
            this.ımageList1.Images.SetKeyName(2, "cancel.png");
            // 
            // btnKayit
            // 
            this.btnKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKayit.ImageIndex = 1;
            this.btnKayit.ImageList = this.ımageList1;
            this.btnKayit.Location = new System.Drawing.Point(359, 329);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(125, 48);
            this.btnKayit.TabIndex = 19;
            this.btnKayit.Text = "Kayıt";
            this.btnKayit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKayit.UseVisualStyleBackColor = true;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // btnİptal
            // 
            this.btnİptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnİptal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnİptal.ImageKey = "cancel.png";
            this.btnİptal.ImageList = this.ımageList1;
            this.btnİptal.Location = new System.Drawing.Point(359, 402);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(125, 48);
            this.btnİptal.TabIndex = 20;
            this.btnİptal.Text = "İptal";
            this.btnİptal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnİptal.UseVisualStyleBackColor = true;
            this.btnİptal.Click += new System.EventHandler(this.btnİptal_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmAraçKayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(764, 462);
            this.Controls.Add(this.btnİptal);
            this.Controls.Add(this.btnKayit);
            this.Controls.Add(this.btnResimEkle);
            this.Controls.Add(this.pictureBoxResim);
            this.Controls.Add(this.lblKiraUcreti);
            this.Controls.Add(this.lblYakıt);
            this.Controls.Add(this.lblKm);
            this.Controls.Add(this.lblRenk);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblSeri);
            this.Controls.Add(this.lblMarka);
            this.Controls.Add(this.lblPlaka);
            this.Controls.Add(this.txtKiraUcreti);
            this.Controls.Add(this.cmbYakit);
            this.Controls.Add(this.txtRenk);
            this.Controls.Add(this.txtKm);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.cmbSeri);
            this.Controls.Add(this.cmbMarka);
            this.Controls.Add(this.txtPlaka);
            this.Name = "frmAraçKayıt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç Kayıt Sayfası";
            this.Load += new System.EventHandler(this.frmAraçKayıt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.ComboBox cmbMarka;
        private System.Windows.Forms.ComboBox cmbSeri;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtKm;
        private System.Windows.Forms.TextBox txtRenk;
        private System.Windows.Forms.ComboBox cmbYakit;
        private System.Windows.Forms.TextBox txtKiraUcreti;
        private System.Windows.Forms.Label lblPlaka;
        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.Label lblSeri;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblRenk;
        private System.Windows.Forms.Label lblKm;
        private System.Windows.Forms.Label lblYakıt;
        private System.Windows.Forms.Label lblKiraUcreti;
        private System.Windows.Forms.PictureBox pictureBoxResim;
        private System.Windows.Forms.Button btnResimEkle;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.Button btnİptal;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
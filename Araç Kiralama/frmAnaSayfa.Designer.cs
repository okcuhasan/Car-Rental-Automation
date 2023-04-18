namespace Araç_Kiralama
{
    partial class frmAnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnaSayfa));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAracKayit = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnAracListeleme = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnSozlesme = new System.Windows.Forms.Button();
            this.btnMusteriListeleme = new System.Windows.Forms.Button();
            this.btnMusteriEkleme = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnAracKayit);
            this.panel1.Controls.Add(this.btnAracListeleme);
            this.panel1.Controls.Add(this.btnCikis);
            this.panel1.Controls.Add(this.btnSozlesme);
            this.panel1.Controls.Add(this.btnMusteriListeleme);
            this.panel1.Controls.Add(this.btnMusteriEkleme);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1438, 100);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnAracKayit
            // 
            this.btnAracKayit.BackColor = System.Drawing.Color.White;
            this.btnAracKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAracKayit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAracKayit.ImageIndex = 3;
            this.btnAracKayit.ImageList = this.ımageList1;
            this.btnAracKayit.Location = new System.Drawing.Point(486, 12);
            this.btnAracKayit.Name = "btnAracKayit";
            this.btnAracKayit.Size = new System.Drawing.Size(232, 75);
            this.btnAracKayit.TabIndex = 6;
            this.btnAracKayit.Text = "Araç Kayıt";
            this.btnAracKayit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAracKayit.UseVisualStyleBackColor = false;
            this.btnAracKayit.Click += new System.EventHandler(this.btnAracKayit_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "exit.png");
            this.ımageList1.Images.SetKeyName(1, "sales.png");
            this.ımageList1.Images.SetKeyName(2, "agreement.png");
            this.ımageList1.Images.SetKeyName(3, "car.png");
            this.ımageList1.Images.SetKeyName(4, "car2.png");
            this.ımageList1.Images.SetKeyName(5, "customer2.png");
            this.ımageList1.Images.SetKeyName(6, "customer.png");
            // 
            // btnAracListeleme
            // 
            this.btnAracListeleme.BackColor = System.Drawing.Color.White;
            this.btnAracListeleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAracListeleme.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAracListeleme.ImageIndex = 4;
            this.btnAracListeleme.ImageList = this.ımageList1;
            this.btnAracListeleme.Location = new System.Drawing.Point(723, 12);
            this.btnAracListeleme.Name = "btnAracListeleme";
            this.btnAracListeleme.Size = new System.Drawing.Size(232, 75);
            this.btnAracListeleme.TabIndex = 5;
            this.btnAracListeleme.Text = "Araç Listeleme";
            this.btnAracListeleme.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAracListeleme.UseVisualStyleBackColor = false;
            this.btnAracListeleme.Click += new System.EventHandler(this.btnAracListeleme_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.White;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCikis.ImageIndex = 0;
            this.btnCikis.ImageList = this.ımageList1;
            this.btnCikis.Location = new System.Drawing.Point(1197, 12);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(232, 75);
            this.btnCikis.TabIndex = 3;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnSozlesme
            // 
            this.btnSozlesme.BackColor = System.Drawing.Color.White;
            this.btnSozlesme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSozlesme.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSozlesme.ImageIndex = 2;
            this.btnSozlesme.ImageList = this.ımageList1;
            this.btnSozlesme.Location = new System.Drawing.Point(960, 12);
            this.btnSozlesme.Name = "btnSozlesme";
            this.btnSozlesme.Size = new System.Drawing.Size(232, 75);
            this.btnSozlesme.TabIndex = 2;
            this.btnSozlesme.Text = "Sözleşme ve Satışlar";
            this.btnSozlesme.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSozlesme.UseVisualStyleBackColor = false;
            this.btnSozlesme.Click += new System.EventHandler(this.btnSozlesme_Click);
            // 
            // btnMusteriListeleme
            // 
            this.btnMusteriListeleme.BackColor = System.Drawing.Color.White;
            this.btnMusteriListeleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriListeleme.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMusteriListeleme.ImageIndex = 5;
            this.btnMusteriListeleme.ImageList = this.ımageList1;
            this.btnMusteriListeleme.Location = new System.Drawing.Point(249, 12);
            this.btnMusteriListeleme.Name = "btnMusteriListeleme";
            this.btnMusteriListeleme.Size = new System.Drawing.Size(232, 75);
            this.btnMusteriListeleme.TabIndex = 1;
            this.btnMusteriListeleme.Text = "Müşteri Listeleme";
            this.btnMusteriListeleme.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMusteriListeleme.UseVisualStyleBackColor = false;
            this.btnMusteriListeleme.Click += new System.EventHandler(this.btnMusteriListeleme_Click);
            // 
            // btnMusteriEkleme
            // 
            this.btnMusteriEkleme.BackColor = System.Drawing.Color.White;
            this.btnMusteriEkleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriEkleme.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMusteriEkleme.ImageIndex = 6;
            this.btnMusteriEkleme.ImageList = this.ımageList1;
            this.btnMusteriEkleme.Location = new System.Drawing.Point(12, 12);
            this.btnMusteriEkleme.Name = "btnMusteriEkleme";
            this.btnMusteriEkleme.Size = new System.Drawing.Size(232, 75);
            this.btnMusteriEkleme.TabIndex = 0;
            this.btnMusteriEkleme.Text = "Müşteri Ekleme";
            this.btnMusteriEkleme.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMusteriEkleme.UseVisualStyleBackColor = false;
            this.btnMusteriEkleme.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::Araç_Kiralama.Properties.Resources.araç;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1438, 428);
            this.Controls.Add(this.panel1);
            this.Name = "frmAnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMusteriEkleme;
        private System.Windows.Forms.Button btnAracKayit;
        private System.Windows.Forms.Button btnAracListeleme;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnSozlesme;
        private System.Windows.Forms.Button btnMusteriListeleme;
        private System.Windows.Forms.ImageList ımageList1;
    }
}


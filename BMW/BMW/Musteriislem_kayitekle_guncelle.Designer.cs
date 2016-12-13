namespace BMW
{
    partial class Musteriislem_kayitekle_guncelle
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
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Musterigrid = new DevExpress.XtraGrid.GridControl();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.kayitekle = new System.Windows.Forms.Button();
            this.yenikayit = new System.Windows.Forms.Button();
            this.kayitguncelle = new System.Windows.Forms.Button();
            this.geridon = new System.Windows.Forms.Button();
            this.M_kodu = new System.Windows.Forms.TextBox();
            this.M_tcno = new System.Windows.Forms.TextBox();
            this.M_adi = new System.Windows.Forms.TextBox();
            this.M_soyadi = new System.Windows.Forms.TextBox();
            this.M_tel = new System.Windows.Forms.TextBox();
            this.M_email = new System.Windows.Forms.TextBox();
            this.Il_kodu = new System.Windows.Forms.TextBox();
            this.Ilce_kodu = new System.Windows.Forms.TextBox();
            this.Adress = new System.Windows.Forms.TextBox();
            this.M_turu_kodu = new System.Windows.Forms.TextBox();
            this.mkodu = new System.Windows.Forms.Label();
            this.mtcno = new System.Windows.Forms.Label();
            this.madi = new System.Windows.Forms.Label();
            this.msoyadi = new System.Windows.Forms.Label();
            this.mtel = new System.Windows.Forms.Label();
            this.memail = new System.Windows.Forms.Label();
            this.ilkodu = new System.Windows.Forms.Label();
            this.ilcekodu = new System.Windows.Forms.Label();
            this.adres = new System.Windows.Forms.Label();
            this.mturukodu = new System.Windows.Forms.Label();
            this.sonrakikayit = new System.Windows.Forms.Button();
            this.oncekikayit = new System.Windows.Forms.Button();
            this.ılkkayit = new System.Windows.Forms.Button();
            this.sonkayit = new System.Windows.Forms.Button();
            this.mid = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Musterigrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.Musterigrid;
            this.gridView1.Name = "gridView1";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.mid);
            this.tabPage1.Controls.Add(this.sonkayit);
            this.tabPage1.Controls.Add(this.ılkkayit);
            this.tabPage1.Controls.Add(this.oncekikayit);
            this.tabPage1.Controls.Add(this.sonrakikayit);
            this.tabPage1.Controls.Add(this.mturukodu);
            this.tabPage1.Controls.Add(this.adres);
            this.tabPage1.Controls.Add(this.ilcekodu);
            this.tabPage1.Controls.Add(this.ilkodu);
            this.tabPage1.Controls.Add(this.memail);
            this.tabPage1.Controls.Add(this.mtel);
            this.tabPage1.Controls.Add(this.msoyadi);
            this.tabPage1.Controls.Add(this.madi);
            this.tabPage1.Controls.Add(this.mtcno);
            this.tabPage1.Controls.Add(this.mkodu);
            this.tabPage1.Controls.Add(this.M_turu_kodu);
            this.tabPage1.Controls.Add(this.Adress);
            this.tabPage1.Controls.Add(this.Ilce_kodu);
            this.tabPage1.Controls.Add(this.Il_kodu);
            this.tabPage1.Controls.Add(this.M_email);
            this.tabPage1.Controls.Add(this.M_tel);
            this.tabPage1.Controls.Add(this.M_soyadi);
            this.tabPage1.Controls.Add(this.M_adi);
            this.tabPage1.Controls.Add(this.M_tcno);
            this.tabPage1.Controls.Add(this.M_kodu);
            this.tabPage1.Controls.Add(this.geridon);
            this.tabPage1.Controls.Add(this.kayitguncelle);
            this.tabPage1.Controls.Add(this.yenikayit);
            this.tabPage1.Controls.Add(this.kayitekle);
            this.tabPage1.Controls.Add(this.Musterigrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1258, 670);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Müşteriler";
            // 
            // Musterigrid
            // 
            this.Musterigrid.Location = new System.Drawing.Point(3, 6);
            this.Musterigrid.MainView = this.gridView1;
            this.Musterigrid.Name = "Musterigrid";
            this.Musterigrid.Size = new System.Drawing.Size(1246, 400);
            this.Musterigrid.TabIndex = 0;
            this.Musterigrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView4
            // 
            this.gridView4.GridControl = this.Musterigrid;
            this.gridView4.Name = "gridView4";
            // 
            // kayitekle
            // 
            this.kayitekle.Location = new System.Drawing.Point(1055, 412);
            this.kayitekle.Name = "kayitekle";
            this.kayitekle.Size = new System.Drawing.Size(93, 78);
            this.kayitekle.TabIndex = 6;
            this.kayitekle.Text = "Kayıt Ekle";
            this.kayitekle.UseVisualStyleBackColor = true;
            this.kayitekle.Click += new System.EventHandler(this.kayitekle_Click);
            // 
            // yenikayit
            // 
            this.yenikayit.Location = new System.Drawing.Point(956, 412);
            this.yenikayit.Name = "yenikayit";
            this.yenikayit.Size = new System.Drawing.Size(93, 78);
            this.yenikayit.TabIndex = 7;
            this.yenikayit.Text = "Yeni Kayıt";
            this.yenikayit.UseVisualStyleBackColor = true;
            this.yenikayit.Click += new System.EventHandler(this.yenikayit_Click);
            // 
            // kayitguncelle
            // 
            this.kayitguncelle.Location = new System.Drawing.Point(1154, 412);
            this.kayitguncelle.Name = "kayitguncelle";
            this.kayitguncelle.Size = new System.Drawing.Size(93, 78);
            this.kayitguncelle.TabIndex = 8;
            this.kayitguncelle.Text = "Kayit Güncelle";
            this.kayitguncelle.UseVisualStyleBackColor = true;
            this.kayitguncelle.Click += new System.EventHandler(this.kayitguncelle_Click);
            // 
            // geridon
            // 
            this.geridon.Location = new System.Drawing.Point(1154, 586);
            this.geridon.Name = "geridon";
            this.geridon.Size = new System.Drawing.Size(93, 78);
            this.geridon.TabIndex = 10;
            this.geridon.Text = "Geri Dön";
            this.geridon.UseVisualStyleBackColor = true;
            this.geridon.Click += new System.EventHandler(this.geridon_Click_1);
            // 
            // M_kodu
            // 
            this.M_kodu.Location = new System.Drawing.Point(149, 474);
            this.M_kodu.Name = "M_kodu";
            this.M_kodu.Size = new System.Drawing.Size(263, 22);
            this.M_kodu.TabIndex = 11;
            // 
            // M_tcno
            // 
            this.M_tcno.Location = new System.Drawing.Point(149, 502);
            this.M_tcno.Name = "M_tcno";
            this.M_tcno.Size = new System.Drawing.Size(263, 22);
            this.M_tcno.TabIndex = 12;
            // 
            // M_adi
            // 
            this.M_adi.Location = new System.Drawing.Point(149, 530);
            this.M_adi.Name = "M_adi";
            this.M_adi.Size = new System.Drawing.Size(263, 22);
            this.M_adi.TabIndex = 13;
            // 
            // M_soyadi
            // 
            this.M_soyadi.Location = new System.Drawing.Point(149, 558);
            this.M_soyadi.Name = "M_soyadi";
            this.M_soyadi.Size = new System.Drawing.Size(263, 22);
            this.M_soyadi.TabIndex = 14;
            // 
            // M_tel
            // 
            this.M_tel.Location = new System.Drawing.Point(149, 586);
            this.M_tel.Name = "M_tel";
            this.M_tel.Size = new System.Drawing.Size(263, 22);
            this.M_tel.TabIndex = 15;
            // 
            // M_email
            // 
            this.M_email.Location = new System.Drawing.Point(589, 474);
            this.M_email.Name = "M_email";
            this.M_email.Size = new System.Drawing.Size(263, 22);
            this.M_email.TabIndex = 16;
            // 
            // Il_kodu
            // 
            this.Il_kodu.Location = new System.Drawing.Point(589, 502);
            this.Il_kodu.Name = "Il_kodu";
            this.Il_kodu.Size = new System.Drawing.Size(263, 22);
            this.Il_kodu.TabIndex = 17;
            // 
            // Ilce_kodu
            // 
            this.Ilce_kodu.Location = new System.Drawing.Point(589, 530);
            this.Ilce_kodu.Name = "Ilce_kodu";
            this.Ilce_kodu.Size = new System.Drawing.Size(263, 22);
            this.Ilce_kodu.TabIndex = 18;
            // 
            // Adress
            // 
            this.Adress.Location = new System.Drawing.Point(589, 558);
            this.Adress.Name = "Adress";
            this.Adress.Size = new System.Drawing.Size(263, 22);
            this.Adress.TabIndex = 19;
            // 
            // M_turu_kodu
            // 
            this.M_turu_kodu.Location = new System.Drawing.Point(589, 586);
            this.M_turu_kodu.Name = "M_turu_kodu";
            this.M_turu_kodu.Size = new System.Drawing.Size(263, 22);
            this.M_turu_kodu.TabIndex = 20;
            // 
            // mkodu
            // 
            this.mkodu.AutoSize = true;
            this.mkodu.Location = new System.Drawing.Point(7, 478);
            this.mkodu.Name = "mkodu";
            this.mkodu.Size = new System.Drawing.Size(46, 17);
            this.mkodu.TabIndex = 21;
            this.mkodu.Text = "label1";
            // 
            // mtcno
            // 
            this.mtcno.AutoSize = true;
            this.mtcno.Location = new System.Drawing.Point(7, 507);
            this.mtcno.Name = "mtcno";
            this.mtcno.Size = new System.Drawing.Size(46, 17);
            this.mtcno.TabIndex = 22;
            this.mtcno.Text = "label2";
            // 
            // madi
            // 
            this.madi.AutoSize = true;
            this.madi.Location = new System.Drawing.Point(7, 535);
            this.madi.Name = "madi";
            this.madi.Size = new System.Drawing.Size(46, 17);
            this.madi.TabIndex = 23;
            this.madi.Text = "label3";
            // 
            // msoyadi
            // 
            this.msoyadi.AutoSize = true;
            this.msoyadi.Location = new System.Drawing.Point(7, 563);
            this.msoyadi.Name = "msoyadi";
            this.msoyadi.Size = new System.Drawing.Size(46, 17);
            this.msoyadi.TabIndex = 24;
            this.msoyadi.Text = "label4";
            // 
            // mtel
            // 
            this.mtel.AutoSize = true;
            this.mtel.Location = new System.Drawing.Point(6, 591);
            this.mtel.Name = "mtel";
            this.mtel.Size = new System.Drawing.Size(46, 17);
            this.mtel.TabIndex = 25;
            this.mtel.Text = "label5";
            // 
            // memail
            // 
            this.memail.AutoSize = true;
            this.memail.Location = new System.Drawing.Point(443, 477);
            this.memail.Name = "memail";
            this.memail.Size = new System.Drawing.Size(46, 17);
            this.memail.TabIndex = 26;
            this.memail.Text = "label6";
            // 
            // ilkodu
            // 
            this.ilkodu.AutoSize = true;
            this.ilkodu.Location = new System.Drawing.Point(443, 505);
            this.ilkodu.Name = "ilkodu";
            this.ilkodu.Size = new System.Drawing.Size(46, 17);
            this.ilkodu.TabIndex = 27;
            this.ilkodu.Text = "label7";
            // 
            // ilcekodu
            // 
            this.ilcekodu.AutoSize = true;
            this.ilcekodu.Location = new System.Drawing.Point(443, 533);
            this.ilcekodu.Name = "ilcekodu";
            this.ilcekodu.Size = new System.Drawing.Size(46, 17);
            this.ilcekodu.TabIndex = 28;
            this.ilcekodu.Text = "label8";
            // 
            // adres
            // 
            this.adres.AutoSize = true;
            this.adres.Location = new System.Drawing.Point(443, 561);
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(46, 17);
            this.adres.TabIndex = 29;
            this.adres.Text = "label9";
            // 
            // mturukodu
            // 
            this.mturukodu.AutoSize = true;
            this.mturukodu.Location = new System.Drawing.Point(443, 589);
            this.mturukodu.Name = "mturukodu";
            this.mturukodu.Size = new System.Drawing.Size(54, 17);
            this.mturukodu.TabIndex = 30;
            this.mturukodu.Text = "label10";
            // 
            // sonrakikayit
            // 
            this.sonrakikayit.Location = new System.Drawing.Point(503, 412);
            this.sonrakikayit.Name = "sonrakikayit";
            this.sonrakikayit.Size = new System.Drawing.Size(103, 32);
            this.sonrakikayit.TabIndex = 31;
            this.sonrakikayit.Text = "Sonraki Kayıt";
            this.sonrakikayit.UseVisualStyleBackColor = true;
            this.sonrakikayit.Click += new System.EventHandler(this.sonrakikayit_Click);
            // 
            // oncekikayit
            // 
            this.oncekikayit.Location = new System.Drawing.Point(394, 412);
            this.oncekikayit.Name = "oncekikayit";
            this.oncekikayit.Size = new System.Drawing.Size(103, 32);
            this.oncekikayit.TabIndex = 32;
            this.oncekikayit.Text = "Önceki Kayıt";
            this.oncekikayit.UseVisualStyleBackColor = true;
            this.oncekikayit.Click += new System.EventHandler(this.oncekikayit_Click);
            // 
            // ılkkayit
            // 
            this.ılkkayit.Location = new System.Drawing.Point(285, 412);
            this.ılkkayit.Name = "ılkkayit";
            this.ılkkayit.Size = new System.Drawing.Size(103, 32);
            this.ılkkayit.TabIndex = 33;
            this.ılkkayit.Text = "İlk Kayıt";
            this.ılkkayit.UseVisualStyleBackColor = true;
            this.ılkkayit.Click += new System.EventHandler(this.ılkkayit_Click);
            // 
            // sonkayit
            // 
            this.sonkayit.Location = new System.Drawing.Point(612, 412);
            this.sonkayit.Name = "sonkayit";
            this.sonkayit.Size = new System.Drawing.Size(103, 32);
            this.sonkayit.TabIndex = 34;
            this.sonkayit.Text = "Son Kayıt";
            this.sonkayit.UseVisualStyleBackColor = true;
            this.sonkayit.Click += new System.EventHandler(this.sonkayit_Click);
            // 
            // mid
            // 
            this.mid.AutoSize = true;
            this.mid.Location = new System.Drawing.Point(149, 413);
            this.mid.Name = "mid";
            this.mid.Size = new System.Drawing.Size(46, 17);
            this.mid.TabIndex = 35;
            this.mid.Text = "label1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(13, 35);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1266, 699);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 1;
            // 
            // Musteriislem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 746);
            this.Controls.Add(this.tabControl1);
            this.Name = "Musteriislem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Musteriislem";
            this.Load += new System.EventHandler(this.Musteriislem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Musterigrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl Musterigrid;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label mid;
        private System.Windows.Forms.Button sonkayit;
        private System.Windows.Forms.Button ılkkayit;
        private System.Windows.Forms.Button oncekikayit;
        private System.Windows.Forms.Button sonrakikayit;
        private System.Windows.Forms.Label mturukodu;
        private System.Windows.Forms.Label adres;
        private System.Windows.Forms.Label ilcekodu;
        private System.Windows.Forms.Label ilkodu;
        private System.Windows.Forms.Label memail;
        private System.Windows.Forms.Label mtel;
        private System.Windows.Forms.Label msoyadi;
        private System.Windows.Forms.Label madi;
        private System.Windows.Forms.Label mtcno;
        private System.Windows.Forms.Label mkodu;
        private System.Windows.Forms.TextBox M_turu_kodu;
        private System.Windows.Forms.TextBox Adress;
        private System.Windows.Forms.TextBox Ilce_kodu;
        private System.Windows.Forms.TextBox Il_kodu;
        private System.Windows.Forms.TextBox M_email;
        private System.Windows.Forms.TextBox M_tel;
        private System.Windows.Forms.TextBox M_soyadi;
        private System.Windows.Forms.TextBox M_adi;
        private System.Windows.Forms.TextBox M_tcno;
        private System.Windows.Forms.TextBox M_kodu;
        private System.Windows.Forms.Button geridon;
        private System.Windows.Forms.Button kayitguncelle;
        private System.Windows.Forms.Button yenikayit;
        private System.Windows.Forms.Button kayitekle;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private System.Windows.Forms.TabControl tabControl1;

    }
}
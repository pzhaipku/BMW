namespace BMW
{
    partial class MusteriHizmetleriPanel
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Kapat = new System.Windows.Forms.Button();
            this.Musteriara = new System.Windows.Forms.Button();
            this.Musteriguncelle = new System.Windows.Forms.Button();
            this.Musterisil = new System.Windows.Forms.Button();
            this.Musteriekle = new System.Windows.Forms.Button();
            this.Musterigrid = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Firmagrid = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Servisgrid = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.aktifkisi = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Musterigrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Firmagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Servisgrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1266, 553);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.Kapat);
            this.tabPage1.Controls.Add(this.Musteriara);
            this.tabPage1.Controls.Add(this.Musteriguncelle);
            this.tabPage1.Controls.Add(this.Musterisil);
            this.tabPage1.Controls.Add(this.Musteriekle);
            this.tabPage1.Controls.Add(this.Musterigrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1258, 524);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Müşteriler";
            // 
            // Kapat
            // 
            this.Kapat.Location = new System.Drawing.Point(1159, 6);
            this.Kapat.Name = "Kapat";
            this.Kapat.Size = new System.Drawing.Size(93, 78);
            this.Kapat.TabIndex = 5;
            this.Kapat.Text = "Programı Kapat";
            this.Kapat.UseVisualStyleBackColor = true;
            this.Kapat.Click += new System.EventHandler(this.Kapat_Click);
            // 
            // Musteriara
            // 
            this.Musteriara.Location = new System.Drawing.Point(303, 6);
            this.Musteriara.Name = "Musteriara";
            this.Musteriara.Size = new System.Drawing.Size(93, 78);
            this.Musteriara.TabIndex = 4;
            this.Musteriara.Text = "Müşteri Ara";
            this.Musteriara.UseVisualStyleBackColor = true;
            // 
            // Musteriguncelle
            // 
            this.Musteriguncelle.Location = new System.Drawing.Point(204, 6);
            this.Musteriguncelle.Name = "Musteriguncelle";
            this.Musteriguncelle.Size = new System.Drawing.Size(93, 78);
            this.Musteriguncelle.TabIndex = 3;
            this.Musteriguncelle.Text = "Müşteri Güncelle";
            this.Musteriguncelle.UseVisualStyleBackColor = true;
            this.Musteriguncelle.Click += new System.EventHandler(this.Musteriguncelle_Click);
            // 
            // Musterisil
            // 
            this.Musterisil.Location = new System.Drawing.Point(105, 6);
            this.Musterisil.Name = "Musterisil";
            this.Musterisil.Size = new System.Drawing.Size(93, 78);
            this.Musterisil.TabIndex = 2;
            this.Musterisil.Text = "Müşteri Sil";
            this.Musterisil.UseVisualStyleBackColor = true;
            this.Musterisil.Click += new System.EventHandler(this.Musterisil_Click);
            // 
            // Musteriekle
            // 
            this.Musteriekle.Location = new System.Drawing.Point(6, 6);
            this.Musteriekle.Name = "Musteriekle";
            this.Musteriekle.Size = new System.Drawing.Size(93, 78);
            this.Musteriekle.TabIndex = 1;
            this.Musteriekle.Text = "Müşteri Ekle";
            this.Musteriekle.UseVisualStyleBackColor = true;
            this.Musteriekle.Click += new System.EventHandler(this.Musteriekle_Click);
            // 
            // Musterigrid
            // 
            this.Musterigrid.Location = new System.Drawing.Point(6, 90);
            this.Musterigrid.MainView = this.gridView1;
            this.Musterigrid.Name = "Musterigrid";
            this.Musterigrid.Size = new System.Drawing.Size(1246, 400);
            this.Musterigrid.TabIndex = 0;
            this.Musterigrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.Musterigrid;
            this.gridView1.Name = "gridView1";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.Firmagrid);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1258, 524);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Firmalar";
            // 
            // Firmagrid
            // 
            this.Firmagrid.Location = new System.Drawing.Point(6, 110);
            this.Firmagrid.MainView = this.gridView2;
            this.Firmagrid.Name = "Firmagrid";
            this.Firmagrid.Size = new System.Drawing.Size(1246, 400);
            this.Firmagrid.TabIndex = 1;
            this.Firmagrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.Firmagrid;
            this.gridView2.Name = "gridView2";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.Servisgrid);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1258, 524);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Servis";
            // 
            // Servisgrid
            // 
            this.Servisgrid.Location = new System.Drawing.Point(6, 110);
            this.Servisgrid.MainView = this.gridView3;
            this.Servisgrid.Name = "Servisgrid";
            this.Servisgrid.Size = new System.Drawing.Size(1246, 400);
            this.Servisgrid.TabIndex = 1;
            this.Servisgrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.Servisgrid;
            this.gridView3.Name = "gridView3";
            // 
            // aktifkisi
            // 
            this.aktifkisi.AutoSize = true;
            this.aktifkisi.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aktifkisi.Location = new System.Drawing.Point(20, 573);
            this.aktifkisi.Name = "aktifkisi";
            this.aktifkisi.Size = new System.Drawing.Size(93, 40);
            this.aktifkisi.TabIndex = 1;
            this.aktifkisi.Text = "label1";
            // 
            // MusteriHizmetleriPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 623);
            this.Controls.Add(this.aktifkisi);
            this.Controls.Add(this.tabControl1);
            this.Name = "MusteriHizmetleriPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusteriHizmetleriPanel";
            this.Load += new System.EventHandler(this.MusteriHizmetleriPanel_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Musterigrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Firmagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Servisgrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private DevExpress.XtraGrid.GridControl Musterigrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.TabPage tabPage3;
        private DevExpress.XtraGrid.GridControl Firmagrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.GridControl Servisgrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private System.Windows.Forms.Button Kapat;
        private System.Windows.Forms.Button Musteriara;
        private System.Windows.Forms.Button Musteriguncelle;
        private System.Windows.Forms.Button Musterisil;
        private System.Windows.Forms.Button Musteriekle;
        private System.Windows.Forms.Label aktifkisi;
    }
}
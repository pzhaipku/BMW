namespace BMW
{
    partial class Musteriislem_kayitsilara
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
            this.mkodu = new System.Windows.Forms.Label();
            this.M_kodu = new System.Windows.Forms.TextBox();
            this.geridon = new System.Windows.Forms.Button();
            this.kayitsil = new System.Windows.Forms.Button();
            this.Musterigrid = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Firmagrid = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Servisgrid = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sutunsec = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1266, 699);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.geridon);
            this.tabPage1.Controls.Add(this.Musterigrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1258, 670);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Müşteriler";
            // 
            // mkodu
            // 
            this.mkodu.AutoSize = true;
            this.mkodu.Location = new System.Drawing.Point(70, 151);
            this.mkodu.Name = "mkodu";
            this.mkodu.Size = new System.Drawing.Size(85, 17);
            this.mkodu.TabIndex = 21;
            this.mkodu.Text = "Değer Girin:";
            // 
            // M_kodu
            // 
            this.M_kodu.Location = new System.Drawing.Point(326, 148);
            this.M_kodu.Name = "M_kodu";
            this.M_kodu.Size = new System.Drawing.Size(263, 22);
            this.M_kodu.TabIndex = 11;
            // 
            // geridon
            // 
            this.geridon.Location = new System.Drawing.Point(1154, 586);
            this.geridon.Name = "geridon";
            this.geridon.Size = new System.Drawing.Size(93, 78);
            this.geridon.TabIndex = 10;
            this.geridon.Text = "Geri Dön";
            this.geridon.UseVisualStyleBackColor = true;
            this.geridon.Click += new System.EventHandler(this.geridon_Click);
            // 
            // kayitsil
            // 
            this.kayitsil.Location = new System.Drawing.Point(691, 134);
            this.kayitsil.Name = "kayitsil";
            this.kayitsil.Size = new System.Drawing.Size(152, 50);
            this.kayitsil.TabIndex = 7;
            this.kayitsil.Text = "Kayıt Sil";
            this.kayitsil.UseVisualStyleBackColor = true;
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
            this.tabPage2.Size = new System.Drawing.Size(1258, 670);
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
            this.tabPage3.Size = new System.Drawing.Size(1258, 670);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.sutunsec);
            this.groupBox1.Controls.Add(this.kayitsil);
            this.groupBox1.Controls.Add(this.mkodu);
            this.groupBox1.Controls.Add(this.M_kodu);
            this.groupBox1.Location = new System.Drawing.Point(27, 438);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1010, 212);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müsteri Kayıt Sil";
            // 
            // sutunsec
            // 
            this.sutunsec.FormattingEnabled = true;
            this.sutunsec.Location = new System.Drawing.Point(326, 50);
            this.sutunsec.Name = "sutunsec";
            this.sutunsec.Size = new System.Drawing.Size(263, 24);
            this.sutunsec.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Hangi Parametreye Göre Sileceksin: ";
            // 
            // Musteriislem_kayitsilara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 746);
            this.Controls.Add(this.tabControl1);
            this.Name = "Musteriislem_kayitsilara";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Musteriislem_kayitsilara";
            this.Load += new System.EventHandler(this.Musteriislem_kayitsilara_Load);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox sutunsec;
        private System.Windows.Forms.Button kayitsil;
        private System.Windows.Forms.Label mkodu;
        private System.Windows.Forms.TextBox M_kodu;
        private System.Windows.Forms.Button geridon;
        private DevExpress.XtraGrid.GridControl Musterigrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private DevExpress.XtraGrid.GridControl Firmagrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.TabPage tabPage3;
        private DevExpress.XtraGrid.GridControl Servisgrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
    }
}
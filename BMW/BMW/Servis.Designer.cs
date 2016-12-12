namespace BMW
{
    partial class Servis
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.textSVkod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textSVmus = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textSVmod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboSVprc = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textSVgkm = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textSVckm = new System.Windows.Forms.TextBox();
            this.dateTimeSVgir = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimeSVcik = new System.Windows.Forms.DateTimePicker();
            this.textSVplk = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textSVfyt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.checkSVtm = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textSVid = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(657, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 57);
            this.button1.TabIndex = 0;
            this.button1.Text = "Parça Stoğunu Göster";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(720, 175);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 210);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Ekle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textSVkod
            // 
            this.textSVkod.Location = new System.Drawing.Point(101, 247);
            this.textSVkod.Name = "textSVkod";
            this.textSVkod.Size = new System.Drawing.Size(100, 20);
            this.textSVkod.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Servis Kodu";
            // 
            // textSVmus
            // 
            this.textSVmus.Location = new System.Drawing.Point(101, 288);
            this.textSVmus.Name = "textSVmus";
            this.textSVmus.Size = new System.Drawing.Size(100, 20);
            this.textSVmus.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Müşteri TC No";
            // 
            // textSVmod
            // 
            this.textSVmod.Location = new System.Drawing.Point(317, 247);
            this.textSVmod.Name = "textSVmod";
            this.textSVmod.Size = new System.Drawing.Size(100, 20);
            this.textSVmod.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Model Kodu";
            // 
            // comboSVprc
            // 
            this.comboSVprc.FormattingEnabled = true;
            this.comboSVprc.Location = new System.Drawing.Point(317, 286);
            this.comboSVprc.Name = "comboSVprc";
            this.comboSVprc.Size = new System.Drawing.Size(121, 21);
            this.comboSVprc.TabIndex = 7;
            this.comboSVprc.SelectedIndexChanged += new System.EventHandler(this.comboSVprc_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Personel";
            // 
            // textSVgkm
            // 
            this.textSVgkm.Location = new System.Drawing.Point(534, 247);
            this.textSVgkm.Name = "textSVgkm";
            this.textSVgkm.Size = new System.Drawing.Size(100, 20);
            this.textSVgkm.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(448, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Araç Giriş KM";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(448, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Araç Çıkış KM";
            // 
            // textSVckm
            // 
            this.textSVckm.Location = new System.Drawing.Point(534, 286);
            this.textSVckm.Name = "textSVckm";
            this.textSVckm.Size = new System.Drawing.Size(100, 20);
            this.textSVckm.TabIndex = 11;
            // 
            // dateTimeSVgir
            // 
            this.dateTimeSVgir.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeSVgir.Location = new System.Drawing.Point(344, 324);
            this.dateTimeSVgir.Name = "dateTimeSVgir";
            this.dateTimeSVgir.Size = new System.Drawing.Size(200, 20);
            this.dateTimeSVgir.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(250, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Servis Giriş Tarihi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(250, 365);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Servis Çıkış Tarihi";
            // 
            // dateTimeSVcik
            // 
            this.dateTimeSVcik.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeSVcik.Location = new System.Drawing.Point(344, 359);
            this.dateTimeSVcik.Name = "dateTimeSVcik";
            this.dateTimeSVcik.Size = new System.Drawing.Size(200, 20);
            this.dateTimeSVcik.TabIndex = 15;
            this.dateTimeSVcik.Value = new System.DateTime(2016, 12, 16, 0, 0, 0, 0);
            // 
            // textSVplk
            // 
            this.textSVplk.Location = new System.Drawing.Point(101, 327);
            this.textSVplk.Name = "textSVplk";
            this.textSVplk.Size = new System.Drawing.Size(100, 20);
            this.textSVplk.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 331);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Plaka";
            // 
            // textSVfyt
            // 
            this.textSVfyt.Location = new System.Drawing.Point(101, 359);
            this.textSVfyt.Name = "textSVfyt";
            this.textSVfyt.Size = new System.Drawing.Size(100, 20);
            this.textSVfyt.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 362);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Tutar";
            // 
            // checkSVtm
            // 
            this.checkSVtm.AutoSize = true;
            this.checkSVtm.Location = new System.Drawing.Point(560, 329);
            this.checkSVtm.Name = "checkSVtm";
            this.checkSVtm.Size = new System.Drawing.Size(83, 17);
            this.checkSVtm.TabIndex = 22;
            this.checkSVtm.Text = "Tamamlandı";
            this.checkSVtm.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(130, 210);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 23;
            this.button3.Text = "Güncelle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textSVid
            // 
            this.textSVid.Enabled = false;
            this.textSVid.Location = new System.Drawing.Point(317, 210);
            this.textSVid.Name = "textSVid";
            this.textSVid.Size = new System.Drawing.Size(100, 20);
            this.textSVid.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(253, 216);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Servis İd";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(550, 207);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 26;
            this.button4.Text = "Sil";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(451, 206);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 27;
            this.button5.Text = "Temizle";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Servis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 396);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textSVid);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.checkSVtm);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textSVfyt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textSVplk);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimeSVcik);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimeSVgir);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textSVckm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textSVgkm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboSVprc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textSVmod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textSVmus);
            this.Controls.Add(this.textSVkod);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Servis";
            this.Text = "Servis";
            this.Load += new System.EventHandler(this.Servis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textSVkod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textSVmus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textSVmod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboSVprc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textSVgkm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textSVckm;
        private System.Windows.Forms.DateTimePicker dateTimeSVgir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimeSVcik;
        private System.Windows.Forms.TextBox textSVplk;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textSVfyt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkSVtm;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textSVid;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}
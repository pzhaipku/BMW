namespace BMW
{
    partial class AracStok
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.textASid = new System.Windows.Forms.TextBox();
            this.textASmod = new System.Windows.Forms.TextBox();
            this.textASadt = new System.Windows.Forms.TextBox();
            this.textASalf = new System.Windows.Forms.TextBox();
            this.textASotv = new System.Windows.Forms.TextBox();
            this.textASkdv = new System.Windows.Forms.TextBox();
            this.textASkar = new System.Windows.Forms.TextBox();
            this.textASbtf = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboASmod = new System.Windows.Forms.ComboBox();
            this.comboASsri = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(693, 214);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Aracı Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textASid
            // 
            this.textASid.Enabled = false;
            this.textASid.Location = new System.Drawing.Point(61, 240);
            this.textASid.Name = "textASid";
            this.textASid.Size = new System.Drawing.Size(100, 20);
            this.textASid.TabIndex = 1;
            // 
            // textASmod
            // 
            this.textASmod.Location = new System.Drawing.Point(266, 312);
            this.textASmod.Name = "textASmod";
            this.textASmod.Size = new System.Drawing.Size(100, 20);
            this.textASmod.TabIndex = 2;
            // 
            // textASadt
            // 
            this.textASadt.Location = new System.Drawing.Point(266, 240);
            this.textASadt.Name = "textASadt";
            this.textASadt.Size = new System.Drawing.Size(100, 20);
            this.textASadt.TabIndex = 3;
            // 
            // textASalf
            // 
            this.textASalf.Enabled = false;
            this.textASalf.Location = new System.Drawing.Point(266, 275);
            this.textASalf.Name = "textASalf";
            this.textASalf.Size = new System.Drawing.Size(100, 20);
            this.textASalf.TabIndex = 4;
            // 
            // textASotv
            // 
            this.textASotv.Enabled = false;
            this.textASotv.Location = new System.Drawing.Point(404, 240);
            this.textASotv.Name = "textASotv";
            this.textASotv.Size = new System.Drawing.Size(100, 20);
            this.textASotv.TabIndex = 5;
            // 
            // textASkdv
            // 
            this.textASkdv.Enabled = false;
            this.textASkdv.Location = new System.Drawing.Point(404, 276);
            this.textASkdv.Name = "textASkdv";
            this.textASkdv.Size = new System.Drawing.Size(100, 20);
            this.textASkdv.TabIndex = 6;
            this.textASkdv.Text = "18";
            // 
            // textASkar
            // 
            this.textASkar.Enabled = false;
            this.textASkar.Location = new System.Drawing.Point(609, 241);
            this.textASkar.Name = "textASkar";
            this.textASkar.Size = new System.Drawing.Size(100, 20);
            this.textASkar.TabIndex = 7;
            this.textASkar.Text = "20";
            // 
            // textASbtf
            // 
            this.textASbtf.Enabled = false;
            this.textASbtf.Location = new System.Drawing.Point(609, 276);
            this.textASbtf.Name = "textASbtf";
            this.textASbtf.Size = new System.Drawing.Size(100, 20);
            this.textASbtf.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(329, 355);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Model Detayını Göster";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(493, 355);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Temizle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "İd";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Model Kodu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Adet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Birim Alış Fiyatı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(372, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "ÖTV";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(372, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "KDV";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(514, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "KÂR";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(514, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Birim Toplam Fiyat";
            // 
            // comboASmod
            // 
            this.comboASmod.FormattingEnabled = true;
            this.comboASmod.Location = new System.Drawing.Point(61, 310);
            this.comboASmod.Name = "comboASmod";
            this.comboASmod.Size = new System.Drawing.Size(121, 21);
            this.comboASmod.TabIndex = 20;
            this.comboASmod.SelectedIndexChanged += new System.EventHandler(this.comboASmod_SelectedIndexChanged);
            // 
            // comboASsri
            // 
            this.comboASsri.FormattingEnabled = true;
            this.comboASsri.Location = new System.Drawing.Point(61, 276);
            this.comboASsri.Name = "comboASsri";
            this.comboASsri.Size = new System.Drawing.Size(121, 21);
            this.comboASsri.TabIndex = 21;
            this.comboASsri.SelectedIndexChanged += new System.EventHandler(this.comboASsri_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 283);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Seri";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 316);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Model";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(208, 355);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 23);
            this.button4.TabIndex = 24;
            this.button4.Text = "Adet Güncelle";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(609, 310);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 68);
            this.button5.TabIndex = 25;
            this.button5.Text = "Araç Satışa Dön";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // AracStok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 390);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboASsri);
            this.Controls.Add(this.comboASmod);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textASbtf);
            this.Controls.Add(this.textASkar);
            this.Controls.Add(this.textASkdv);
            this.Controls.Add(this.textASotv);
            this.Controls.Add(this.textASalf);
            this.Controls.Add(this.textASadt);
            this.Controls.Add(this.textASmod);
            this.Controls.Add(this.textASid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AracStok";
            this.Text = "Araç Stok";
            this.Load += new System.EventHandler(this.AracStok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textASid;
        private System.Windows.Forms.TextBox textASmod;
        private System.Windows.Forms.TextBox textASadt;
        private System.Windows.Forms.TextBox textASalf;
        private System.Windows.Forms.TextBox textASotv;
        private System.Windows.Forms.TextBox textASkdv;
        private System.Windows.Forms.TextBox textASkar;
        private System.Windows.Forms.TextBox textASbtf;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboASmod;
        private System.Windows.Forms.ComboBox comboASsri;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}
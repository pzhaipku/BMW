﻿namespace BMW
{
    partial class Servis_Islem
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
            this.textSIid = new System.Windows.Forms.TextBox();
            this.textSIkod = new System.Windows.Forms.TextBox();
            this.textSIisl = new System.Windows.Forms.TextBox();
            this.comboSIprc = new System.Windows.Forms.ComboBox();
            this.textSIadt = new System.Windows.Forms.TextBox();
            this.textSIsvk = new System.Windows.Forms.TextBox();
            this.textSIfyt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(735, 201);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(655, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "Parça Stoğunu Göster";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textSIid
            // 
            this.textSIid.Enabled = false;
            this.textSIid.Location = new System.Drawing.Point(74, 216);
            this.textSIid.Name = "textSIid";
            this.textSIid.Size = new System.Drawing.Size(100, 20);
            this.textSIid.TabIndex = 2;
            // 
            // textSIkod
            // 
            this.textSIkod.Location = new System.Drawing.Point(74, 245);
            this.textSIkod.Name = "textSIkod";
            this.textSIkod.Size = new System.Drawing.Size(100, 20);
            this.textSIkod.TabIndex = 3;
            // 
            // textSIisl
            // 
            this.textSIisl.Location = new System.Drawing.Point(266, 219);
            this.textSIisl.Name = "textSIisl";
            this.textSIisl.Size = new System.Drawing.Size(100, 20);
            this.textSIisl.TabIndex = 4;
            // 
            // comboSIprc
            // 
            this.comboSIprc.FormattingEnabled = true;
            this.comboSIprc.Location = new System.Drawing.Point(266, 248);
            this.comboSIprc.Name = "comboSIprc";
            this.comboSIprc.Size = new System.Drawing.Size(121, 21);
            this.comboSIprc.TabIndex = 5;
            this.comboSIprc.SelectedIndexChanged += new System.EventHandler(this.comboSIprc_SelectedIndexChanged);
            // 
            // textSIadt
            // 
            this.textSIadt.Location = new System.Drawing.Point(455, 216);
            this.textSIadt.Name = "textSIadt";
            this.textSIadt.Size = new System.Drawing.Size(100, 20);
            this.textSIadt.TabIndex = 6;
            // 
            // textSIsvk
            // 
            this.textSIsvk.Location = new System.Drawing.Point(455, 246);
            this.textSIsvk.Name = "textSIsvk";
            this.textSIsvk.Size = new System.Drawing.Size(100, 20);
            this.textSIsvk.TabIndex = 7;
            // 
            // textSIfyt
            // 
            this.textSIfyt.Location = new System.Drawing.Point(616, 216);
            this.textSIfyt.Name = "textSIfyt";
            this.textSIfyt.Size = new System.Drawing.Size(100, 20);
            this.textSIfyt.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "İd";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "İşlem Kodu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "İşlem";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(183, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Kullanılan Parça";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(393, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Parça Adeti";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(393, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Servis Kodu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(578, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Tutar";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(74, 287);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "İşlem Bilgisi Ekle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(249, 286);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 18;
            this.button4.Text = "Sil";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(371, 287);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 19;
            this.button5.Text = "Temizle";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(561, 260);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 50);
            this.button6.TabIndex = 20;
            this.button6.Text = "Servise Geri Dön";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Servis_Islem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 322);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textSIfyt);
            this.Controls.Add(this.textSIsvk);
            this.Controls.Add(this.textSIadt);
            this.Controls.Add(this.comboSIprc);
            this.Controls.Add(this.textSIisl);
            this.Controls.Add(this.textSIkod);
            this.Controls.Add(this.textSIid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Servis_Islem";
            this.Text = "Servis İşlemleri";
            this.Load += new System.EventHandler(this.Servis_Islem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textSIid;
        private System.Windows.Forms.TextBox textSIkod;
        private System.Windows.Forms.TextBox textSIisl;
        private System.Windows.Forms.ComboBox comboSIprc;
        private System.Windows.Forms.TextBox textSIadt;
        private System.Windows.Forms.TextBox textSIsvk;
        private System.Windows.Forms.TextBox textSIfyt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}
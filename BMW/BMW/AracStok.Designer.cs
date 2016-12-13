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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.Size = new System.Drawing.Size(659, 214);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Aracı Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textASid
            // 
            this.textASid.Enabled = false;
            this.textASid.Location = new System.Drawing.Point(32, 242);
            this.textASid.Name = "textASid";
            this.textASid.Size = new System.Drawing.Size(100, 20);
            this.textASid.TabIndex = 2;
            // 
            // textASmod
            // 
            this.textASmod.Location = new System.Drawing.Point(32, 277);
            this.textASmod.Name = "textASmod";
            this.textASmod.Size = new System.Drawing.Size(100, 20);
            this.textASmod.TabIndex = 2;
            // 
            // textASadt
            // 
            this.textASadt.Location = new System.Drawing.Point(169, 242);
            this.textASadt.Name = "textASadt";
            this.textASadt.Size = new System.Drawing.Size(100, 20);
            this.textASadt.TabIndex = 2;
            // 
            // textASalf
            // 
            this.textASalf.Location = new System.Drawing.Point(169, 277);
            this.textASalf.Name = "textASalf";
            this.textASalf.Size = new System.Drawing.Size(100, 20);
            this.textASalf.TabIndex = 2;
            // 
            // textASotv
            // 
            this.textASotv.Location = new System.Drawing.Point(302, 242);
            this.textASotv.Name = "textASotv";
            this.textASotv.Size = new System.Drawing.Size(100, 20);
            this.textASotv.TabIndex = 2;
            // 
            // textASkdv
            // 
            this.textASkdv.Location = new System.Drawing.Point(302, 277);
            this.textASkdv.Name = "textASkdv";
            this.textASkdv.Size = new System.Drawing.Size(100, 20);
            this.textASkdv.TabIndex = 2;
            // 
            // textASkar
            // 
            this.textASkar.Location = new System.Drawing.Point(436, 242);
            this.textASkar.Name = "textASkar";
            this.textASkar.Size = new System.Drawing.Size(100, 20);
            this.textASkar.TabIndex = 2;
            // 
            // textASbtf
            // 
            this.textASbtf.Location = new System.Drawing.Point(436, 277);
            this.textASbtf.Name = "textASbtf";
            this.textASbtf.Size = new System.Drawing.Size(100, 20);
            this.textASbtf.TabIndex = 2;
            // 
            // AracStok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 352);
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
            this.Text = "t";
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
    }
}
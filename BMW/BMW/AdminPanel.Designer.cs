namespace BMW
{
    partial class AdminPanel
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
            this.btn_Kullanicilar = new System.Windows.Forms.Button();
            this.lbl_GirisBilgisi = new System.Windows.Forms.Label();
            this.btn_ACikis = new System.Windows.Forms.Button();
            this.btn_YetkiTanimlama = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Kullanicilar
            // 
            this.btn_Kullanicilar.Location = new System.Drawing.Point(108, 44);
            this.btn_Kullanicilar.Name = "btn_Kullanicilar";
            this.btn_Kullanicilar.Size = new System.Drawing.Size(72, 47);
            this.btn_Kullanicilar.TabIndex = 0;
            this.btn_Kullanicilar.Text = "Kullanıcılar";
            this.btn_Kullanicilar.UseVisualStyleBackColor = true;
            this.btn_Kullanicilar.Click += new System.EventHandler(this.btn_Kullanicilar_Click);
            // 
            // lbl_GirisBilgisi
            // 
            this.lbl_GirisBilgisi.AutoSize = true;
            this.lbl_GirisBilgisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_GirisBilgisi.Location = new System.Drawing.Point(12, 9);
            this.lbl_GirisBilgisi.Name = "lbl_GirisBilgisi";
            this.lbl_GirisBilgisi.Size = new System.Drawing.Size(87, 16);
            this.lbl_GirisBilgisi.TabIndex = 1;
            this.lbl_GirisBilgisi.Text = "Giriş Bilgisi";
            // 
            // btn_ACikis
            // 
            this.btn_ACikis.Location = new System.Drawing.Point(400, 9);
            this.btn_ACikis.Name = "btn_ACikis";
            this.btn_ACikis.Size = new System.Drawing.Size(56, 43);
            this.btn_ACikis.TabIndex = 2;
            this.btn_ACikis.Text = "Çıkış";
            this.btn_ACikis.UseVisualStyleBackColor = true;
            this.btn_ACikis.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_YetkiTanimlama
            // 
            this.btn_YetkiTanimlama.Location = new System.Drawing.Point(15, 44);
            this.btn_YetkiTanimlama.Name = "btn_YetkiTanimlama";
            this.btn_YetkiTanimlama.Size = new System.Drawing.Size(72, 47);
            this.btn_YetkiTanimlama.TabIndex = 3;
            this.btn_YetkiTanimlama.Text = "Yetki Tanımlama";
            this.btn_YetkiTanimlama.UseVisualStyleBackColor = true;
            this.btn_YetkiTanimlama.Click += new System.EventHandler(this.btn_YetkiTanimlama_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 322);
            this.ControlBox = false;
            this.Controls.Add(this.btn_YetkiTanimlama);
            this.Controls.Add(this.btn_ACikis);
            this.Controls.Add(this.lbl_GirisBilgisi);
            this.Controls.Add(this.btn_Kullanicilar);
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Kullanicilar;
        private System.Windows.Forms.Label lbl_GirisBilgisi;
        private System.Windows.Forms.Button btn_ACikis;
        private System.Windows.Forms.Button btn_YetkiTanimlama;
    }
}
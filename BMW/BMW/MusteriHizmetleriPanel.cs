﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMW
{
    public partial class MusteriHizmetleriPanel : Form
    {
        SQL cumle = new SQL();

        public MusteriHizmetleriPanel()
        {
            InitializeComponent();
        }

        private void MusteriHizmetleriPanel_Load(object sender, EventArgs e)
        {
            cumle.Select("SELECT * FROM Musteri", "Musteri");
            Musterigrid.DataSource = cumle.ds.Tables["Musteri"];
            cumle.Select("SELECT * FROM Firma_Musteri", "Firma");
            Firmagrid.DataSource = cumle.ds.Tables["Firma"];
            cumle.Select("SELECT * FROM Servis", "Servis");
            Servisgrid.DataSource = cumle.ds.Tables["Servis"];

        }
    }
}

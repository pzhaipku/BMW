﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BMW
{
    public partial class SV_musform : Form
    {
        SqlConnection sv_musbaglanti = new SqlConnection("Data Source=PC-BILGISAYAR; Initial Catalog=BMW;Integrated Security=true;");
        public SV_musform()
        {
            InitializeComponent();
        }

        private void SV_musform_Load(object sender, EventArgs e)
        {
           string mustc = ((Servis)Application.OpenForms.OfType<Servis>().SingleOrDefault()).mustc;
            SqlDataAdapter sv_DA = new SqlDataAdapter("Execute Musteri_sorgu_mtcno "+mustc, sv_musbaglanti);
            DataSet sv_DS = new DataSet();
            sv_musbaglanti.Open();
            sv_DA.Fill(sv_DS, "Servis Musteri");
            dataGridView1.DataSource = sv_DS.Tables["Servis Musteri"];
            sv_musbaglanti.Close();
            
        }
    }
}

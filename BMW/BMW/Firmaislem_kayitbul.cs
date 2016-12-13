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
    public partial class Firmaislem_kayitbul : Form
    {
        SQL cumle = new SQL();
        private int bul=0;


        public Firmaislem_kayitbul()
        {
            InitializeComponent();
        }

        private void geridonara_Click(object sender, EventArgs e)
        {
            MusteriHizmetleriPanel m = new MusteriHizmetleriPanel();
            m.Show();
            this.Close();

        }

        private void Firmaislem_kayitbul_Load(object sender, EventArgs e)
        {
            cumle.Select("Select * from Firma_Musteri", "firmabul");
            Firmabulgrid.DataSource = cumle.ds.Tables["firmabul"];
            sutunsecara.Items.Add(cumle.ds.Tables["firmabul"].Columns["Firma_kodu"].ToString());
            sutunsecara.Items.Add(cumle.ds.Tables["firmabul"].Columns["Firma_adi"].ToString());
            sutunsecara.Items.Add(cumle.ds.Tables["firmabul"].Columns["M_kodu"].ToString());
        }

        private void Tümtablogoster_Click(object sender, EventArgs e)
        {
            cumle.ds.Tables["firmabul"].Clear();
            try
            {
                cumle.ds.Tables["firmakayitbul"].Clear();
            }
            catch (Exception)
            {

            }

            cumle.Select("Select * from Firma_Musteri", "firmabul");
            Firmabulgrid.DataSource = cumle.ds.Tables["firmabul"];
            bul = 0;
        }

        private void kayitara_Click(object sender, EventArgs e)
        {
            if (sutunsecara.SelectedItem.ToString() == "Firma_kodu")
            {
                if (bul == 0)
                { }
                else if (bul > 0)
                {
                    cumle.ds.Tables["firmakayitbul"].Clear();
                  

                }
                bul++;
                cumle.Select("SELECT * FROM Firma_Musteri WHERE Firma_kodu='" + Aranacakdeger.Text.ToString() + "'", "firmakayitbul");
                Firmabulgrid.DataSource = cumle.ds.Tables["firmakayitbul"];


            }
            else if (sutunsecara.SelectedItem.ToString() == "Firma_adi")
            {
                if (bul == 0)
                { }
                else if (bul > 0)
                {
                    cumle.ds.Tables["firmakayitbul"].Clear();


                }
                bul++;
                cumle.Select("SELECT * FROM Firma_Musteri WHERE Firma_adi='" + Aranacakdeger.Text.ToString() + "'", "firmakayitbul");
                Firmabulgrid.DataSource = cumle.ds.Tables["firmakayitbul"];


            }
            else if (sutunsecara.SelectedItem.ToString() == "M_kodu")
            {
                if (bul == 0)
                { }
                else if (bul > 0)
                {
                    cumle.ds.Tables["firmakayitbul"].Clear();


                }
                bul++;
                cumle.Select("SELECT * FROM Firma_Musteri WHERE M_kodu='" + Aranacakdeger.Text.ToString() + "'", "firmakayitbul");
                Firmabulgrid.DataSource = cumle.ds.Tables["firmakayitbul"];


            }
            
        }
    }
}

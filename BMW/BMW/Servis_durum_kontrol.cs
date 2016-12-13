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
    public partial class Servis_durum_kontrol : Form
    {
        SQL cumle = new SQL();
        private int bul = 0;


        public Servis_durum_kontrol()
        {
            InitializeComponent();
        }

        private void Servis_durum_kontrol_Load(object sender, EventArgs e)
        {
            cumle.Select("Select * from Servis", "servisdurum");
            Firmabulgrid.DataSource = cumle.ds.Tables["servisdurum"];
            sutunsecara.Items.Add(cumle.ds.Tables["servisdurum"].Columns["S_kodu"].ToString());
            sutunsecara.Items.Add(cumle.ds.Tables["servisdurum"].Columns["Plaka"].ToString());
      
        }

        private void kayitara_Click(object sender, EventArgs e)
        {
            try
            {
                if (sutunsecara.SelectedItem.ToString() == "S_kodu")
                {
                    if (bul == 0)
                    { }
                    else if (bul > 0)
                    {
                        cumle.ds.Tables["servisdurumbul"].Clear();


                    }
                    bul++;
                    cumle.Select("SELECT * FROM Servis WHERE S_kodu='" + Aranacakdeger.Text.ToString() + "'", "servisdurumbul");
                    Firmabulgrid.DataSource = cumle.ds.Tables["servisdurumbul"];
                         if (cumle.ds.Tables["servisdurumbul"].Rows[0]["Durum"].ToString() == "0")
                         {
                                Durumresim.Visible = true;
                                servisdurumaciklama.Visible = true;
                                servisdurumaciklama.Text = Aranacakdeger.Text.ToString() + " Servis kodlu " + cumle.ds.Tables["servisdurumbul"].Rows[0]["Plaka"].ToString() + " Plakalı Aracın Servis Durumu = Hala Devam Ediyor...";
                                Durumresim.Image = Image.FromFile(Application.StartupPath + @"\\Durum_kirmizi.png");
                         }
                        if (cumle.ds.Tables["servisdurumbul"].Rows[0]["Durum"].ToString() == "1")
                        {
                                Durumresim.Visible = true;
                                servisdurumaciklama.Visible = true;
                                servisdurumaciklama.Text = Aranacakdeger.Text.ToString() + " Servis kodlu " + cumle.ds.Tables["servisdurumbul"].Rows[0]["Plaka"].ToString() + " Plakalı Aracın Servis Durumu = İşi Bimiştir...";
                                Durumresim.Image = Image.FromFile(Application.StartupPath + @"\\Durum_yesil.png");
                        }
                 
                

                }
                else if (sutunsecara.SelectedItem.ToString() == "Plaka")
                {
                    if (bul == 0)
                    { }
                    else if (bul > 0)
                    {
                        cumle.ds.Tables["servisdurumbul"].Clear();


                    }
                    bul++;
                    cumle.Select("SELECT * FROM Servis WHERE Plaka='" + Aranacakdeger.Text.ToString() + "'", "servisdurumbul");
                    Firmabulgrid.DataSource = cumle.ds.Tables["servisdurumbul"];
                    if (cumle.ds.Tables["servisdurumbul"].Rows[0]["Durum"].ToString() == "0")
                    {
                        Durumresim.Visible = true;
                        servisdurumaciklama.Visible = true;
                        servisdurumaciklama.Text = Aranacakdeger.Text.ToString() + " Plakalı " + cumle.ds.Tables["servisdurumbul"].Rows[0]["S_kodu"].ToString() + " Servis Kodlu Aracın Servis Durumu = Hala Devam Ediyor...";
                        Durumresim.Image = Image.FromFile(Application.StartupPath + @"\\Durum_kirmizi.png");




                    }
                    else if (cumle.ds.Tables["servisdurumbul"].Rows[0]["Durum"].ToString() == "1")
                    {
                        Durumresim.Visible = true;
                        servisdurumaciklama.Visible = true;
                        servisdurumaciklama.Text = Aranacakdeger.Text.ToString() + " Plakalı " + cumle.ds.Tables["servisdurumbul"].Rows[0]["S_kodu"].ToString() + " Servis Kodlu Aracın Servis Durumu = İşi Bitmiştr...";
                        Durumresim.Image = Image.FromFile(Application.StartupPath + @"\\Durum_yesil.png");
                    }


                }

            }
            catch (Exception)
            {

            }
        }            
            
            
       


        private void Tümtablogoster_Click(object sender, EventArgs e)
        {
            cumle.ds.Tables["servisdurum"].Clear();
            try
            {
                cumle.ds.Tables["servisdurumbul"].Clear();
            }
            catch (Exception)
            {

            }

            cumle.Select("Select * from Servis", "servisdurum");
            Firmabulgrid.DataSource = cumle.ds.Tables["servisdurum"];
            bul = 0;
        }

        private void geridonara_Click(object sender, EventArgs e)
        {
            MusteriHizmetleriPanel m = new MusteriHizmetleriPanel();
            this.Close();
            m.Show();
        }
    }
}
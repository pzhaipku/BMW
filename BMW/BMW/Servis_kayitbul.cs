using System;
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
    public partial class Servis_kayitbul : Form
    {
        SQL cumle = new SQL();
        private int bul = 0;

        public Servis_kayitbul()
        {
            InitializeComponent();
        }

        private void Servis_kayitbul_Load(object sender, EventArgs e)
        {
            cumle.Select("Select * from Servis", "serviskayit");
            Firmabulgrid.DataSource = cumle.ds.Tables["serviskayit"];
            sutunsecara.Items.Add(cumle.ds.Tables["serviskayit"].Columns["S_kodu"].ToString());
            sutunsecara.Items.Add(cumle.ds.Tables["serviskayit"].Columns["Plaka"].ToString());
            
            
            
        }

        private void Tümtablogoster_Click(object sender, EventArgs e)
        {
            cumle.ds.Tables["serviskayit"].Clear();
            try
            {
                cumle.ds.Tables["serviskayitbul"].Clear();
            }
            catch (Exception)
            {

            }

            cumle.Select("Select * from Servis", "serviskayit");
            Firmabulgrid.DataSource = cumle.ds.Tables["serviskayit"];
            bul = 0;
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
                        cumle.ds.Tables["serviskayitbul"].Clear();


                    }
                    bul++;
                    cumle.Select("SELECT * FROM Servis WHERE S_kodu='" + Aranacakdeger.Text.ToString() + "'", "serviskayitbul");
                    Firmabulgrid.DataSource = cumle.ds.Tables["serviskayitbul"];




                }
                else if (sutunsecara.SelectedItem.ToString() == "Plaka")
                {
                    if (bul == 0)
                    { }
                    else if (bul > 0)
                    {
                        cumle.ds.Tables["serviskayitbul"].Clear();


                    }
                    bul++;
                    cumle.Select("SELECT * FROM Servis WHERE Plaka='" + Aranacakdeger.Text.ToString() + "'", "serviskayitbul");
                    Firmabulgrid.DataSource = cumle.ds.Tables["serviskayitbul"];


                }

            }
            catch(Exception)
            {

            }
            
            

        }

        private void geridonara_Click(object sender, EventArgs e)
        {
            MusteriHizmetleriPanel m = new MusteriHizmetleriPanel();
            this.Close();
            m.Show();

        }
    }
}

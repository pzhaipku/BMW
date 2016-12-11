using System;
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
    public partial class Servis : Form
    {
        SqlConnection sv_baglanti = new SqlConnection("Data Source=PC-BILGISAYAR; Initial Catalog=BMW;Integrated Security=true;");
        public Servis()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Parca prc_form = new Parca();
            prc_form.Show();
        }
        public void servis_goster()
        {
            SqlDataAdapter sv_DA = new SqlDataAdapter("Select * From Servis", sv_baglanti);
            DataSet sv_DS = new DataSet();
            sv_baglanti.Open();
            sv_DA.Fill(sv_DS, "Parca_Stok");
            dataGridView1.DataSource = sv_DS.Tables["Parca_Stok"];
            sv_baglanti.Close();
        }
        public void parca_goster()
        {
            SqlCommand komut = new SqlCommand("Select P_adi From Personel",sv_baglanti);
            sv_baglanti.Open();
            SqlDataReader sv_DR;
            sv_DR = komut.ExecuteReader();
            while (sv_DR.Read())
            {
            comboSVprc.Items.Add(sv_DR["P_adi"]);
            }
            sv_baglanti.Close();
        }
        private void Servis_Load(object sender, EventArgs e)
        {
            servis_goster();
            parca_goster();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            if (checkSVctb.Checked == true) 
            { 
                string cikistarih = "NULL".ToString();
                komut.CommandText = "INSERT INTO Servis Values(" + "'" + textSVkod.Text + "'," + "'" + textSVmus.Text + "','" + textSVmod.Text + "','" + "PK001" + "'," + textSVgkm.Text + "," + textSVckm.Text + ",'" + Convert.ToDateTime(dateTimeSVgir.Text) + "',Null,'"+textSVplk.Text+"',"+Convert.ToInt32(textSVfyt.Text)+",'"+Convert.ToInt32(checkSVtm.Checked)+"','"+"IK0000')";
                MessageBox.Show(komut.CommandText);
            } 
            else { }
            sv_baglanti.Open();
            komut.Connection = sv_baglanti;
            //komut.CommandText = "INSERT INTO Servis Values(" + "'" + textSVkod.Text + "'," + "'" + textSVmus.Text + "','" + textSVmod.Text + "','" + comboSVprc.SelectedItem + "','" + textSVgkm.Text + "','" + textSVckm.Text + "','" + Convert.ToDateTime(dateTimeSVgir.Text)+"','";
            komut.ExecuteNonQuery();
            sv_baglanti.Close();
            servis_goster();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }
    }
}

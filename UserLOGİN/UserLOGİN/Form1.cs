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

namespace UserLOGİN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=********\\SQLEXPRESS;Initial Catalog=UserLogin;Integrated Security=True");
        SqlCommand komut;
        SqlDataReader r;
        int hak = 3;
       
        private void button1_Click(object sender, EventArgs e)
        {
           
            string u = k1.Text;
            string pass = k2.Text;
            veri1 veri = new veri1();
            veri.kgiris(u, pass);
            k1.Clear();
            k2.Clear();
             baglan.Open();
            komut = new SqlCommand("Select * from UserTable where us='" + u + "' and Password='" + pass + "' ", baglan);
            r = komut.ExecuteReader();
            if (r.Read())
            {
                MessageBox.Show("Giriş Başarılı");
                Application.Exit();
            }
            else
            {

                hak--;
                MessageBox.Show("Hatalı Giriş Kalan Hakkınız : " + hak);
                if (hak == 0)
                {
                    Application.Exit();

                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void k1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void k2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

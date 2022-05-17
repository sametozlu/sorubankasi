using BoruSankasi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sorubankasi
{
    public partial class Form1 : Form
    {
        SqlDataReader dr;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormKayit sistema = new FormKayit(false);
            sistema.ShowDialog();
            this.Close();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(SQLConnect.ConnectionString);


            StringBuilder sb = new StringBuilder();
            sb.Append("Select * from login WHERE username = @username AND password = @password ");

            using (SqlCommand cmd = new SqlCommand(sb.ToString(), con))
            {

                cmd.Parameters.AddWithValue("@username", txtusername.Text);
                cmd.Parameters.AddWithValue("@password", txtpassword.Text);
                con.Open();

                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    int usertype = Convert.ToInt16(dr[5].ToString());
                    MessageBox.Show("usertype:" + usertype);
                    this.Hide();
                    if (usertype == 1)
                    {
                        formadminmain admind = new formadminmain();
                        MessageBox.Show("frmadminId olustu");
                        admind.Show();
                        MessageBox.Show("frmadminId cağırıldı");

                        // this.Close();
                    }
                    if (usertype == 2)
                    {
                        formogretmenmain sistemaxz = new formogretmenmain();
                        sistemaxz.ShowDialog();
                        //this.Close();
                    }
                    if (usertype == 3)
                    {
                        fromstudent sistemax = new fromstudent(Convert.ToInt16(dr[0].ToString()));
                        sistemax.ShowDialog();
                        //  this.Close();
                    }
                }
                //else
                //{
                //    MessageBox.Show("Giriş Hatası");

                //}
            }

        }

        private void btnforgot_Click(object sender, EventArgs e)
        {
            this.Hide();
            formforgotpass sistema = new formforgotpass();
            sistema.ShowDialog();
            this.Close();
        }
    }
}

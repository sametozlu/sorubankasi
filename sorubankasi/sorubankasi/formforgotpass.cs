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
    public partial class formforgotpass : Form
    {
        SqlDataReader dr;
        public formforgotpass()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(SQLConnect.ConnectionString))
            {

                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT login.password from login where login.hiddenkey=@t");

                 using (SqlCommand cmd = new SqlCommand(sb.ToString(), con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@t", txtrue.Text);

                    dr = cmd.ExecuteReader();
                    try
                    {
                        if(dr.Read())

                                MessageBox.Show("Şifreniz : " + dr[0].ToString());                       
                        else
                            MessageBox.Show("Bu kurtarma koduyla bağlantılı bir hesap bulunamadı.");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Bu kurtarma koduyla ilgili bir hesap bulunamadı.");

                    }
                }
            }



        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 sistema = new Form1();
            sistema.ShowDialog();
            this.Close();
        }
    }
}

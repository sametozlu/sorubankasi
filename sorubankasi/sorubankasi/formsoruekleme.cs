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
    public partial class formsoruekleme : Form
    {
        bool isfromadmin = false;
        int subjectid = 0;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        bool ckchecked=false;
        public formsoruekleme(bool fromadmin)
        {
            isfromadmin = fromadmin;
            InitializeComponent();
        }

        private void ckGorsel_CheckedChanged(object sender, EventArgs e)
        {
            ckchecked = ckGorsel.Checked;
            txtgorselurl.Visible = ckchecked;
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            this.Hide();

            if (isfromadmin)
            {
                formadminmain sistema = new formadminmain();
                sistema.ShowDialog();
                this.Close();

            }
            else
            {
                formogretmenmain sistema = new formogretmenmain();
                sistema.ShowDialog();
                this.Close();


            }
        }

        private void btnsoruekle_Click(object sender, EventArgs e)
        {


            using (SqlConnection con = new SqlConnection(SQLConnect.ConnectionString))
            {
                
                StringBuilder sb = new StringBuilder();
                sb.Append("INSERT INTO questions(question, url,trueanswer,falseanswer1,falseanswer2,falseanswer3,subjectid)");
                sb.Append("VALUES ( @question , @url,@tr,@fa1,@fa2,@fa3,@subjectid)");
                using (SqlCommand cmd = new SqlCommand(sb.ToString(), con))
                {

                    cmd.Parameters.AddWithValue("@question", richTextBox1.Text);  
                        cmd.Parameters.AddWithValue("@url", ckchecked?txtgorselurl.Text:"");
                    cmd.Parameters.AddWithValue("@tr", txtrue.Text);
                    cmd.Parameters.AddWithValue("@fa1", txtcevapyanlis1.Text);
                    cmd.Parameters.AddWithValue("@fa2", txtcevapyanlis2.Text);
                    cmd.Parameters.AddWithValue("@fa3", txtcevapyanlis3.Text);
                    cmd.Parameters.AddWithValue("@subjectid", subjectid);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    try
                    {
                        MessageBox.Show("Soru eklendi.");

                    }
                    catch (Exception ex)
                    {
                        
                        MessageBox.Show("Soru ekleme hatası. "+ex.Message);

                    }
                }
            }

        }

        private void formsoruekleme_Load(object sender, EventArgs e)
        {

            List<string> values = new List<string>();
            cmbKonu.Items.Clear();


            con = new SqlConnection(SQLConnect.ConnectionString);
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con; cmd.CommandText = "Select * from subjects;";
            dr = cmd.ExecuteReader();
            try
            {
                while (dr.Read())
                {

                    values.Add(dr[1].ToString());
                }


                foreach (string item in values)
                {
                    cmbKonu.Items.Add(item);
                }
                cmbKonu.SelectedIndex = 0;
            }
            catch (Exception)
            {

                MessageBox.Show("konu yükleme hatası..");
            }

            con.Close();
        }

        private void getsubjectid()
        {

            try
            {
                con = new SqlConnection(SQLConnect.ConnectionString);
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "Select id From subjects Where name='" + cmbKonu.SelectedItem.ToString() + "' ;";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    subjectid = Convert.ToInt16(dr[0]);

                }
                con.Close();
            }
            catch (Exception)
            {

                throw;
            }


        }

        private void cmbKonu_SelectedIndexChanged(object sender, EventArgs e)
        {
            getsubjectid();
        }
    }
}

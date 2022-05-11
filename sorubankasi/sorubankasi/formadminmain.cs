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
    public partial class formadminmain : Form
    {
        SqlDataReader dr;

        public formadminmain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtsubject.Text.Length < 3)
            {
                MessageBox.Show("Konu başlığı 3 karakterden fazla olmalı");
            }
            else
            {
                using (SqlConnection con = new SqlConnection(SQLConnect.ConnectionString))
                {

                    StringBuilder sb = new StringBuilder();
                    sb.Append("INSERT INTO subjects(name)");
                    sb.Append("VALUES ( @value)");
                    using (SqlCommand cmd = new SqlCommand(sb.ToString(), con))
                    {
                        cmd.Parameters.AddWithValue("@value", txtsubject.Text);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                        try
                        {
                            konulariguncelle();
                            MessageBox.Show("Baslik eklendi.");
                            

                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show("Baslik ekleme hatası. " + ex.Message);

                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                this.Hide();
                formsoruekleme sistema = new formsoruekleme(true);
                sistema.ShowDialog();
                this.Close();
            }
        }

        private void formadminmain_Load(object sender, EventArgs e)
        {
            konulariguncelle();
        }

        private void konulariguncelle()
        {
            listBox1.Items.Clear();


            using (SqlConnection con = new SqlConnection(SQLConnect.ConnectionString))
            {

                StringBuilder sb = new StringBuilder();
                sb.Append("Select * from subjects;");
                using (SqlCommand cmd = new SqlCommand(sb.ToString(), con))
                {                    con.Open();

                    dr = cmd.ExecuteReader();
                    try
                    {
                        while (dr.Read())
                        {

                            listBox1.Items.Add(dr[1].ToString());
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Konu başlıkları listelenemdi");

                    }
                }
            }




        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormKayit sistema = new FormKayit(true);
            sistema.ShowDialog();
            this.Close();
        }
    }
    }

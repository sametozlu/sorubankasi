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
    public partial class formogrencimain : Form
    {

        SqlDataReader dr;
        List<questions> quests = new List<questions>();

        bool extended = false;
        private int counter = 10;
        DateTime dt = new DateTime();
        public formogrencimain(int ogrenciid)
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void formogrencimain_Load(object sender, EventArgs e)
        {

            using (SqlConnection con = new SqlConnection(SQLConnect.ConnectionString))
            {

                StringBuilder sb = new StringBuilder();
                sb.Append("Select * from questions;");
                using (SqlCommand cmd = new SqlCommand(sb.ToString(), con))
                {
                    con.Open();

                    dr = cmd.ExecuteReader();
                    try
                    {
                        while (dr.Read())
                        {
                            questions q = new questions();
                            q.id = Convert.ToInt16( dr[0].ToString());
                            q.question = dr[1].ToString();
                            q.trueanswer = dr[2].ToString();
                            q.fa1 = dr[3].ToString();
                            q.fa2 = dr[4].ToString();
                            q.fa3 = dr[5].ToString();
                            q.url = dr[6].ToString();
                            q.subjectid = Convert.ToInt16(dr[7].ToString());
                            quests.Add(q);

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Konu başlıkları listelenemdi");

                    }
                }
            }



            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000;
            timer1.Start();
            lblLeft.Text = "";
        }
         
        private void callquestion()
        {

            pictureBox1.Load("https://www.google.com/images/branding/googlelogo/2x/googlelogo_color_272x92dp.png");



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter--;
            progressBar1.Value-=1;
            if (counter == 0)
            {
                timer1.Stop();
            }
            lblLeft.Text = dt.AddSeconds(counter).ToString(" mm: ss ");

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form form = new Form();

            PictureBox pictureBox = new PictureBox();
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Load("https://www.google.com/images/branding/googlelogo/2x/googlelogo_color_272x92dp.png");
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            form.Controls.Add(pictureBox);

            form.ShowDialog();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            if(!extended||counter%2==0)
            {
                extended = true;
                pictureBox1.Width /= 100;
                pictureBox1.Height /= 100;

                richTextBox1.Width *= 2;
            }
            else if(extended || counter % 2 == 1)
            {
                pictureBox1.Width *= 100;
                pictureBox1.Height *= 100;

                richTextBox1.Width /= 2;

            }
         

        }
    }
}

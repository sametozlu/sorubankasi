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
        string trueansw = "";
        int stid = 0;
        String timeleft = "";
        SqlDataReader dr;
        List<questions> quests = new List<questions>();
        int curr = 0;
        bool extended = false;
        private int counter = 10;
        DateTime dt = new DateTime();
        public formogrencimain(int ogrenciid)
        {
            stid = ogrenciid;
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void formogrencimain_Load(object sender, EventArgs e)
        {
            if(stid==0)
            {
                timer1.Stop();
                grpProgres.Visible = false;

            }
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            lblCurr.Text = "";

            using (SqlConnection con = new SqlConnection(SQLConnect.ConnectionString))
            {

                StringBuilder sb = new StringBuilder();
                sb.Append("Select TOP 10 * from questions order by newid();");
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
                            q.url = dr[2].ToString();

                            q.trueanswer = dr[3].ToString();
                            q.fa1 = dr[4].ToString();
                            q.fa2 = dr[5].ToString();
                            q.fa3 = dr[6].ToString();
                            q.subjectid = Convert.ToInt16(dr[7].ToString());
                            quests.Add(q);

                        }
                        callquestion();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Soru listelemede hata oluştu.");
                        MessageBox.Show(ex.Message);

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
            rdA.Checked = false;
            rdC.Checked = false;
            rdB.Checked = false;
            rdD.Checked = false;



            if(curr==9)
                btnNext.Text = "Cevapla ve Sınavı Sonlandır";


            int[] randArr = new int[4];
            randArr[0] = 1;
            randArr[1] = 1;
            randArr[2] = 1;
            randArr[3] = 1;

            Random rastgele = new Random();
            int i = 1;
            while (i < 4)
            {
                int sayi = rastgele.Next(0, 4);
                if (randArr.Contains(sayi))
                    continue;
                randArr[i] = sayi;
                i++;
            }
            
            
            trueansw= quests[curr].trueanswer.ToString() ;
            string[] st = new string[4];
            st[0] = quests[curr].trueanswer;
            st[1] = quests[curr].fa1;
            st[2] = quests[curr].fa2;
            st[3] = quests[curr].fa3;
            rdA.Text = st[randArr[0]];
            rdB.Text = st[randArr[1]];
            rdC.Text = st[randArr[2]];
            rdD.Text = st[randArr[3]];


            lblCurr.Text = "Soru " + (curr+1).ToString() + "/10";
                if (quests[curr].url != "")
                pictureBox1.Load(quests[curr].url);
              if (!extended && quests[curr].url == "")
            {
                extended = true;
                pictureBox1.Width /= 100;
                pictureBox1.Height /= 100;

                richTextBox1.Width *= 2;
            }
            else if (extended && quests[curr].url != "")
            {
                extended = false;
                pictureBox1.Width *= 100;
                pictureBox1.Height *= 100;

                richTextBox1.Width /= 2;

            }



            richTextBox1.Text = quests[curr].question;


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter--;
            progressBar1.Value-=1;
            if (counter == 0)
            {
                timer1.Stop();
                this.Hide();
                MessageBox.Show("Belirlenen Süre Doldu.");
                fromstudent sistemax = new fromstudent(stid);
                sistemax.ShowDialog();
                this.Close();
            }

            timeleft = "Kalan Süre : " + dt.AddSeconds(counter).ToString(" mm: ss ");
            lblLeft.Text = timeleft;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form form = new Form();

            PictureBox pictureBox = new PictureBox();
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Load(quests[curr].url);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            form.Controls.Add(pictureBox);

            form.ShowDialog();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            bool cevap = false;
            if(rdA.Checked&&rdA.Text==trueansw)
            {
                cevap = true;

            }
            else if (rdB.Checked && rdB.Text == trueansw)
            {
                cevap = true;

            }

            else if (rdC.Checked && rdC.Text == trueansw)
            {
                cevap = true;

            }
            else if (rdD.Checked && rdD.Text == trueansw)
            {
                cevap = true;
            }
            else
            {
                cevap = false;

            }

            if(stid != 0)
            {
                using (SqlConnection con = new SqlConnection(SQLConnect.ConnectionString))
                {

                    StringBuilder sb = new StringBuilder();
                    sb.Append("INSERT INTO quizanswers(subjectid, questionid,result,loginid)");
                    sb.Append("VALUES ( @subjectid,@qid,@r,@loginid)");
                    using (SqlCommand cmd = new SqlCommand(sb.ToString(), con))
                    {


                        try
                        {

                            cmd.Parameters.AddWithValue("@subjectid", quests[curr].subjectid);
                            cmd.Parameters.AddWithValue("@qid", quests[curr].id);
                            cmd.Parameters.AddWithValue("@r", cevap ? 1 : 0);
                            cmd.Parameters.AddWithValue("@loginid", stid);

                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();

                            
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show("Soru cevaplama hatası. " + ex.Message);

                        }
                    }
                }




            }





            curr++;
            if (curr == 10)
            {   
                this.Hide();
                fromstudent sistemax = new fromstudent(stid);
                sistemax.ShowDialog();
                this.Close();
            }
           else if (curr<10)
            {
                callquestion();
            }

           else if (curr>10)
            {
                   MessageBox.Show("Bitti");
            }
            
        }
    }
}

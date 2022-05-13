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
    public partial class fromstudent : Form
    {
        Bitmap bitmap;
        SqlDataReader dr;

        int ogr = 0;
        public fromstudent(int ogrenciid)
        {
            ogr = ogrenciid;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Resize DataGridView to full height.
            int height = dataGridView1.Height;
            dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height;

            //Create a Bitmap and draw the DataGridView on it.
            bitmap = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bitmap, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));

            //Resize DataGridView back to original height.
            dataGridView1.Height = height;

            //Show the Print Preview Dialog.
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
               

        }


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void fromstudent_Load(object sender, EventArgs e)
        {

            dataGridView1.ReadOnly = true; // 
            dataGridView1.AllowUserToDeleteRows = false; // satırların silinmesi engelleniyor
            dataGridView1.ColumnCount = 3; //Kaç kolon olacağı belirleniyor…
            dataGridView1.Columns[0].Name = "Ders Adı";//Kolonların adı belirleniyor
            dataGridView1.Columns[1].Name = "Doğru / Soru Sayısı";
            dataGridView1.Columns[1].Width = Convert.ToInt32((dataGridView1.Columns[1].Width * 1.5).ToString());
            dataGridView1.Columns[2].Name = "Konu Başarı Oranı";
            using (SqlConnection con = new SqlConnection(SQLConnect.ConnectionString))
            {

                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT (SELECT subjects.name from subjects where subjects.id=quizanswers.subjectid) 'baslik' ,COUNT(quizanswers.id) AS 'Soru Sayısı',SUM(quizanswers.result) as 'Doğru Cevap Sayısı' from subjects left  JOIN  quizanswers ON subjects.id=quizanswers.subjectid where quizanswers.loginid="+ogr.ToString()+" GROUP BY quizanswers.subjectid,subjects.id ORDER BY baslik ;");
                using (SqlCommand cmd = new SqlCommand(sb.ToString(), con))
                {
                    con.Open();

                    dr = cmd.ExecuteReader();
                    try
                    {
                        while (dr.Read())
                        {
                            double success = Convert.ToDouble(dr[2].ToString());
                            double total = Convert.ToDouble(dr[1].ToString()); ;
                            double c = success/total*100;

                            dataGridView1.Rows.Add(dr[0].ToString(), success.ToString() + "/" + total.ToString(),
                            "%"+c.ToString());
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Konu başlıkları listelenemdi");

                    }
                }
            }





            if (dataGridView1.Rows.Count == 0)
                button1.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            formogrencimain sistemax = new formogrencimain(ogr);
            sistemax.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            formogrencimain sistemax = new formogrencimain(0);
            sistemax.ShowDialog();
            this.Close();

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sorubankasi
{
    public partial class fromstudent : Form
    {
        int ogr = 0;
        public fromstudent(int ogrenciid)
        {
            ogr = ogrenciid;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

          
            printDocument1.Print();

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void fromstudent_Load(object sender, EventArgs e)
        {

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
    }
}

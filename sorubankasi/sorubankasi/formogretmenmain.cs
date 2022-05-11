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
    public partial class formogretmenmain : Form
    {
        public formogretmenmain()
        {
            InitializeComponent();
        }

        private void formogretmenmain_Load(object sender, EventArgs e)
        {
            timer1.Interval = 100;
            timer1.Start();
            lblclock.Text= DateTime.Now.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblclock.Text = DateTime.Now.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            formsoruekleme sistema = new formsoruekleme(false);
            sistema.ShowDialog();
            this.Close();
        }
    }
}

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
    public partial class formsoruekleme : Form
    {
        bool ckchecked=false;
        public formsoruekleme()
        {
            InitializeComponent();
        }

        private void ckGorsel_CheckedChanged(object sender, EventArgs e)
        {
            ckchecked = ckGorsel.Checked;
            txtgorselurl.Visible = ckchecked;
        }

        private void btngeri_Click(object sender, EventArgs e)
        {

        }

        private void btnsoruekle_Click(object sender, EventArgs e)
        {

        }
    }
}

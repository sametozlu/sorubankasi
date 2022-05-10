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
    public partial class FormKayit : Form
    {
        bool isfromadmin = false;
        public FormKayit(bool fromadmin)
        {

           isfromadmin = fromadmin;
                InitializeComponent();


        }

        private void FormKayit_Load(object sender, EventArgs e)
        {

        }

        private void btnkayit_Click(object sender, EventArgs e)
        {
            
            

        }
    }
}

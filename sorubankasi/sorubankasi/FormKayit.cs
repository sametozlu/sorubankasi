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
    public partial class FormKayit : Form
    {
        bool isfromadmin = false;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        public FormKayit(bool fromadmin)
        {

            isfromadmin = fromadmin;
            InitializeComponent();


        }

        private void FormKayit_Load(object sender, EventArgs e)
        {
            comboBox1.Visible = isfromadmin;
                
            comboBox1.SelectedIndex = 0;

        }

        private void btnkayit_Click(object sender, EventArgs e)
        {
            int selectedusertype = 3;
            if (isfromadmin)
            {
                selectedusertype = comboBox1.SelectedIndex + 2;
            }

            con = new SqlConnection(SQLConnect.ConnectionString);
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con; cmd.CommandText = "Select * from login where login.username='" + txtusername.Text + "'";
            dr = cmd.ExecuteReader();
            if (!dr.Read())
            {

                var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                var stringChars = new char[30];
                var random = new Random();

                for (int i = 0; i < stringChars.Length; i++)
                {
                    stringChars[i] = chars[random.Next(chars.Length)];
                }

                var finalString = new String(stringChars);
                cmd.CommandText = "INSERT INTO login (username,password,hiddenkey,namesurname,type) VALUES('" + txtusername.Text + "'," + "'" + txtpassword.Text + "'," + "'" + finalString + "','" + txtname.Text + "'," + selectedusertype.ToString() + ")";
               // dr = cmd.ExecuteReader();

                MessageBox.Show("Tebrikler! Başarılı bir şekilde kayıt oluşturuldu. Kurtarma şifresi "+finalString);
                // this.Hide();
                //     frmTeacherMain frmNew = new frmTeacherMain();
                //     frmNew.ShowDialog();
                //   this.Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı adınız uygun degil.");
            }

            con.Close();




        }

        private void btnback_Click(object sender, EventArgs e)
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
                Form1 sistema = new Form1();
                sistema.ShowDialog();
                this.Close();


            }
        
        }
    } 
}


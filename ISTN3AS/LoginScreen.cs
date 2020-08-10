using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISTN3AS
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void btnExit2Home_Click(object sender, EventArgs e)
        {
            mainMenu mm = new mainMenu();
            mm.ShowDialog();
            this.Close();

        }

        private void btnStaffSign_Click(object sender, EventArgs e)
        {
            try
            {
                this.checkLoginTableAdapter.CheckLoginDetails(this.LoginDS.CheckLogin, tbxUsername_Login.Text, tbxPassword_Login.Text);
                int t = this.LoginDS.CheckLogin.Rows.Count;
                Object h = this.LoginDS.CheckLogin.Rows[0][1];
                if(this.LoginDS.CheckLogin.Rows[0][0].ToString().ToUpper() == tbxUsername_Login.Text.ToUpper() && this.LoginDS.CheckLogin.Rows[0][1].ToString() == tbxPassword_Login.Text)
                {
                    salesControl sc = new salesControl();
                    this.Hide();
                    sc.ShowDialog();
                    this.Close();
                }
                else {
                    MessageBox.Show("Incorrect Password");
                }

            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Incorrect Login Details");
            }


            //
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void checkLoginDetailsToolStripButton_Click(object sender, EventArgs e)
        {
            

        }
    }
}

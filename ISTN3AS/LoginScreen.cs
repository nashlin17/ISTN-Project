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
            salesControl sc = new salesControl();
            this.Hide();
            sc.ShowDialog();
            this.Close();
        }
    }
}

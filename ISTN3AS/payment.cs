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
    public partial class payment : Form
    {
        private salesControl sc;
        
        
        public payment()
        {
            
            InitializeComponent();
            
        }

        public payment(salesControl sc)
        {
            this.sc = sc;
            InitializeComponent();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            sc.btnCashOut.Enabled = true;
            sc.btnItems.Enabled = false;
            sc.btnMenuOrder.Enabled = true;
            sc.btnMenuPurchase.Enabled = true;
            sc.tabcontrol1.SelectedIndex=4 ;
            sc.gbItemsScroll.SendToBack();
            sc.tabcontrol1.Width = 1088;
            sc.tabcontrol1.Height = 638;
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            sc.btnCashOut.Enabled = true;
            sc.btnItems.Enabled = false;
        }
    }
}

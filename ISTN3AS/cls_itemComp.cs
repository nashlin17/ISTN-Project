using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTN3AS
{
   
    class cls_itemComp
    {
        public void Intialise(salesControl formInstance)
        {
            formInstance.btnLogOut.BackColor = System.Drawing.Color.Transparent;
            formInstance.lblCompany.BackColor = System.Drawing.Color.Transparent;
            formInstance.lblUsrname.BackColor = System.Drawing.Color.Transparent;
            formInstance.btnItems.BackColor = System.Drawing.Color.Transparent;
            formInstance.btnCashOut.BackColor = System.Drawing.Color.Transparent;
            formInstance.btnAddUser.BackColor = System.Drawing.Color.Transparent;
            formInstance.btnAdd2.BackColor = System.Drawing.Color.Transparent;
            formInstance.btnCustAcc.BackColor = System.Drawing.Color.Transparent;
            formInstance.btnCat1.BackColor = System.Drawing.Color.Transparent;
            formInstance.btnCat2.BackColor = System.Drawing.Color.Transparent;
            formInstance.btnCat3.BackColor = System.Drawing.Color.Transparent;
            formInstance.btnCat4.BackColor = System.Drawing.Color.Transparent;
            formInstance.btnCat5.BackColor = System.Drawing.Color.Transparent;
            formInstance.btnReturns.BackColor = System.Drawing.Color.Transparent;
        }
       
        public void Hidebuttons(salesControl formInstance)
        {
            formInstance.btnCat1.Hide();
            formInstance.btnCat2.Hide();
            formInstance.btnCat3.Hide();
            formInstance.btnCat4.Hide();
            formInstance.btnCat5.Hide();
        }

        public void Showbuttons(salesControl formInstance)
        {
            formInstance.btnCat1.Show();
            formInstance.btnCat2.Show();
            formInstance.btnCat3.Show();
            formInstance.btnCat4.Show();
            formInstance.btnCat5.Show();
        }


        public void Purchase(salesControl formInstance)
        {
            formInstance.btnAccessPurchase.Enabled=true;
            formInstance.btnCapPurchase.Enabled = true;
            formInstance.btnGymPurchase.Enabled = true;
            formInstance.btnMenuPurchase.Enabled = true;
            formInstance.btnShoePurchase.Enabled = true;
            formInstance.btnTshirtPurchase.Enabled = true;

            formInstance.btnAccessOrder.Enabled = false;
            formInstance.btnCapOrder.Enabled = false;
            formInstance.btnGymOrder.Enabled = false;
            formInstance.btnMenuOrder.Enabled = false;
            formInstance.btnShoeOrder.Enabled = false;
            formInstance.btnTshirtOrder.Enabled = false;
        }

        public void Order(salesControl formInstance)
        {
            formInstance.btnAccessPurchase.Enabled = false;
            formInstance.btnCapPurchase.Enabled = false;
            formInstance.btnGymPurchase.Enabled = false;
            formInstance.btnMenuPurchase.Enabled = false;
            formInstance.btnShoePurchase.Enabled = false;
            formInstance.btnTshirtPurchase.Enabled = false;

            formInstance.btnAccessOrder.Enabled = true;
            formInstance.btnCapOrder.Enabled = true;
            formInstance.btnGymOrder.Enabled = true;
            formInstance.btnMenuOrder.Enabled = true;
            formInstance.btnShoeOrder.Enabled = true;
            formInstance.btnTshirtOrder.Enabled = true;
        }


    }
}

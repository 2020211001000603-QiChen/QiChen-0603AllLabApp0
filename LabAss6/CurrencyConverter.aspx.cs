using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LabAss6
{
    public partial class CurrencyConverter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnOk_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "" || txtNumber.Text == null)
            {
                lblResult.Text = "Currency denomination cannot be empty.";
                return;
            }
            else
            {
                double n1 = Convert.ToDouble(txtNumber.Text);
                string result = String.Format("{0:F}", n1 * 0.1500);
                lblResult.Text = txtNumber.Text + " Chinese Yuan = " + result.ToString() + " Dollar.";
            }
        }
    }
}
using Finance_WebForm_OIL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Finance_WebForm_OIL
{
    public partial class _Default : Page
    {
        MyContext myContext;
        protected void Page_Load(object sender, EventArgs e)
        {
            myContext = new MyContext();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            int personcode = int.Parse(txtPersonCode.Text);
            int hourpay = int.Parse(txtHourpay.Text);

            Employe employe = new Employe()
            {
                Name=name,
                PersonCode=personcode,
                HourPay=hourpay 
            };

            myContext.employes.Add(employe);
            myContext.SaveChanges();
            Response.Redirect("Default.aspx");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AdmissionSystem.BAL;
using AdmissionSystem.Entities;

namespace AdmissiontSystem.PL
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            StudLogin studLogin = new StudLogin();
            if (TextBox1.Text == studLogin.STUDENTID.ToString() && TextBox2.Text == studLogin.PASSWORD)
                Response.Redirect("RegisterUser.aspx");
            else
                Label7.Text = "Invalid Details";
        }
    }
}
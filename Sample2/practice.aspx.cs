using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sample2
{
    public partial class practice : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string Firstname = TextBox1.Text;
            string Lastname = TextBox2.Text;
            Session["Firstname"] = Firstname;
            Session["Lastname"] = Lastname;
            Response.Redirect("practice2.aspx");
        }
    }
}
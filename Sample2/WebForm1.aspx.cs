using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Sample2;
using Sample2.App_Code;

namespace Sample2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtname.Value = "name";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            BulletedList1.DataSource = extensibility.GetList();
            BulletedList1.DataBind();

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        GridView1.DataBind();
        GridView2.DataBind();
        GridView1.Visible = false;
        GridView2.Visible = false;               

    }



    protected void Button1_Click(object sender, EventArgs e)
    {        
        GridView1.Visible = true;
        GridView2.Visible = false;
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        GridView1.Visible = false;
        GridView2.Visible = true;
    }
}
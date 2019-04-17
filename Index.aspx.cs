using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections.Specialized;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    string conStr = @"server=hhidatabase.chi0h0eoorog.us-east-1.rds.amazonaws.com;database=hhidatabase;uid=hhi;password=hhidatabase;";
    public static bool loggedIn = false;
    protected void Page_Load(object sender, EventArgs e)
    {        
        log.Visible = Convert.ToBoolean(Session["loggedIn"]);

    }


    protected void IndexMessageButton_Click(object sender, EventArgs e)
    {
       



    }
}
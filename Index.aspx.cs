using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
   
    public static bool loggedIn = false;
    protected void Page_Load(object sender, EventArgs e)
    {        
        log.Visible = Convert.ToBoolean(Session["loggedIn"]);

    }
   
}
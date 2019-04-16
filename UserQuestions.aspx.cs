using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnContinue_Click(object sender, EventArgs e)
    {
        
        if (adultYes.Checked)
        {
            Response.Redirect("CreateAdultAccount.aspx");
        }
        else{
            Response.Redirect("CreateYouthAccount.aspx");
            }
        //else { Label1.Text = "Not all options selected"; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Resources : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        
        // Get the currently selected row using the SelectedRow property.
        GridViewRow row = GridView1.SelectedRow;
        
        // Store URL from gridview into string
        string url = " ";
        url = row.Cells[3].Text;
        Response.Write("<script>window.open('"+url+"','_blank')</script>");
        

        
    }

}
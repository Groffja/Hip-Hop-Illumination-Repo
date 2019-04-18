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
        // Check session is expire or timeout. 
        if (Session["adminLoggedIn"] == null)
        {
            Response.Redirect("Login.aspx?info=0");
        }

        GridView1.DataBind();
        GridView2.DataBind();        
        DataBind();

    }

    protected void txtSearch_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {

        String search = txtSearch.Text;
        Session["test"] = search;
        bindGrid();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {        
        GridView1.Visible = true;
        GridView2.Visible = false;
        Session["type"] = "Youth";
        panel.Visible = true;
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        GridView1.Visible = false;
        GridView2.Visible = true;
        Session["type"] = "Adult";
        panel.Visible = true;
    }
    protected void bindGrid()
    {
        string type = Session["type"].ToString();
        string search2 = Session["test"].ToString().Trim();
        SqlDataSource1.SelectCommand = "SELECT accountID, username, email, lastUpdated FROM LoginInfo WHERE (accountType = '"+type+"' AND  username LIKE '%"+search2+"%')";
        SqlDataSource2.SelectCommand = "SELECT accountID, username, email, lastUpdated FROM LoginInfo WHERE (accountType = '" + type + "' AND  username LIKE '%" + search2 + "%')";
    }
}
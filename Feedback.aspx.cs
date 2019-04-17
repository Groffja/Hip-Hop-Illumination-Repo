using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

public partial class Feedback : System.Web.UI.Page
{

    string conStr = @"server=hhidatabase.chi0h0eoorog.us-east-1.rds.amazonaws.com;database=hhidatabase;uid=hhi;password=hhidatabase;";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack)
        {

            this.BindGrid();
        }




    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void txtSearch_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {

        String search = txtSearch.Text;
        Session["test"] = search;

        GridViewSearchFeedback.DataBind();
        GridViewSearchFeedback.Visible = true;
        GridView2.Visible = false;

        if(txtSearch.Text == "")
        {
            GridViewSearchFeedback.Visible = false;
            GridView2.Visible = true;
        }


    }

    private void BindGrid()
    {
        using (SqlConnection cn = new SqlConnection(conStr))
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "SELECT Feedback.accountID, LoginInfo.username, LoginInfo.email, Feedback.comment FROM Feedback INNER JOIN LoginInfo ON Feedback.accountID = LoginInfo.accountID WHERE Feedback.comment LIKE '%" + "@Name"  + "%'";
                cmd.Connection = cn;
                cmd.Parameters.AddWithValue("@Name", txtSearch.Text.Trim());
                DataTable dt = new DataTable();
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    sda.Fill(dt);
                    //GridView2.DataSource = dt;
                    GridView2.DataBind();
                }
            }
        }
    }





    protected void SqlDataSourceFeedback_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
    {

    }
}
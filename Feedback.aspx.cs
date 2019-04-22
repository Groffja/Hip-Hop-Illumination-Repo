
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

    string conStr = @"Server =localhost;Database=hhidatabase;Trusted_Connection=Yes;";
    protected void Page_Load(object sender, EventArgs e)
    {
        DataBind();
        // Check session is expire or timeout. 
        if (Session["loggedIn"] == null)
        {
            Response.Redirect("Login.aspx?info=0");
        }

        if (IsPostBack)
        {

            this.BindGrid();
        }




    }





    protected void btnSearch_Click(object sender, EventArgs e)
    {
        BindGrid();
        

    }

    private void BindGrid()
    {
        string feedback = txtSearch.Text.Trim();
        
        
        SqlDataSourceFeedback.SelectCommand = "SELECT Feedback.accountID, LoginInfo.username, LoginInfo.email,  Feedback.comment FROM Feedback INNER JOIN LoginInfo ON Feedback.accountID = LoginInfo.accountID WHERE([comment] LIKE '%"+feedback+"%')";



    }

    private void BindGrid2()
    {
        string username = TxtSearchUsername.Text.Trim();
        SqlDataSourceFeedback.SelectCommand = "SELECT Feedback.accountID, LoginInfo.username, LoginInfo.email,  Feedback.comment FROM Feedback INNER JOIN LoginInfo ON Feedback.accountID = LoginInfo.accountID WHERE([username] LIKE '%"+username+"%')";
    }






    protected void SqlDataSourceFeedback_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
    {

    }

   









    protected void btnSearchUsername_Click(object sender, EventArgs e)
    {
        BindGrid2();
    }


}
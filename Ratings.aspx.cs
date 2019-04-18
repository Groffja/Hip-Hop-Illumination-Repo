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

public partial class _Default : System.Web.UI.Page
{
    string conStr = @"server=hhidatabase.chi0h0eoorog.us-east-1.rds.amazonaws.com;database=hhidatabase;uid=hhi;password=hhidatabase;";

    protected void Page_Load(object sender, EventArgs e)
    {
        DataBind();

    }


    protected void btnSearch_Click(object sender, EventArgs e)
    {
        BindGrid();
    }


    private void BindGrid()
    {
        string lesson = txtSearchbar.Text.Trim();
        SqlDataSourceRating.SelectCommand = "SELECT Ratings.ratingID as RatingID, Documents.Name as Lesson, Ratings.rating as Rating, Ratings.comment as Comment, LoginInfo.username as Username FROM Documents INNER JOIN Ratings ON Documents.ID = Ratings.ID INNER JOIN LoginInfo ON Ratings.accountID = LoginInfo.accountID WHERE Name LIKE '%" + lesson + "%'";

    }
}
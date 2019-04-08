using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class MasterPageLoggedIn : System.Web.UI.MasterPage
{
    System.Data.SqlClient.SqlConnection sc = new System.Data.SqlClient.SqlConnection();

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {

            sc.ConnectionString = @"Server = LocalHost; Database = hhidatabase; Trusted_Connection = Yes";
            sc.Open();
            System.Data.SqlClient.SqlCommand insert = new System.Data.SqlClient.SqlCommand();
            insert.Connection = sc;
            sc.Close();

        }
        catch (Exception)
        {
        }


        if (!IsPostBack) //Checking if first page load
        {
            try
            {
                sc.ConnectionString = @"Server = LocalHost; Database = hhidatabase; Trusted_Connection = Yes";

                sc.Open();
                System.Data.SqlClient.SqlCommand insert = new System.Data.SqlClient.SqlCommand();
                insert.Connection = sc;
                sc.Close();

            }
            catch (Exception)
            {
            }

        }

    }
    protected void btnLogout_Click(object sender, EventArgs e)
    {
        Session.Clear();
        Session["loggedIn"] = "false";
        Session.Abandon();
        Session.RemoveAll();
        Response.Redirect("index.aspx");
    }




    //direct recommendation page based on user type
    protected void LinkBtnRecommendation_Click(object sender, EventArgs e)
    {

        sc.Close();
        sc.Open();
        System.Data.SqlClient.SqlCommand insert = new System.Data.SqlClient.SqlCommand();
        insert.Connection = sc;


        insert.CommandText = "SELECT accountID, accountType from LoginInfo where email = '" + Session["email"] + "'";
        insert.ExecuteNonQuery();

        SqlDataReader reader = insert.ExecuteReader();
        while (reader.Read())
        {
            string accountType = reader["accountType"].ToString();
            Session["accountType"] = accountType;

            if (Convert.ToString(Session["accountType"]) == "Adult")
            {
                Response.Redirect("RecommendationPage.aspx");

            }
            else
            {
                Response.Redirect("RecommendationForYandYW.aspx");

            }

        }
        reader.Close();



    }
}

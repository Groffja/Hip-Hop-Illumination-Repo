using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Activities.Validation;

public partial class ProfilePage : System.Web.UI.Page
{
    System.Data.SqlClient.SqlConnection sc = new System.Data.SqlClient.SqlConnection();
    string exception = string.Empty;

    protected void Page_Load(object sender, EventArgs e)
    {
        // Check session is expire or timeout. 
        if (Session["email"] == null)
        {
            Response.Redirect("Login.aspx?info=0");
        }

        try
        {
            sc.ConnectionString = @"server=hhidatabase.chi0h0eoorog.us-east-1.rds.amazonaws.com;database=hhidatabase;uid=hhi;password=hhidatabase;";

        }

        catch (Exception ex)
        {
            exception = ex.GetType().ToString();

        }
        // ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

        sc.Open();
        System.Data.SqlClient.SqlCommand getFields = new System.Data.SqlClient.SqlCommand();
        getFields.Connection = sc;

        string firstName = "";
        string lastName = "";
        int count = 0;

        if (!IsPostBack)
        {
            if ((string)Session["Accounttype"] == "Adult")
            {
                getFields.CommandText = "select firstName, lastName, email, username from Adult where email=@email";
                getFields.Parameters.Add(new SqlParameter("@email", (string)Session["email"]));
                SqlDataReader reader = getFields.ExecuteReader();
                while (reader.Read())
                {
                    firstName = reader["firstName"].ToString();
                    lastName = reader["lastName"].ToString();

                    welcome.InnerText = "Welcome, " + firstName + " " + lastName + "!";
                }
                reader.Close();
                lessons.Visible = false;
            }
            if ((string)Session["Accounttype"] == "Admin")
            {
                getFields.CommandText = "select firstName, lastName, username from Admin where email=@email";
                getFields.Parameters.Add(new SqlParameter("@email", (string)Session["email"]));
                SqlDataReader reader = getFields.ExecuteReader();
                while (reader.Read())
                {
                    firstName = reader["firstName"].ToString();
                    lastName = reader["lastName"].ToString();

                    welcome.InnerText = "Welcome, " + firstName + " " + lastName + "!";
                }
                reader.Close();
                lessons.Visible = false;
              
            }
            if ((string)Session["Accounttype"] == "Youth")
            {
                getFields.CommandText = "SELECT firstName, lastName FROM Youth Where email = @email";

                getFields.Parameters.Add(new SqlParameter("@email", (string)Session["email"]));
                SqlDataReader reader = getFields.ExecuteReader();
                while (reader.Read())
                {
                    firstName = reader["firstName"].ToString();
                    lastName = reader["lastName"].ToString();

                    welcome.InnerText = "Welcome, " + firstName + " " + lastName + "!";
                }
                reader.Close();

                getFields.CommandText = "SELECT COUNT(*) as count FROM(SELECT Lessons.ID, Youth.email FROM Lessons INNER JOIN Youth ON Lessons.accountID = Youth.accountID where Youth.email = @email) t";
                //getFields.Parameters.Add(new SqlParameter("@email", (string)Session["email"]));
                SqlDataReader reader2 = getFields.ExecuteReader();
                while (reader2.Read())
                {
                    count = int.Parse(reader2["count"].ToString());
                    lessons.InnerText = "Lessons Completed: " + count.ToString();
                }
                reader2.Close();
            }
        }

        username.InnerText = Session["username"].ToString();

    }
}
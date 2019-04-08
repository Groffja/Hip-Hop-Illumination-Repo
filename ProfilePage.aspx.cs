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
        try
        {
            sc.ConnectionString = @"Server =localhost;Database=hhidatabase;Trusted_Connection=Yes;";

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
        string school1 = "";
        int count = 0;

        if (!IsPostBack)
        {
            if ((string)Session["Accounttype"] == "Adult")
            {
                getFields.CommandText = "select firstName, middleName, lastName, street, city, state, zip, country, gender, email, dateOfBirth, username from Adult where email=@email";
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
                school.Visible = false;
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
                school.Visible = false;
            }
            if ((string)Session["Accounttype"] == "Youth")
            {
                getFields.CommandText = "SELECT School.schoolName, Youth.youthFirstName, Youth.youthLastName, Youth.youthID FROM Youth INNER JOIN School ON Youth.youthSchool = School.schoolID Where youth.email = @email";
                getFields.Parameters.Add(new SqlParameter("@email", (string)Session["email"]));
                SqlDataReader reader = getFields.ExecuteReader();
                while (reader.Read())
                {
                    firstName = reader["youthFirstName"].ToString();
                    lastName = reader["youthLastName"].ToString();
                    school1 = reader["schoolName"].ToString();

                    welcome.InnerText = "Welcome, " + firstName + " " + lastName + "!";
                    school.InnerText = school1;
                }
                reader.Close();

                getFields.CommandText = "SELECT COUNT(*) as count FROM(SELECT LessonYouth.ID, Youth.email FROM LessonYouth INNER JOIN Youth ON LessonYouth.youthID = Youth.youthID where Youth.email = @email) t";
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
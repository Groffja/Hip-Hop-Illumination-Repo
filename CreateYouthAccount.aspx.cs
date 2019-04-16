using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class CreateYouthAccount : System.Web.UI.Page
{
    String YouthFirstName;
    String YouthMiddleName;
    String YouthLastName;
    String YouthStreet;
    String YouthCity;
    String YouthState;
    String YouthZipcode;
    String YouthCountry;
    String YouthEmail;
    DateTime YouthDateOfBirth;
    DateTime YouthCreateTime;
    String YouthUserName;
    String YouthPassword;
    String YouthGender;
    String favoriteArtist;
    String favoriteMusic;
    int accountID1;



    System.Data.SqlClient.SqlConnection sc = new System.Data.SqlClient.SqlConnection();

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {

            sc.ConnectionString = ConfigurationManager.ConnectionStrings["manageUsers"].ConnectionString;
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
                sc.ConnectionString = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
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

    // State only enabled when country = United States
    protected void DropDowncountry_SelectedIndexChanged(object sender, EventArgs e)
    {
        String US = "US";
        string country = ddlCountry.SelectedValue;
        if (country == US)
        {
            ddlState.Enabled = true;
        }
        else
        {
            ddlState.Enabled = false;
        }
    }

    protected void btnRegister_Click(object sender, EventArgs e)
    {

        if (Page.IsValid)
        {
            sc.Close();



            //update data using list in the class
            YouthFirstName = HttpUtility.HtmlEncode(txtFirstName.Text);
            YouthLastName = HttpUtility.HtmlEncode(txtLastName.Text);
            YouthState = HttpUtility.HtmlEncode(ddlState.Text);
            YouthCountry = HttpUtility.HtmlEncode(ddlCountry.SelectedItem.Value);
            YouthEmail = HttpUtility.HtmlEncode(txtEmail.Text);
            YouthGender = HttpUtility.HtmlEncode(ddlGender.SelectedItem.Value);
            YouthDateOfBirth = DateTime.Parse(txtDateOfBirth.Text);
            YouthUserName = HttpUtility.HtmlEncode(txtUsername.Text);
            YouthPassword = HttpUtility.HtmlEncode(txtPassword.Text);
            favoriteArtist = HttpUtility.HtmlEncode(txtFavoriteArtist.Text);
            favoriteMusic = HttpUtility.HtmlEncode(txtfavoriteMusic.Text);

            sc.Open();
            string emails = " ";
            SqlCommand emailCheck = new SqlCommand();
            emailCheck.Connection = sc;
            emailCheck.CommandText = "Select NULLIF(email,' ') as email from loginInfo WHERE email = @email";
            emailCheck.Parameters.AddWithValue("@email", YouthEmail);

            SqlDataReader reader1 = emailCheck.ExecuteReader();

            while (reader1.Read())
            {
                emails = reader1["email"].ToString();

            }



            reader1.Close();
            sc.Close();
            if (emails == " ")
            {

                //INSERT INTO LOGININFO
                sc.Open();
                SqlCommand login = new SqlCommand();
                login.Connection = sc;
                login.CommandText = "INSERT INTO [dbo].[LoginInfo] VALUES (@accountType, @username, @Xpassword, @email, @lastUpdated, @lastUpdatedBy);";
                login.Parameters.AddWithValue("@accountType", "Youth");
                login.Parameters.AddWithValue("@username", YouthUserName);
                login.Parameters.AddWithValue("@Xpassword", PasswordHash.HashPassword(YouthPassword));
                login.Parameters.AddWithValue("@email", YouthEmail);
                login.Parameters.AddWithValue("@lastUpdated", DateTime.Now.ToString());
                login.Parameters.AddWithValue("@lastUpdatedBy", YouthUserName);
                login.ExecuteNonQuery();
                sc.Close();



                sc.Open();
                // Pull the accountID from the loginInfo table for reference in the Youth table
                SqlCommand accountID = new SqlCommand();
                accountID.Connection = sc;
                accountID.CommandText = "Select accountID from loginInfo WHERE email = @email";
                accountID.Parameters.AddWithValue("@email", YouthEmail);

                SqlDataReader reader = accountID.ExecuteReader();
                while (reader.Read())
                {
                    accountID1 = int.Parse(reader["accountID"].ToString());
                }
                reader.Close();
                sc.Close();


                sc.Open();
                // Insert new youth account into the Youth table
                System.Data.SqlClient.SqlCommand insert = new System.Data.SqlClient.SqlCommand();
                insert.Connection = sc;
                insert.CommandText = "INSERT into [dbo].Youth VALUES(@youthFirstName, @youthLastName, " +
                    "NULLIF(@youthState,' '), @youthCountry, @youthGender, @youthEmail, @youthDateOfBirth, @username, @password, @dateCreated, @lastUpdated, @lastUpdatedBy, NULLIF(@favoriteArtist, ' '), NULLIF(@favoriteMusic, ' '), @accountID)";

                insert.Parameters.AddWithValue("@youthFirstName", YouthFirstName);
                insert.Parameters.AddWithValue("@youthLastName", YouthLastName);
                insert.Parameters.AddWithValue("@youthState", YouthState);
                insert.Parameters.AddWithValue("@youthCountry", YouthCountry);
                insert.Parameters.AddWithValue("@youthEmail", YouthEmail);
                insert.Parameters.AddWithValue("@youthGender", YouthGender);
                insert.Parameters.AddWithValue("@youthDateOfBirth", YouthDateOfBirth);
                insert.Parameters.AddWithValue("@userName", YouthUserName);
                insert.Parameters.AddWithValue("@password", PasswordHash.HashPassword(YouthPassword));
                insert.Parameters.AddWithValue("@dateCreated", DateTime.Today);
                insert.Parameters.AddWithValue("@lastUpdated", DateTime.Now.ToString());
                insert.Parameters.AddWithValue("@lastUpdatedBy", YouthUserName);
                insert.Parameters.AddWithValue("@favoriteArtist", favoriteArtist);
                insert.Parameters.AddWithValue("@favoriteMusic", favoriteMusic);
                insert.Parameters.AddWithValue("@accountID", accountID1);


                insert.ExecuteNonQuery();

                Response.Redirect("Login.aspx");
            }

            else
            {
                lblEmailVal.Text = "ERROR:Email Provided already registered with an account!!";
            }


        }
    }


}
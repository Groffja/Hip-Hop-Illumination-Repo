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
            YouthDateOfBirth = DateTime.Parse(txtDateOfBirth.Text);
            YouthGender = HttpUtility.HtmlEncode(ddlGender.SelectedItem.Value);
            YouthUserName = HttpUtility.HtmlEncode(txtUsername.Text);
            YouthPassword = HttpUtility.HtmlEncode(txtPassword.Text);
            favoriteArtist = HttpUtility.HtmlEncode(txtFavoriteArtist.Text);
            favoriteMusic = HttpUtility.HtmlEncode(txtFavoriteMusic.Text);

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
                Youth tempYouth = new Youth(YouthFirstName, YouthLastName, YouthState, YouthCountry, YouthEmail, YouthDateOfBirth.ToString(), YouthGender, favoriteArtist, favoriteMusic, YouthUserName, YouthPassword);
                //INSERT INTO LOGININFO
                sc.Open();
                SqlCommand login = new SqlCommand();
                login.Connection = sc;
                login.CommandText = "INSERT INTO [dbo].[LoginInfo] VALUES (@accountType, @username, @Xpassword, @email, @lastUpdated, @lastUpdatedBy);";
                login.Parameters.AddWithValue("@accountType", "Youth");
                login.Parameters.AddWithValue("@username", tempYouth.getUserName());
                login.Parameters.AddWithValue("@Xpassword", PasswordHash.HashPassword(tempYouth.getPassword()));
                login.Parameters.AddWithValue("@email", tempYouth.getEmail());
                login.Parameters.AddWithValue("@lastUpdated", DateTime.Now.ToString());
                login.Parameters.AddWithValue("@lastUpdatedBy", tempYouth.getUserName());
                login.ExecuteNonQuery();
                sc.Close();



                sc.Open();
                // Pull the accountID from the loginInfo table for reference in the Youth table
                SqlCommand accountID = new SqlCommand();
                accountID.Connection = sc;
                accountID.CommandText = "Select accountID from loginInfo WHERE email = @email";
                accountID.Parameters.AddWithValue("@email", tempYouth.getEmail());

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

                insert.Parameters.AddWithValue("@youthFirstName", tempYouth.getFirstName());
                insert.Parameters.AddWithValue("@youthLastName", tempYouth.getLastName());
                insert.Parameters.AddWithValue("@youthState", tempYouth.getState());
                insert.Parameters.AddWithValue("@youthCountry", tempYouth.getCountry());
                insert.Parameters.AddWithValue("@youthEmail", tempYouth.getEmail());
                insert.Parameters.AddWithValue("@youthGender", tempYouth.getGender());
                insert.Parameters.AddWithValue("@youthDateOfBirth", tempYouth.getDateOfBirth());
                insert.Parameters.AddWithValue("@userName", tempYouth.getUserName());
                insert.Parameters.AddWithValue("@password", PasswordHash.HashPassword(tempYouth.getPassword()));
                insert.Parameters.AddWithValue("@dateCreated", DateTime.Today);
                insert.Parameters.AddWithValue("@lastUpdated", DateTime.Now.ToString());
                insert.Parameters.AddWithValue("@lastUpdatedBy", tempYouth.getUserName());
                insert.Parameters.AddWithValue("@favoriteArtist", tempYouth.getFavoriteArtist());
                insert.Parameters.AddWithValue("@favoriteMusic", tempYouth.getFavoriteMusic());
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
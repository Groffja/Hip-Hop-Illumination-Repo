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

    protected void btnRegister_Click(object sender, EventArgs e)
    {

        if (Page.IsValid)
        {

            //try
            //{
                sc.Close();
                sc.Open();
                System.Data.SqlClient.SqlCommand insert = new System.Data.SqlClient.SqlCommand();
                insert.Connection = sc;

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
                favoriteMusic = HttpUtility.HtmlEncode(txtFavoriteMusic.Text);

                //INSERT INTO LOGININFO
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
                Response.Redirect("Login.aspx");


                sc.Open();



            // Pull the accountID from the loginInfo table for reference in the Youth table
            SqlCommand accountID = new SqlCommand();
            accountID.Connection = sc;
            accountID.CommandText = "Select @accountID from loginInfo WHERE email = @email";
            accountID.Parameters.AddWithValue("@accountID", accountID);
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
            insert.CommandText = "INSERT into [dbo].Youth VALUES(@youthFirstName, @youthLastName, " +
                "NULLIF(@youthState,' '), @youthCountry, @youthEmail, @youthGender, @youthDateOfBirth, @username, @password, @dateCreated, @lastUpdated, @lastUpdatedBy, NULLIF(@favoriteArtist, ' '), NULLIF(@favoriteMusic, ' '), @accountID)";

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

            //}
            //catch (Exception)
            //{
                
            //}
            
            

        }
    }


}
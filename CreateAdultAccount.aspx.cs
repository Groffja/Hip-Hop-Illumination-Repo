using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Activities.Validation;

public partial class CreateAdultAccount : System.Web.UI.Page
{
    System.Data.SqlClient.SqlConnection sc = new System.Data.SqlClient.SqlConnection();
    string exception = string.Empty;
    int accountID1;

    protected void Page_Load(object sender, EventArgs e)
    {

        try
        {
            sc.ConnectionString = @"Server =localhost;Database=hhidatabase;Trusted_Connection=Yes;";
            //sc.ConnectionString = @"server=hhidatabase.chi0h0eoorog.us-east-1.rds.amazonaws.com;database=hhidatabase;uid=hhi;password=hhidatabase;";

        }

        catch (Exception ex)
        {
            exception = ex.GetType().ToString();

        }
        // ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

    }

    // State only enabled when country = United States
    protected void DropDowncountry_SelectedIndexChanged(object sender, EventArgs e)
    {
        String US = "US";
        string country = DropDowncountry.SelectedValue;
        if (country == US)
        {
            DropDownstate.Enabled = true;
        }
        else
        {
            DropDownstate.Enabled = false;
        }
    }

    protected void CreateAccount_Click1(object sender, EventArgs e)
    {
        string firstname = HttpUtility.HtmlEncode(txtFirstName.Text);
        string lastname = HttpUtility.HtmlEncode(txtLastName.Text);
        string country = HttpUtility.HtmlEncode(DropDowncountry.Text);
        string password = HttpUtility.HtmlEncode(txtPassword.Text);
        string username = HttpUtility.HtmlEncode(txtUsername.Text);
        string dateOfBirth = HttpUtility.HtmlEncode(txtDateOfBirth.Text);
        string gender = HttpUtility.HtmlEncode(DropDowngender.Text);
        string email = HttpUtility.HtmlEncode(txtEmail.Text);
        string state = HttpUtility.HtmlEncode(DropDownstate.Text);
        string user = HttpUtility.HtmlEncode(DropDownuser.Text);
        string favoriteArtist = HttpUtility.HtmlEncode(txtFavoriteArtist2.Text);
        string favoriteMusic = HttpUtility.HtmlEncode(txtFavoriteMusic2.Text);

        // if Country is not United States
        if (DropDownstate.Enabled == false)
        {
            state = "test ";
        }
        sc.Open();
        string emails = " ";
        SqlCommand emailCheck = new SqlCommand();
        emailCheck.Connection = sc;
        emailCheck.CommandText = "Select NULLIF(email,' ') as email from loginInfo WHERE email = @email";
        emailCheck.Parameters.AddWithValue("@email", email);

        SqlDataReader reader1 = emailCheck.ExecuteReader();
        
        while (reader1.Read())
        {
            emails = reader1["email"].ToString();
            
        }
        
        
        
        reader1.Close();
        sc.Close();
        if (emails == " ")
        {




            Adult tempAdult = new Adult(firstname, lastname, state, country, user, email, dateOfBirth, gender, favoriteArtist, favoriteMusic, username, password);


            //INSERT INTO LOGININFO
            sc.Open();
            SqlCommand login = new SqlCommand();
            login.Connection = sc;
            login.CommandText = "INSERT INTO [dbo].[LoginInfo] VALUES (@accountType, @username, @Xpassword, @email, @lastUpdated, @lastUpdatedBy);";
            login.Parameters.AddWithValue("@accountType", "Adult");
            login.Parameters.AddWithValue("@username", tempAdult.getUserName());
            login.Parameters.AddWithValue("@Xpassword", PasswordHash.HashPassword(txtPassword.Text));
            login.Parameters.AddWithValue("@email", tempAdult.getEmail());
            login.Parameters.AddWithValue("@lastUpdated", DateTime.Now.ToString());
            login.Parameters.AddWithValue("@lastUpdatedBy", tempAdult.getUserName());
            login.ExecuteNonQuery();

            sc.Close();

            // Pull the accountID from the loginInfo table for reference in the Youth table
            sc.Open();
            SqlCommand pullAccountID = new SqlCommand();
            pullAccountID.Connection = sc;
            pullAccountID.CommandText = "Select accountID from loginInfo WHERE email = @email";
            pullAccountID.Parameters.AddWithValue("@email", email);

            SqlDataReader reader = pullAccountID.ExecuteReader();
            while (reader.Read())
            {
                accountID1 = int.Parse(reader["accountID"].ToString());
            }
            reader.Close();
            sc.Close();


            SqlCommand insert = new SqlCommand();
            sc.Open();
            insert.Connection = sc;

            insert.CommandText = "INSERT INTO [dbo].[Adult] VALUES (@FirstName,@LastName," +
                "NULLIF(@State,' '),@Country,@Gender,@User,@Email,@DateOfBirth,@Username,@Password, @DateCreated, @lastUpdated, @lastUpdatedBy, NULLIF(@favoriteArtist, ' '), NULLIF(@favoriteMusic, ' '), @accountID);";

            insert.Parameters.AddWithValue("@FirstName", tempAdult.getFirstName());
            insert.Parameters.AddWithValue("@LastName", tempAdult.getLastName());
            insert.Parameters.AddWithValue("@User", tempAdult.getAdultType());
            insert.Parameters.AddWithValue("@State", tempAdult.getState());
            insert.Parameters.AddWithValue("@Country", tempAdult.getCountry());
            insert.Parameters.AddWithValue("@DateOfBirth", tempAdult.getDateOfBirth());
            insert.Parameters.AddWithValue("@Email", tempAdult.getEmail());
            insert.Parameters.AddWithValue("@DateCreated", tempAdult.getDateCreated());
            insert.Parameters.AddWithValue("@Gender", tempAdult.getGender());
            insert.Parameters.AddWithValue("@Username", tempAdult.getUserName());
            insert.Parameters.AddWithValue("@Password", PasswordHash.HashPassword(txtPassword.Text));
            insert.Parameters.AddWithValue("@lastUpdated", DateTime.Now.ToString());
            insert.Parameters.AddWithValue("@lastUpdatedBy", tempAdult.getUserName());
            insert.Parameters.AddWithValue("@favoriteArtist", tempAdult.getFavoriteArtist());
            insert.Parameters.AddWithValue("@favoriteMusic", tempAdult.getFavoriteMusic());
            insert.Parameters.AddWithValue("@accountID", accountID1);

            insert.ExecuteNonQuery();

            sc.Close();
            //Session["loggedIn"] = "true";
            Response.Redirect("Login.aspx");
        }
        else
        {
            lblEmailVal.Text = "This email already exists";
        }
    }

}
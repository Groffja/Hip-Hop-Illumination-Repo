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

    }

    protected void DropDowncountry_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (DropDowncountry.Items[0].Selected)
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
        string middlename = HttpUtility.HtmlEncode(txtMiddleName.Text);
        string lastname = HttpUtility.HtmlEncode(txtLastName.Text);
        string street = HttpUtility.HtmlEncode(txtStreet.Text);
        string city = HttpUtility.HtmlEncode(txtCity.Text);
        string zipcode = HttpUtility.HtmlEncode(txtZipCode.Text);
        string country = HttpUtility.HtmlEncode(DropDowncountry.Text);
        string password = HttpUtility.HtmlEncode(txtPassword.Text);
        string username = HttpUtility.HtmlEncode(txtUsername.Text);
        string dateOfBirth = HttpUtility.HtmlEncode(txtDateOfBirth.Text);
        string gender = HttpUtility.HtmlEncode(DropDowngender.Text);
        string email = HttpUtility.HtmlEncode(txtEmail.Text);
        string state = HttpUtility.HtmlEncode(DropDownstate.Text);
        string user = HttpUtility.HtmlEncode(DropDownuser.Text);

        // if Country is not United States
        if (DropDownstate.Enabled == false)
        {
            state = "test ";
        }

        Adult tempAdult = new Adult(firstname, middlename, lastname, street, city, state, zipcode, country, user, email, dateOfBirth, gender, username, password);

        SqlCommand insert = new SqlCommand();
        insert.Connection = sc;
        sc.Open();

        insert.CommandText = "INSERT INTO [dbo].[Adult] VALUES (@FirstName,NULLIF(@MiddleName,' '),@LastName," +
            "@Street,@City,NULLIF(@State,' '),@Zip,@Country,@Gender,@User,@Email,@DateOfBirth,@Username,@Password, @DateCreated, @lastUpdated, @lastUpdatedBy);";

        insert.Parameters.AddWithValue("@FirstName", tempAdult.getFirstName());
        insert.Parameters.AddWithValue("@LastName", tempAdult.getLastName());
        insert.Parameters.AddWithValue("@MiddleName", tempAdult.getMiddleName());
        insert.Parameters.AddWithValue("@Street", tempAdult.getStreet());
        insert.Parameters.AddWithValue("@City", tempAdult.getCity());
        insert.Parameters.AddWithValue("@User", tempAdult.getAdultType());
        insert.Parameters.AddWithValue("@State", tempAdult.getState());
        insert.Parameters.AddWithValue("@Country", tempAdult.getCountry());
        insert.Parameters.AddWithValue("@Zip", tempAdult.getZipCode());
        insert.Parameters.AddWithValue("@DateOfBirth", tempAdult.getDateOfBirth());
        insert.Parameters.AddWithValue("@Email", tempAdult.getEmail());
        insert.Parameters.AddWithValue("@DateCreated", tempAdult.getDateCreated());
        insert.Parameters.AddWithValue("@Gender", tempAdult.getGender());
        insert.Parameters.AddWithValue("@Username", tempAdult.getUserName());
        insert.Parameters.AddWithValue("@Password", PasswordHash.HashPassword(txtPassword.Text));
        insert.Parameters.AddWithValue("@lastUpdated", DateTime.Now.ToString());
        insert.Parameters.AddWithValue("@lastUpdatedBy", tempAdult.getUserName()); 
        
        insert.ExecuteNonQuery();

        sc.Close();
        sc.Open();
        //INSERT INTO LOGININFO
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
        //Session["loggedIn"] = "true";
        Response.Redirect("Login.aspx");
    }
}
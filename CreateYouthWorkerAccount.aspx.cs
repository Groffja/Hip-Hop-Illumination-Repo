using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Cryptography;

public partial class CreateYouthWorkerAccount : System.Web.UI.Page
{
    System.Data.SqlClient.SqlConnection sc = new System.Data.SqlClient.SqlConnection();

    protected void Page_Load(object sender, EventArgs e)
    {
        
        sc.ConnectionString = @"server=hhidatabase.chi0h0eoorog.us-east-1.rds.amazonaws.com;database=hhidatabase;uid=hhi;password=hhidatabase;";

    }
    

    protected void CreateAccount_Click(object sender, EventArgs e)
    {

        String firstName = HttpUtility.HtmlEncode(firstNameTextBox.Text);
        String middleName = HttpUtility.HtmlEncode(middleNameTextBox.Text);
        String lastName = HttpUtility.HtmlEncode(lastNameTextBox.Text);
        String email = HttpUtility.HtmlEncode(emailTextBox.Text);
        String dob = HttpUtility.HtmlEncode(dobTextBox.Text);
        String gender = HttpUtility.HtmlEncode(genderDropDownList.SelectedValue);
        String street = HttpUtility.HtmlEncode(streetTextBox.Text);
        String city = HttpUtility.HtmlEncode(cityTextBox.Text);
        String state = HttpUtility.HtmlEncode(stateDropDownList.SelectedValue);
        //String state = HttpUtility.HtmlEncode(stateTextBox.Text);
        String zipCode = HttpUtility.HtmlEncode(zipCodeTextBox.Text);
        String country = HttpUtility.HtmlEncode(countryDropDownList.SelectedValue);
        //String country = HttpUtility.HtmlEncode(countryTextBox.Text);
        String userName = HttpUtility.HtmlEncode(userNameTextBox.Text);
        String password = HttpUtility.HtmlEncode(passwordTextBox.Text);
        //String school = HttpUtility.HtmlEncode(SchoolTextBox.Text);
        int schoolID = 1;



        YouthWorker tempWorker = new YouthWorker(firstName, middleName, lastName, street, city, state, zipCode, country, email, dob, userName, password, gender);

        //Open Connection
        sc.Open();

        ////Create  SQL insert command to insert data into student database 
        System.Data.SqlClient.SqlCommand insert = new System.Data.SqlClient.SqlCommand();
        insert.Connection = sc;
        insert.CommandText = "insert into [dbo].[YouthWorker] values (@youthWorkerFirstName,NULLIF(@youthWorkerMiddleName, ' '), @youthWorkerLastName, @youthWorkerStreet, @youthWorkerCity, @youthWorkerState," +
            "@youthWorkerZipCode, @youthWorkerCountry, @youthWorkerEmail, @youthWorkergender, NULLIF(@youthWorkerSchool, ' '), @youthWorkerDateOfBirth, @youthWorkerUserName, @youthWorkerpassword, @CreatedDate, @lastUpdated, @lastUpdatedBy)";


        insert.Parameters.AddWithValue("@youthWorkerFirstName", tempWorker.getFirstName());
        insert.Parameters.AddWithValue("@youthWorkerMiddleName", tempWorker.getMiddleName());
        insert.Parameters.AddWithValue("@youthWorkerLastName", tempWorker.getLastName());
        insert.Parameters.AddWithValue("@youthWorkerStreet", tempWorker.getStreet());
        insert.Parameters.AddWithValue("@youthWorkerCity", tempWorker.getCity());
        insert.Parameters.AddWithValue("@youthWorkerState", tempWorker.getState());
        insert.Parameters.AddWithValue("@youthWorkerZipCode", tempWorker.getZipCode());
        insert.Parameters.AddWithValue("@youthWorkerCountry", tempWorker.getCountry());
        insert.Parameters.AddWithValue("@youthWorkerEmail", tempWorker.getEmail());
        insert.Parameters.AddWithValue("@youthWorkergender", tempWorker.getGender());
        insert.Parameters.AddWithValue("@youthWorkerSchool", schoolID);
        insert.Parameters.AddWithValue("@youthWorkerDateOfBirth", tempWorker.getDateOfBirth());
        insert.Parameters.AddWithValue("@youthWorkerUserName", tempWorker.getUsername());
        insert.Parameters.AddWithValue("@youthWorkerpassword", PasswordHash.HashPassword(passwordTextBox.Text));
        insert.Parameters.AddWithValue("@CreatedDate", tempWorker.getDateCreated());
        insert.Parameters.AddWithValue("@lastUpdated", DateTime.Now.ToString());
        insert.Parameters.AddWithValue("@lastUpdatedBy", tempWorker.getUsername());


        insert.ExecuteNonQuery();


        insert.Parameters.Clear();

        firstNameTextBox.Text = "";
        middleNameTextBox.Text = "";
        lastNameTextBox.Text = "";
        emailTextBox.Text = "";
        dobTextBox.Text = "";
        streetTextBox.Text = "";
        cityTextBox.Text = "";
        //stateTextBox.Text = "";
        zipCodeTextBox.Text = "";
        //countryTextBox.Text = "";
        userNameTextBox.Text = "";
        passwordTextBox.Text = "";
        SchoolTextBox.Text = "";
        streetTextBox.Text = "";

        sc.Close();
        sc.Open();

        //INSERT INTO LOGININFO
        System.Data.SqlClient.SqlCommand login = new System.Data.SqlClient.SqlCommand();
        login.Connection = sc;
        login.CommandText = "INSERT INTO [dbo].[LoginInfo] VALUES (@accountType, @username, @Xpassword, @email, @lastUpdated, @lastUpdatedBy);";
        login.Parameters.AddWithValue("@accountType", "YouthWorker");
        login.Parameters.AddWithValue("@username", tempWorker.getUsername());
        login.Parameters.AddWithValue("@Xpassword", PasswordHash.HashPassword(passwordTextBox.Text));
        login.Parameters.AddWithValue("@email", tempWorker.getEmail());
        login.Parameters.AddWithValue("@lastUpdated", DateTime.Now.ToString());
        login.Parameters.AddWithValue("@lastUpdatedBy", tempWorker.getUsername());
        login.ExecuteNonQuery();
        sc.Close();

        Session["loggedIn"] = "true";
        Response.Redirect("ProfilePage.aspx");
    }
}
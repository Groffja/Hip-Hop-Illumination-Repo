using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Cryptography;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        txtUsername.Focus();
    }
    String userType;
    public static string username = "";
    protected void btnLogin_Click(object sender, EventArgs e)

    {
        
        string password = HttpUtility.HtmlEncode(txtPassword.Text);

        System.Data.SqlClient.SqlConnection sc = new System.Data.SqlClient.SqlConnection();
        sc.ConnectionString = @"Server=LOCALHOST;Database=hhidatabase;Trusted_Connection=Yes;";
        sc.Open();
        System.Data.SqlClient.SqlCommand findPass = new System.Data.SqlClient.SqlCommand();
        findPass.Connection = sc;


        findPass.CommandText = "select accountID, username, accountType, Xpassword from LoginInfo where email = @email";

        findPass.Parameters.Add(new SqlParameter("@email", HttpUtility.HtmlEncode(txtUsername.Text)));



        SqlDataReader reader = findPass.ExecuteReader(); // create a reader



        if (reader.HasRows) // if the username exists, it will continue
        {
            while (reader.Read()) // this will read the single record that matches the entered username
            {
                //string storedHash = "";

                string accountReaderID = reader["accountID"].ToString();
                int accountID = int.Parse(accountReaderID);
                string user = reader["username"].ToString();
                string type = reader["accountType"].ToString();
                string accountType = type;
                string storedHash = reader["Xpassword"].ToString(); // store the database password into this variable
                lblStatus.Text = storedHash;



                if (PasswordHash.ValidatePassword(password, storedHash)) // if the entered password matches what is stored, it will show success
                {
                    lblStatus.Text = "Success!";
                    btnLogin.Enabled = false;
                    txtUsername.Enabled = false;
                    txtPassword.Enabled = false;
                    Session["loggedIn"] = "true";    //Profile-tab visible on homepage
                    Session["username"] = user;
                    Session.Add("email", txtUsername.Text);
                    Session.Add("accountType", type);
                    Session.Add("username", username);
                    Session["accountID"] = accountReaderID;
                    if (type == "Admin")
                    {
                        Response.Redirect("AdminHomepage.aspx");
                    }
                    else { Response.Redirect("ProfilePage.aspx"); }

                }
                else
                    lblStatus.Text = "Password is wrong.";
            }

        }
        else // if the username doesn't exist, it will show failure
            lblStatus.Text = "Invalid Username/Password. Please Try Again.";

        sc.Close();

    }


    protected void lnkCreate_Click(object sender, EventArgs e)
    {
        Response.Redirect("createUser.aspx", false);
    }

}
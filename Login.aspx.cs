
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
        // connect to database to retrieve stored password string
        //try
        //{

            System.Data.SqlClient.SqlConnection sc = new System.Data.SqlClient.SqlConnection();
            sc.ConnectionString = @"Server=LOCALHOST;Database=hhidatabase;Trusted_Connection=Yes;";
            sc.Open();
            System.Data.SqlClient.SqlCommand findPass = new System.Data.SqlClient.SqlCommand();
            findPass.Connection = sc;


        // SELECT PASSWORD STRING WHERE THE ENTERED USERNAME MATCHES

        //findPass.CommandText = "(SELECT Xpassword from Adult where email ='" + txtUsername.Text + "') UNION (SELECT Xpassword from Youth where youthEmail ='" + txtUsername.Text + "') UNION (SELECT Xpassword from YouthWorker where youthWorkerEmail ='" + txtUsername.Text + "') UNION(SELECT Xpassword from Admin where username = '" + txtUsername.Text + "')";


        //userType = type.SelectedItem.Value;
        //    if (userType.Equals("Adult"))
        //    {
        //    //findPass.CommandText = "select Xpassword from Adult where username = @Username";
        //    findPass.CommandText = "select Xpassword from Adult where email = @email";
        //    findPass.Parameters.Add(new SqlParameter("@email", txtUsername.Text));
        //    //findPass.Parameters.Add(new SqlParameter("@Username", txtUsername.Text));

        //}
        //    else if (userType.Equals("Youth"))
        //    {
        //        //findPass.CommandText = "select Xpassword from Youth where username = @Username";
        //        //findPass.Parameters.Add(new SqlParameter("@Username", txtUsername.Text));
        //        findPass.CommandText = "select Xpassword from Youth where email = @email";
        //        findPass.Parameters.Add(new SqlParameter("@email", txtUsername.Text));
        //}
        //    else if (userType.Equals("YouthWorker"))
        //    {
        //        findPass.CommandText = "select Xpassword from YouthWorker where email = @email";
        //        findPass.Parameters.Add(new SqlParameter("@email", txtUsername.Text));
        //    }
        //    else if (userType.Equals("Admin"))
        //    {
        //        findPass.CommandText = "select Xpassword from Admin where username = @email";
        //        findPass.Parameters.Add(new SqlParameter("@email", txtUsername.Text));
        //    }

        findPass.CommandText = "select username, accountType, Xpassword from LoginInfo where email = @email";
        findPass.Parameters.Add(new SqlParameter("@email", txtUsername.Text));



        SqlDataReader reader = findPass.ExecuteReader(); // create a reader



            if (reader.HasRows) // if the username exists, it will continue
            {
                while (reader.Read()) // this will read the single record that matches the entered username
                {
                //string storedHash = "";

                    string user = reader["username"].ToString();
                    string type = reader["accountType"].ToString();
                    string accountType = type;
                    string storedHash = reader["Xpassword"].ToString(); // store the database password into this variable
                    lblStatus.Text = storedHash;


                    if (PasswordHash.ValidatePassword(txtPassword.Text, storedHash)) // if the entered password matches what is stored, it will show success
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
        //catch
        //{
        //    lblStatus.Text = "Database Error.";
        //}
    

    protected void lnkCreate_Click(object sender, EventArgs e)
    {
        Response.Redirect("createUser.aspx", false);
    }



    //SAVED DROPDOWN
    //<asp:DropDownList class="type" id="type" runat="server">
    //          <asp:ListItem Disabled Text="UserType"></asp:ListItem>
    //          <asp:ListItem Value = "Youth" > Youth </ asp:ListItem>
    //          <asp:ListItem Value = "YouthWorker" > Youth Worker</asp:ListItem>
    //          <asp:ListItem Value = "Adult" > Adult </ asp:ListItem>
    //          <asp:ListItem Value = "Admin" > Admin </ asp:ListItem>
    //      </asp:DropDownList>
}
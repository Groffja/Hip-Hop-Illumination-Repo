using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RecommendationPage : System.Web.UI.Page
{
    string email;
    int documentID;

    System.Data.SqlClient.SqlConnection sc = new System.Data.SqlClient.SqlConnection();

    protected void Page_Load(object sender, EventArgs e)
    {
        // Check session is expire or timeout. 
        if (Session["adminLoggedIn"] == null)
        {
            Response.Redirect("Login.aspx?info=0");
        }

        try
        {

            sc.ConnectionString = @"server=hhidatabase.chi0h0eoorog.us-east-1.rds.amazonaws.com;database=hhidatabase;uid=hhi;password=hhidatabase;";
            sc.Open();
            System.Data.SqlClient.SqlCommand insert = new System.Data.SqlClient.SqlCommand();
            insert.Connection = sc;
            sc.Close();

        }
        catch (Exception)
        {
        }

        
        System.Data.SqlClient.SqlCommand getID = new System.Data.SqlClient.SqlCommand();
        getID.Connection = sc;
        sc.Open();
        getID.CommandText = "SELECT accountID from [dbo].[LoginInfo] where accountID = '" + Session["accountID"] + "'";
        int accountID = Convert.ToInt32(getID.ExecuteScalar());// get receiver ID
        sc.Close();
        TextBox1.Text = accountID.ToString();


        if (!IsPostBack) //Checking if first page load
        {
            try
            {
                sc.ConnectionString = @"server=hhidatabase.chi0h0eoorog.us-east-1.rds.amazonaws.com;database=hhidatabase;uid=hhi;password=hhidatabase;";

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

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            try
            {
                sc.Close();
                sc.Open();
                System.Data.SqlClient.SqlCommand insert = new System.Data.SqlClient.SqlCommand();
                insert.Connection = sc;

                email = txtEmail.Text;
                documentID = Convert.ToInt32(ddlRecommendation.SelectedItem.Value);// get document ID

                insert.CommandText = "SELECT accountID from LoginInfo where email = '" + email + "'";
                int receiverAccountID = Convert.ToInt32(insert.ExecuteScalar());// get receiver ID

                insert.CommandText = "SELECT username, accountID from LoginInfo where email = '" + email + "'";
                insert.ExecuteNonQuery();

                SqlDataReader reader = insert.ExecuteReader();
                while (reader.Read())
                {
                    string user = reader["username"].ToString();
                    Session["user"] = user;
                    string ID = reader["accountID"].ToString();
                    Session["accountID"] = ID;
                }
                reader.Close();

                System.Data.SqlClient.SqlCommand test = new System.Data.SqlClient.SqlCommand();
                test.Connection = sc;
                test.CommandText = "INSERT INTO [Recommendations] VALUES('" + documentID + "','"
                    + receiverAccountID + "','"
                    + Session["user"] + "','"
                    + DateTime.Now.ToString() + "','"
                    + DateTime.Now.ToString() + "','"
                    + Convert.ToString(Session["user"]) + "')";
                test.ExecuteNonQuery();

                txtEmail.Text = " ";

                insert.CommandText = "SELECT accountID from [dbo].[LoginInfo] where accountID = '" + Session["accountID"] + "'";
                int accountID = Convert.ToInt32(insert.ExecuteScalar());// get receiver ID
                TextBox1.Text = accountID.ToString();

                
                //TextBox1.Text = Session["accountID"].ToString();
                //int accountID = Convert.ToInt32(TextBox1.Text);
            }
            catch
            {

            }


        }

    }
}
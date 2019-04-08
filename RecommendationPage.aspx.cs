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

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            sc.Close();
            sc.Open();
            System.Data.SqlClient.SqlCommand insert = new System.Data.SqlClient.SqlCommand();
            insert.Connection = sc;

            email = txtEmail.Text;
            documentID = Convert.ToInt32(ddlRecommendation.SelectedItem.Value);// get document ID

            insert.CommandText = "SELECT accountID from LoginInfo where email = '" + email + "'";
            int receiverAccountID = Convert.ToInt32(insert.ExecuteScalar());// get receiver ID

            insert.CommandText = "SELECT username,accountID from LoginInfo where email = '" + email + "'";
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
                + Convert.ToString(Session["username"]) + "','"
                + DateTime.Now.ToString() + "','"
                + DateTime.Now.ToString() + "','"
                + Convert.ToString(Session["username"]) + "')";
            test.ExecuteNonQuery();

            txtEmail.Text = " ";


        }

    }
}
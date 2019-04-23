using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class RecommendationForYandYW : System.Web.UI.Page
{
    System.Data.SqlClient.SqlConnection sc = new System.Data.SqlClient.SqlConnection();
    
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {

            sc.ConnectionString = @"Server =localhost;Database=hhidatabase;Trusted_Connection=Yes;";
            //sc.ConnectionString = @"server=hhidatabase.chi0h0eoorog.us-east-1.rds.amazonaws.com;database=hhidatabase;uid=hhi;password=hhidatabase;";  AWS Link
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
                sc.ConnectionString = @"Server =localhost;Database=hhidatabase;Trusted_Connection=Yes;";
                //sc.ConnectionString = @"server=hhidatabase.chi0h0eoorog.us-east-1.rds.amazonaws.com;database=hhidatabase;uid=hhi;password=hhidatabase;";  AWS Link

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
    protected void btnSeeData_Click(object sender, EventArgs e)
    {               
        sc.Close();
        sc.Open();
        System.Data.SqlClient.SqlCommand insert = new System.Data.SqlClient.SqlCommand();
        insert.Connection = sc;


        insert.CommandText = "SELECT accountID from [dbo].[LoginInfo] where email = '" + Session["email"] + "'";
        int receiverAccountID = Convert.ToInt32(insert.ExecuteScalar());// get receiver ID
        test.Text = receiverAccountID.ToString();

        SqlCommand cmd = new SqlCommand();
        cmd.Connection = sc;
        cmd.CommandText = "SELECT accountID FROM Recommendations WHERE accountID = @accountID";
        cmd.Parameters.AddWithValue("@accountID", Session["accountID"]);

        SqlDataReader reader1 = cmd.ExecuteReader();

        if (!reader1.HasRows)
        {
            noLessons.Visible = true;
        }

    }
}
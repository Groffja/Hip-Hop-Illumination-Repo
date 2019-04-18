using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections.Specialized;
using System.Data.SqlClient;


public partial class ContactUs : System.Web.UI.Page
{
    string conStr = @"server=hhidatabase.chi0h0eoorog.us-east-1.rds.amazonaws.com;database=hhidatabase;uid=hhi;password=hhidatabase;";

    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void MessageButton_Click(object sender, EventArgs e)
    {



        //stored in the feedback table
        //    stringName = name.ToString();
        //   stringEmail = email.ToString();

        string message = messageTextArea.Value.ToString();


        
       

        try
        {
            SqlConnection cn = new SqlConnection(conStr);
            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "INSERT INTO [dbo].[Feedback] VALUES (@accountID, @message);";
            cmd.Parameters.AddWithValue("@message", message);
            cmd.Parameters.AddWithValue("@accountID", Session["accountID"]);

            cmd.ExecuteNonQuery();
        
            cmd.Parameters.Clear();
            cn.Close();
            dvMsg.Visible = true;
            lblMsg.Text = "Message has been sent. Thank You.";
            messageTextArea.Value = "";
            name.Value = "";
            email.Value = "";
            phone.Value = "";

        }
        catch
        {
            dvMsg.Visible = true;
            lblMsg.Text = "Something went wrong";
        }

     
        


        




    }
    protected void btnShowMsg_Click(object sender, EventArgs e)
    {
        dvMsg.Visible = true;
        lblMsg.Text = "This is notification message demo";
    }



}
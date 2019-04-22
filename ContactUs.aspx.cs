
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
    string conStr = @"Server =localhost;Database=hhidatabase;Trusted_Connection=Yes;";

    protected void Page_Load(object sender, EventArgs e)
    {
        // Check session is expire or timeout. 
        if (Session["email"] == null)
        {
            Response.Redirect("Login.aspx?info=0");
        }
    }

    protected void MessageButton_Click(object sender, EventArgs e)
    {



        string topic = phone.Value.ToString();
        string message = topic + " - " + messageTextArea.Value.ToString();
        string newMessage = HttpUtility.HtmlEncode(message);

        try
        {
            SqlConnection cn = new SqlConnection(conStr);
            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;


            cmd.CommandText = "INSERT INTO [dbo].[Feedback] VALUES (@accountID, @message, @lastUpdated, @lastUpdatedBy);";

            cmd.Parameters.AddWithValue("@accountID", Session["accountID"]);
            cmd.Parameters.AddWithValue("@message", newMessage);
            cmd.Parameters.AddWithValue("@lastUpdated", DateTime.Now.ToString());
            cmd.Parameters.AddWithValue("@lastUpdatedBy", Session["username"]);


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
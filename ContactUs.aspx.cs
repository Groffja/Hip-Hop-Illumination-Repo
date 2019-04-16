using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections.Specialized;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    string conStr = @"server=hhidatabase.chi0h0eoorog.us-east-1.rds.amazonaws.com;database=hhidatabase;uid=hhi;password=hhidatabase;";

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void MessageButton_Click(object sender, EventArgs e)
    {
        String accountID = "";
        String message = "";

        //stored in the feedback table
        //    stringName = name.ToString();
        //   stringEmail = email.ToString();

        message = messageTextArea.Value.ToString();
        accountID = Session["accountID"].ToString();
       

        try
        {
            SqlConnection cn = new SqlConnection(conStr);
            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "INSERT INTO [dbo].[Feedback] VALUES (" + @accountID + ",'" + @message + "');";
            cmd.Parameters.AddWithValue(@message, message);
            cmd.Parameters.AddWithValue(@accountID, accountID);
            
            cmd.ExecuteNonQuery();
        
            cmd.Parameters.Clear();
            cn.Close();

            
        }
        catch
        {

        }

     
        messageTextArea.Value = "";
        name.Value = "";
        email.Value = "";
        phone.Value = "";


        




    }


}
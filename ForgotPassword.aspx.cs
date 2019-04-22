using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Cryptography;
using System.Net.Mail;
using System.Text;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        txtUsername.Focus();
    }
    
    protected void btnReset_Click(object sender, EventArgs e)

    {

        System.Data.SqlClient.SqlConnection sc = new System.Data.SqlClient.SqlConnection();
        sc.ConnectionString = @"Server =localhost;Database=hhidatabase;Trusted_Connection=Yes;";
        sc.Open();

        ////MailAddress hostEmail = (MailAddress)'qschaefer4@gmail.com';
        //////MailMessage mail = new MailMessage("qschaefer4@gmail.com", txtUsername.Text);
        //////SmtpClient client = new SmtpClient();
        //////client.Port = 1433;
        //////client.DeliveryMethod = SmtpDeliveryMethod.Network;
        //////client.Timeout = 20000;
        //////client.UseDefaultCredentials = false;
        //////client.Host = "smtp.gmail.com";
        //////mail.Subject = "Hip Hop Illumination Password Reset";
        //////mail.Body = "this is my test email body";
        //////mail.BodyEncoding = UTF8Encoding.UTF8;
        //////client.Send(mail);
        //////lblStatus.Text = "Success!";

        // Command line argument must the the SMTP host.


        //SmtpClient client = new SmtpClient();
        //client.Port = 1433;
        //client.Host = "smtp.gmail.com";
        //client.EnableSsl = true;
        //client.Timeout = 10000;
        //client.DeliveryMethod = SmtpDeliveryMethod.Network;
        //client.UseDefaultCredentials = false;
        //client.Credentials = new System.Net.NetworkCredential("ammonmd@dukes.jmu.edu", "");

        //MailMessage mm = new MailMessage("donotreply@domain.com", "qschaefer4@gmail.com", "test", "test");
        //mm.BodyEncoding = UTF8Encoding.UTF8;
        //mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

        //client.Send(mm);

        MailMessage message = new MailMessage();
        SmtpClient SmtpServer = new SmtpClient("smtp-mail.outlook.com");
        message.From = new MailAddress("");  //from
        message.To.Add(txtUsername.Text);  //to
        message.Subject = "subject"; //subject
        message.Body = "redirect to reset password webpage";  //body
        SmtpServer.Port = 1433;
        SmtpServer.Credentials = new System.Net.NetworkCredential(txtUsername.Text, txtPassword.Text);
        SmtpServer.EnableSsl = true;
        SmtpServer.Send(message);

        //MailMessage message = new MailMessage();
        //SmtpClient SmtpServer = new SmtpClient(txt_smtpserver.Text);
        //message.From = new MailAddress(txt_from.Text);
        //message.To.Add(txt_to.Text);
        //message.Subject = txt_subject.Text;
        //message.Body = richTextBox1.Text;
        //SmtpServer.Port = 587;
        //SmtpServer.Credentials = new System.Net.NetworkCredential(txt_from.Text, txt_password.Text);
        //SmtpServer.EnableSsl = true;
        //SmtpServer.Send(message);






        //System.Data.SqlClient.SqlCommand findPass = new System.Data.SqlClient.SqlCommand();
        //findPass.Connection = sc;


        //findPass.CommandText = "select accountID, username, accountType, Xpassword from LoginInfo where email = @email";

        //findPass.Parameters.Add(new SqlParameter("@email", txtUsername.Text));



        //SqlDataReader reader = findPass.ExecuteReader(); // create a reader



        //if (reader.HasRows) // if the username exists, it will continue
        //{
        //    while (reader.Read()) // this will read the single record that matches the entered username
        //    {
        //        //string storedHash = "";

        //        string accountReaderID = reader["accountID"].ToString();
        //        int accountID = int.Parse(accountReaderID);
        //        string user = reader["username"].ToString();
        //        string type = reader["accountType"].ToString();
        //        string accountType = type;
        //        string storedHash = reader["Xpassword"].ToString(); // store the database password into this variable
        //        lblStatus.Text = storedHash;



        //        if (PasswordHash.ValidatePassword(txtPassword.Text, storedHash)) // if the entered password matches what is stored, it will show success
        //        {
        //            lblStatus.Text = "Success!";
        //            btnLogin.Enabled = false;
        //            txtUsername.Enabled = false;
        //            txtPassword.Enabled = false;
        //            Session["loggedIn"] = "true";    //Profile-tab visible on homepage
        //            Session["username"] = user;
        //            Session.Add("email", txtUsername.Text);
        //            Session.Add("accountType", type);
        //            //Session.Add("username", username);
        //            Session["accountID"] = accountReaderID;
        //            if (type == "Admin")
        //            {
        //                Response.Redirect("AdminHomepage.aspx");
        //            }
        //            else { Response.Redirect("ProfilePage.aspx"); }

        //        }
        //        else
        //            lblStatus.Text = "Password is wrong.";
        //    }

        //}
        //else // if the username doesn't exist, it will show failure
        //    lblStatus.Text = "Invalid Username/Password. Please Try Again.";

        //sc.Close();

    }


    

}
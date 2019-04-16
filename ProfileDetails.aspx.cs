using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Activities.Validation;

public partial class ProfileDetails : System.Web.UI.Page
{
    System.Data.SqlClient.SqlConnection sc = new System.Data.SqlClient.SqlConnection();
    string exception = string.Empty;
    string firstName;
    string middleName;
    string lastName;
    string street;
    string city;
    string state;
    string zip;
    string country;
    string gender;
    string email;
    string dateOfBirth;
    string username;
    string favoriteArtist;
    string favoriteMusic;

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            sc.ConnectionString = @"server=hhidatabase.chi0h0eoorog.us-east-1.rds.amazonaws.com;database=hhidatabase;uid=hhi;password=hhidatabase;";

        }

        catch (Exception ex)
        {
            exception = ex.GetType().ToString();

        }
        // ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

        sc.Open();
        System.Data.SqlClient.SqlCommand getFields = new System.Data.SqlClient.SqlCommand();
        getFields.Connection = sc;




        if (!IsPostBack)
        {
            if ((string)Session["Accounttype"] == "Adult")
            {
                getFields.CommandText = "select firstName, lastName, state, country, gender, username, favoriteArtist, favoriteMusic from Adult where email=@email";
                getFields.Parameters.Add(new SqlParameter("@email", (string)Session["email"]));
                SqlDataReader reader = getFields.ExecuteReader();
                while (reader.Read())
                {
                    firstName = reader["firstName"].ToString();
                    lastName = reader["lastName"].ToString();
                    state = reader["state"].ToString();
                    country = reader["country"].ToString();
                    gender = reader["gender"].ToString();
                    
                    username = reader["username"].ToString();
                    favoriteArtist = reader["favoriteArtist"].ToString();
                    favoriteMusic = reader["favoriteMusic"].ToString();




                    txtFavoriteArtist.Text = favoriteArtist;
                    txtFavoriteMusic.Text = favoriteMusic;

                    txtUsername.Text = username;
                    txtFirstName.Text = firstName;
                    
                    txtLastName.Text = lastName;
                    
                    DropDownstate.Text = state;
                    
                    DropDowncountry.Text = country;
                    DropDowngender.Text = gender;
                    
                   
                    
                }
                reader.Close();

            }
            else if ((string)Session["Accounttype"] == "Youth")
            {
                getFields.CommandText = "select firstName, lastName, state, country, gender, email, dateOfBirth, username, favoriteArtist, favoriteMusic from Youth where email=@email";
                getFields.Parameters.Add(new SqlParameter("@email", (string)Session["email"]));
                SqlDataReader reader = getFields.ExecuteReader();
                while (reader.Read())
                {
                    firstName = reader["firstName"].ToString();
                    lastName = reader["lastName"].ToString();
                    state = reader["state"].ToString();
                    country = reader["country"].ToString();
                    gender = reader["gender"].ToString();
                
                    
                    username = reader["username"].ToString();
                    favoriteArtist = reader["favoriteArtist"].ToString();
                    favoriteMusic = reader["favoriteMusic"].ToString();




                    txtFavoriteArtist.Text = favoriteArtist;
                    txtFavoriteMusic.Text = favoriteMusic;

                    txtUsername.Text = username;
                    txtFirstName.Text = firstName;
                  
                    txtLastName.Text = lastName;
                  
                
                    DropDownstate.Text = state;
                    
                    DropDowncountry.Text = country;
                    DropDowngender.Text = gender;
                    
                }
                reader.Close();
            }
            else
            {
                
            }
        }
        sc.Close();
    }



    protected void Edit_Click(object sender, EventArgs e)
    {
        Edit.Visible = false;
        Confirm.Visible = true;
        txtUsername.Enabled = true;
        txtFirstName.Enabled = true;
        
     
        DropDownstate.Enabled = true;
      
        DropDowncountry.Enabled = true;
        DropDowngender.Enabled = true;
        
    }

    protected void Confirm_Click(object sender, EventArgs e)
    {

        sc.Open();

        Confirm.Visible = false;
        Edit.Visible = true;
        
        string username = HttpUtility.HtmlEncode(txtUsername.Text);
        string firstName = HttpUtility.HtmlEncode(txtFirstName.Text);
        string lastName = HttpUtility.HtmlEncode(txtLastName.Text);
        string state = HttpUtility.HtmlEncode(DropDownstate.Text);
        
        country = DropDowncountry.Text;
        gender = DropDowngender.Text;
        
        string favoriteMusic = HttpUtility.HtmlEncode(txtFavoriteMusic.Text);
        string favoriteArtist = HttpUtility.HtmlEncode(txtFavoriteArtist.Text);
       
       
        string lastUpdated = DateTime.Now.ToString();
        string lastUpdatedBy = ((string)Session["username"]);


        System.Data.SqlClient.SqlCommand updateRecord = new System.Data.SqlClient.SqlCommand();
        updateRecord.Connection = sc;


        if ((string)Session["Accounttype"] == "Adult")
        {
            updateRecord.CommandText = "Update Adult SET firstName = @firstName, lastName = @lastName, state = @state, country = @country, gender = @gender, username = @username, favoriteArtist = @favoriteArtist, favoriteMusic = @favoriteMusic, lastUpdated = @lastUpdated, lastUpdatedBy = @lastUpdatedBy WHERE email=@emailSession";
            updateRecord.Parameters.Add(new SqlParameter("@emailSession", (string)Session["email"]));
            updateRecord.Parameters.Add(new SqlParameter("@firstName", firstName));
            updateRecord.Parameters.Add(new SqlParameter("@lastName", lastName));
            updateRecord.Parameters.Add(new SqlParameter("@state", state));
            updateRecord.Parameters.Add(new SqlParameter("@country", country));
            updateRecord.Parameters.Add(new SqlParameter("@gender", gender));
            
            updateRecord.Parameters.Add(new SqlParameter("@username", username));
            updateRecord.Parameters.Add(new SqlParameter("@favoriteArtist", favoriteArtist));
            updateRecord.Parameters.Add(new SqlParameter("@favoriteMusic", favoriteMusic));
            updateRecord.Parameters.Add(new SqlParameter("@lastUpdated", lastUpdated));
            updateRecord.Parameters.Add(new SqlParameter("@lastUpdatedBy", lastUpdatedBy));



            updateRecord.ExecuteNonQuery();
        }

        else if ((string)Session["Accounttype"] == "Youth")
        {
            updateRecord.CommandText = "Update Youth SET firstName = @firstName, lastName = @lastName, state = @state, country = @country, gender = @gender, username = @username, favoriteArtist = @favoriteArtist, favoriteMusic = @favoriteMusic, lastUpdated = @lastUpdated, lastUpdatedBy = @lastUpdatedBy WHERE email=@emailSession";
            updateRecord.Parameters.Add(new SqlParameter("@emailSession", (string)Session["email"]));
            updateRecord.Parameters.Add(new SqlParameter("@firstName", firstName));
            
            updateRecord.Parameters.Add(new SqlParameter("@lastName", lastName));
            
            updateRecord.Parameters.Add(new SqlParameter("@state", state));
            
            updateRecord.Parameters.Add(new SqlParameter("@country", country));
            updateRecord.Parameters.Add(new SqlParameter("@gender", gender));
          
            updateRecord.Parameters.Add(new SqlParameter("@username", username));
            updateRecord.Parameters.Add(new SqlParameter("@favoriteArtist", favoriteArtist));
            updateRecord.Parameters.Add(new SqlParameter("@favoriteMusic", favoriteMusic));
            updateRecord.Parameters.Add(new SqlParameter("@lastUpdated", lastUpdated));
            updateRecord.Parameters.Add(new SqlParameter("@lastUpdatedBy", lastUpdatedBy));

            updateRecord.ExecuteNonQuery();
        }



        sc.Close();

        txtUsername.Enabled = false;
        txtFirstName.Enabled = false;
        
        txtLastName.Enabled = false;
        
        DropDownstate.Enabled = false;
        
        DropDowncountry.Enabled = false;
        DropDowngender.Enabled = false;
       
        txtFavoriteArtist.Enabled = false;
        txtFavoriteMusic.Enabled = false;

    }

    protected void txtFirstName_TextChanged(object sender, EventArgs e)
    {

    }
}
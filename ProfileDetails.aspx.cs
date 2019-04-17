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
        // Check session is expire or timeout. 
        if (Session["email"] == null)
        {
            Response.Redirect("Login.aspx?info=0");
        }

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
                    //email = reader["email"].ToString();
                    //dateOfBirth = reader["dateOfBirth"].ToString();
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
                //getFields.CommandText = "select youthWorkerFirstName, youthWorkerMiddleName, youthWorkerLastName, youthWorkerStreet, youthWorkerCity, youthWorkerState, youthWorkerZip, youthWorkerCountry, youthWorkerGender, email, youthWorkerDateOfBirth, username from YouthWorker where email=@email";
                //getFields.Parameters.Add(new SqlParameter("@email", (string)Session["email"]));
                //SqlDataReader reader = getFields.ExecuteReader();
                //while (reader.Read())
                //{
                //    firstName = reader["youthWorkerFirstName"].ToString();
                //    middleName = reader["youthWorkerMiddleName"].ToString();
                //    lastName = reader["youthWorkerLastName"].ToString();
                //    street = reader["youthWorkerStreet"].ToString();
                //    city = reader["youthWorkerCity"].ToString();
                //    state = reader["youthWorkerState"].ToString();
                //    zip = reader["youthWorkerZip"].ToString();
                //    country = reader["youthWorkerCountry"].ToString();
                //    gender = reader["youthWorkerGender"].ToString();
                //    email = reader["email"].ToString();
                //    dateOfBirth = reader["youthWorkerDateOfBirth"].ToString();
                //    username = reader["username"].ToString();

                //    txtUsername.Text = username;
                //    txtFirstName.Text = firstName;
                //    txtMiddleName.Text = middleName;
                //    txtLastName.Text = lastName;
                //    txtStreet.Text = street;
                //    txtCity.Text = city;
                //    DropDownstate.Text = state;
                //    txtZip.Text = zip;
                //    DropDowncountry.Text = country;
                //    DropDowngender.Text = gender;
                //    txtEmail.Text = email;
                //    DateTime oDate = DateTime.Parse(dateOfBirth);
                //    txtDateOfBirth.Text = oDate.ToString("MM/dd/yyyy");
                //}
                //reader.Close();
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

        username = txtUsername.Text;
        firstName = txtFirstName.Text;
   
        lastName = txtLastName.Text;
        
      
        state = DropDownstate.Text;
        
        country = DropDowncountry.Text;
        gender = DropDowngender.Text;
        
        favoriteMusic = txtFavoriteMusic.Text;
        favoriteArtist = txtFavoriteArtist.Text;
       
       
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

        //else if ((string)Session["Accounttype"] == "YouthWorker")
        //{
        //    updateRecord.CommandText = "Update YouthWorker SET youthWorkerFirstName = @firstName, youthWorkerMiddleName = @middleName, youthWorkerLastName = @lastName, youthWorkerStreet = @street, youthWorkerCity = @city, youthWorkerState = @state, youthWorkerZip = @zip, youthWorkerCountry = @country, youthWorkerGender = @gender, email = @email, youthWorkerDateOfBirth = @dateOfBirth, username = @username, lastUpdated = @lastUpdated, lastUpdatedBy = @lastUpdatedBy WHERE email=@emailSession";
        //    updateRecord.Parameters.Add(new SqlParameter("@emailSession", (string)Session["email"]));
        //    updateRecord.Parameters.Add(new SqlParameter("@firstName", firstName));
        //    updateRecord.Parameters.Add(new SqlParameter("@middleName", middleName));
        //    updateRecord.Parameters.Add(new SqlParameter("@lastName", lastName));
        //    updateRecord.Parameters.Add(new SqlParameter("@street", street));
        //    updateRecord.Parameters.Add(new SqlParameter("@city", city));
        //    updateRecord.Parameters.Add(new SqlParameter("@state", state));
        //    updateRecord.Parameters.Add(new SqlParameter("@zip", zip));
        //    updateRecord.Parameters.Add(new SqlParameter("@country", country));
        //    updateRecord.Parameters.Add(new SqlParameter("@gender", gender));
        //    updateRecord.Parameters.Add(new SqlParameter("@email", email));
        //    updateRecord.Parameters.Add(new SqlParameter("@dateOfBirth", dateOfBirth));
        //    updateRecord.Parameters.Add(new SqlParameter("@username", username));
        //    updateRecord.Parameters.Add(new SqlParameter("@lastUpdated", lastUpdated));
        //    updateRecord.Parameters.Add(new SqlParameter("@lastUpdatedBy", lastUpdatedBy));

        //    updateRecord.ExecuteNonQuery();
        //}

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
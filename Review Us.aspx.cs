using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

public partial class Review_Us : System.Web.UI.Page
{
    string conStr = @"server=hhidatabase.chi0h0eoorog.us-east-1.rds.amazonaws.com;database=hhidatabase;uid=hhi;password=hhidatabase;";
    int count = 0;
    System.Data.SqlClient.SqlConnection sc = new System.Data.SqlClient.SqlConnection();
    int ratingCount = 1;
    int id = 0;
    string docID;
    int value = 0;

    protected void Page_Load(object sender, EventArgs e)
    {

        sc.ConnectionString = @"server=hhidatabase.chi0h0eoorog.us-east-1.rds.amazonaws.com;database=hhidatabase;uid=hhi;password=hhidatabase;";




        if (star1.Checked)   //ROW 1
        {
            value = 5;
        }
        if (star2.Checked)
        {
            value = 4;
        }
        if (star3.Checked)
        {
            value = 3;
        }
        if (star4.Checked)
        {
            value = 2;
        }
        if (star5.Checked)
        {
            value = 1;
        }

        if (star6.Checked)   //ROW 2
        {
            value = 5;
        }
        if (star7.Checked)
        {
            value = 4;
        }
        if (star8.Checked)
        {
            value = 3;
        }
        if (star9.Checked)
        {
            value = 2;
        }
        if (star10.Checked)
        {
            value = 1;
        }



        if (star11.Checked)   //ROW 3
        {
            value = 5;
        }
        if (star12.Checked)
        {
            value = 4;
        }
        if (star13.Checked)
        {
            value = 3;
        }
        if (star14.Checked)
        {
            value = 2;
        }
        if (star15.Checked)
        {
            value = 1;
        }

        if (star16.Checked)   //ROW 4
        {
            value = 5;
        }
        if (star17.Checked)
        {
            value = 4;
        }
        if (star18.Checked)
        {
            value = 3;
        }
        if (star19.Checked)
        {
            value = 2;
        }
        if (star20.Checked)
        {
            value = 1;
        }

        if (star21.Checked)   //ROW 5
        {
            value = 5;
        }
        if (star22.Checked)
        {
            value = 4;
        }
        if (star23.Checked)
        {
            value = 3;
        }
        if (star24.Checked)
        {
            value = 2;
        }
        if (star25.Checked)
        {
            value = 1;
        }


        if (!IsPostBack)
        {
            FillData();

        }
        //SqlConnection quentin = new SqlConnection(conStr);
        //SqlCommand getType = new SqlCommand();        
        //getType.CommandText = "SELECT accountType FROM LoginInfo where username =" + Session["username"] + ";" ;
        //getType.Connection = quentin;
        //quentin.Open();
        //string type;               
        //SqlDataReader otherReader = getType.ExecuteReader();
        //type = otherReader.ToString();               
        //quentin.Close();
        //if (type == "Youth")
        //{
        //    string ID = " ";
        //    SqlConnection idk = new SqlConnection(conStr);
        //    SqlCommand getID = new SqlCommand();
        //    getID.CommandText = "SELECT youthID FROM Youth where username =" + Session["username"] + ";";
        //    getID.Connection = idk;
        //    idk.Open();

        //    SqlDataReader otherOtherReader = getID.ExecuteReader();            
        //    while (otherOtherReader.Read())
        //    {
        //        ID = otherOtherReader["youthID"].ToString();

        //    }
        //    int theID = int.Parse(ID);
        //    idk.Close();

        // THE SQL STATEMENT FOR SEARCHING LESSON YOUTH "SELECT Documents.Name FROM Documents INNER JOIN LessonYouth ON Documents.ID = (SELECT MAX(LessonYouth.ID) FROM LessonYouth WHERE LessonYouth.youthID =" + theID + ");";

        if (count == 0)
        {
            string name = " ";
            SqlConnection cn = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT ID,Name FROM[dbo].Documents WHERE ID = (SELECT MAX(ID) FROM[dbo].[Documents]);";
            cn.Open();
            cmd.Connection = cn;
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                name = reader["Name"].ToString();
                id = Convert.ToInt32(reader["ID"]);


            }
            cn.Close();
            doc1.InnerText = name;
            count++;
        }
        if (count == 1)
        {
            string name = " ";
            SqlConnection cn = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT ID,Name FROM[dbo].Documents WHERE ID = (SELECT MAX(ID) - 1 FROM[dbo].[Documents]);";
            cn.Open();
            cmd.Connection = cn;
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                name = reader["Name"].ToString();
                id = Convert.ToInt32(reader["ID"]);
            }
            cn.Close();
            doc2.InnerText = name;
            count++;
        }
        if (count == 2)
        {
            string name = " ";
            SqlConnection cn = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT ID,Name FROM [dbo].Documents WHERE ID = (SELECT MAX(ID)-2 FROM [dbo].[Documents]);";
            cn.Open();
            cmd.Connection = cn;
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                name = reader["Name"].ToString();
                id = Convert.ToInt32(reader["ID"]);
            }
            cn.Close();
            doc3.InnerText = name;
            count++;
        }
        if (count == 3)
        {
            string name = " ";
            SqlConnection cn = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT ID,Name FROM [dbo].Documents WHERE ID = (SELECT MAX(ID)-3 FROM [dbo].[Documents]);";
            cn.Open();
            cmd.Connection = cn;
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                name = reader["Name"].ToString();
                id = Convert.ToInt32(reader["ID"]);
            }
            cn.Close();
            doc4.InnerText = name;
            count++;
        }
        if (count == 4)
        {
            string name = " ";
            SqlConnection cn = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT ID,Name FROM [dbo].Documents WHERE ID = (SELECT MAX(ID)-4 FROM [dbo].[Documents]);";
            cn.Open();
            cmd.Connection = cn;
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                name = reader["Name"].ToString();
                id = Convert.ToInt32(reader["ID"]);
            }
            cn.Close();
            doc5.InnerText = name;
        }


    }


    private void FillData()
    {
        DataTable dt = new DataTable();
        using (SqlConnection cn = new SqlConnection(conStr))
        {
            SqlCommand cmd = new SqlCommand("GetDocuments", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            dt.Load(reader);
        }
        if (dt.Rows.Count > 0)
        {
            gvDocuments.DataSource = dt;
            gvDocuments.DataBind();

        }


    }



    protected void btnSubmit1(object sender, EventArgs e)
    {
        try
        {
            sc.Open();
            SqlCommand check = new SqlCommand();
            check.CommandText = "Select ID FROM [dbo].[Documents] WHERE Name = '" + doc1.InnerText + "'";
            SqlConnection cn = new SqlConnection(conStr);
            cn.Open();
            check.Connection = cn;
            SqlDataReader reader = check.ExecuteReader();

            while (reader.Read())
            {
                docID = reader["ID"].ToString();
            }
            cn.Close();
            sc.Close();


            lblStarVal.Text = "Rating Submitted!";
            sc.Open();
            SqlCommand login = new SqlCommand();
            login.Connection = sc;
            login.CommandText = "INSERT INTO [dbo].[Ratings] VALUES (@ID, @accountID, @Rating)";
            login.Parameters.AddWithValue("@ID", Convert.ToInt32(docID));  // document id
            login.Parameters.AddWithValue("@accountID", Session["accountID"].ToString());    //Must be loggin in or accountID = null
            login.Parameters.AddWithValue("@Rating", value);

            login.ExecuteNonQuery();
        }
        catch
        {
            lblStarVal.Text = "Error - Not signed in or no document name!";
        }
    }


    protected void btnSubmit2(object sender, EventArgs e)
    {
        try
        {
            sc.Open();
            SqlCommand check = new SqlCommand();
            check.CommandText = "Select ID FROM [dbo].[Documents] WHERE Name = '" + doc2.InnerText + "'";
            SqlConnection cn = new SqlConnection(conStr);
            cn.Open();
            check.Connection = cn;
            SqlDataReader reader = check.ExecuteReader();

            while (reader.Read())
            {
                docID = reader["ID"].ToString();
            }
            cn.Close();
            sc.Close();


            lblStarVal.Text = "Rating Submitted!";
            sc.Open();
            SqlCommand login = new SqlCommand();
            login.Connection = sc;
            login.CommandText = "INSERT INTO [dbo].[Ratings] VALUES (@ID, @accountID, @Rating)";
            login.Parameters.AddWithValue("@ID", docID);
            login.Parameters.AddWithValue("@accountID", Session["accountID"].ToString());    //Must be loggin in or accountID = null
            login.Parameters.AddWithValue("@Rating", value);

            login.ExecuteNonQuery();
        }
        catch
        {
            lblStarVal.Text = "Error - Not signed in or no document name!";
        }
    }
    protected void btnSubmit3(object sender, EventArgs e)
    {
        try
        {
            sc.Open();
            SqlCommand check = new SqlCommand();
            check.CommandText = "Select ID FROM [dbo].[Documents] WHERE Name = '" + doc3.InnerText + "'";
            SqlConnection cn = new SqlConnection(conStr);
            cn.Open();
            check.Connection = cn;
            SqlDataReader reader = check.ExecuteReader();

            while (reader.Read())
            {
                docID = reader["ID"].ToString();
            }
            cn.Close();
            sc.Close();


            lblStarVal.Text = "Rating Submitted!";
            sc.Open();
            SqlCommand login = new SqlCommand();
            login.Connection = sc;
            login.CommandText = "INSERT INTO [dbo].[Ratings] VALUES (@ID, @accountID, @Rating)";
            login.Parameters.AddWithValue("@ID", docID);
            login.Parameters.AddWithValue("@accountID", Session["accountID"].ToString());    //Must be loggin in or accountID = null
            login.Parameters.AddWithValue("@Rating", value);

            login.ExecuteNonQuery();
        }
        catch
        {
            lblStarVal.Text = "Error - Not signed in or no document name!";
        }
    }
    protected void btnSubmit4(object sender, EventArgs e)
    {
        try
        {
            sc.Open();
            SqlCommand check = new SqlCommand();
            check.CommandText = "Select ID FROM [dbo].[Documents] WHERE Name = '" + doc4.InnerText + "'";
            SqlConnection cn = new SqlConnection(conStr);
            cn.Open();
            check.Connection = cn;
            SqlDataReader reader = check.ExecuteReader();

            while (reader.Read())
            {
                docID = reader["ID"].ToString();
            }
            cn.Close();
            sc.Close();


            lblStarVal.Text = "Rating Submitted!";
            sc.Open();
            SqlCommand login = new SqlCommand();
            login.Connection = sc;
            login.CommandText = "INSERT INTO [dbo].[Ratings] VALUES (@ID, @accountID, @Rating)";
            login.Parameters.AddWithValue("@ID", docID);
            login.Parameters.AddWithValue("@accountID", Session["accountID"].ToString());    //Must be loggin in or accountID = null
            login.Parameters.AddWithValue("@Rating", value);

            login.ExecuteNonQuery();
        }
        catch
        {
            lblStarVal.Text = "Error - Not signed in or no document name!";
        }
    }
    protected void btnSubmit5(object sender, EventArgs e)
    {
        try
        {
            sc.Open();
            SqlCommand check = new SqlCommand();
            check.CommandText = "Select ID FROM [dbo].[Documents] WHERE Name = '" + doc5.InnerText + "'";
            SqlConnection cn = new SqlConnection(conStr);
            cn.Open();
            check.Connection = cn;
            SqlDataReader reader = check.ExecuteReader();

            while (reader.Read())
            {
                docID = reader["ID"].ToString();
            }
            cn.Close();
            sc.Close();


            lblStarVal.Text = "Rating Submitted!";
            sc.Open();
            SqlCommand login = new SqlCommand();
            login.Connection = sc;
            login.CommandText = "INSERT INTO [dbo].[Ratings] VALUES (@ID, @accountID, @Rating)";
            login.Parameters.AddWithValue("@ID", docID);
            login.Parameters.AddWithValue("@accountID", Session["accountID"].ToString());    //Must be loggin in or accountID = null
            login.Parameters.AddWithValue("@Rating", value);

            login.ExecuteNonQuery();
        }
        catch
        {
            lblStarVal.Text = "Error - Not signed in or no document name!";
        }
    }






}
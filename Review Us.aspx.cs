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
    string conStr = @"Server =localhost;Database=hhidatabase;Trusted_Connection=Yes;";
    int count = 0;
    System.Data.SqlClient.SqlConnection sc = new System.Data.SqlClient.SqlConnection();
    int ratingCount = 1;
    int id = 0;
    string docID;
    int value = 0;

    protected void Page_Load(object sender, EventArgs e)
    {
        
        sc.ConnectionString = @"Server =localhost;Database=hhidatabase;Trusted_Connection=Yes;";




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
        
            string name = " ";
            SqlConnection cn = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT Documents.ID, Documents.Name, Lessons.dateStarted FROM Lessons INNER JOIN Documents ON Lessons.ID = Documents.ID WHERE(Lessons.accountID = '" + Session["accountID"] + "') ORDER BY Lessons.dateStarted DESC";
            cn.Open();
            cmd.Connection = cn;
            SqlDataReader reader = cmd.ExecuteReader();
            int countName = 1;
            while (reader.Read())
            {
                name = reader["Name"].ToString();
                id = Convert.ToInt32(reader["ID"]);

            if (countName == 1)
            {
                doc1.InnerText = name;
            }
            if (countName == 2)
            {
                doc2.InnerText = name;
            }
            if (countName == 3)
            {
                doc3.InnerText = name;
            }
            if (countName == 4)
            {
                doc4.InnerText = name;
            }
            if (countName == 5)
            {
                doc5.InnerText = name;
            }
            countName++;
            }
            cn.Close();
      
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
        if (value != 0)
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
                login.CommandText = "INSERT INTO [dbo].[Ratings] VALUES (@ID, @accountID, @Rating,@Comment)";
                login.Parameters.AddWithValue("@ID", Convert.ToInt32(docID));  // document id
                login.Parameters.AddWithValue("@accountID", Session["accountID"].ToString());    //Must be loggin in or accountID = null
                login.Parameters.AddWithValue("@Rating", value);
                login.Parameters.AddWithValue("@Comment", txtComment1.Text);

                login.ExecuteNonQuery();
            }
            catch
            {
                lblStarVal.Text = "Error - Not signed in or no document name!";
            }
        }
        else { lblStarVal.Text = "Please Select a Rating"; }
        lblStarVal.Visible = true;
    }


    protected void btnSubmit2(object sender, EventArgs e)
    {
        if (value != 0)
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
                login.CommandText = "INSERT INTO [dbo].[Ratings] VALUES (@ID, @accountID, @Rating, @Comment)";
                login.Parameters.AddWithValue("@ID", docID);
                login.Parameters.AddWithValue("@accountID", Session["accountID"].ToString());    //Must be loggin in or accountID = null
                login.Parameters.AddWithValue("@Rating", value);
                login.Parameters.AddWithValue("@Comment", txtComment2.Text);

                login.ExecuteNonQuery();
            }
            catch
            {
                lblStarVal.Text = "Error - Not signed in or no document name!";
            }
        }
        else { lblStarVal.Text = "Please Select a Rating"; }
        lblStarVal.Visible = true;
    }
    protected void btnSubmit3(object sender, EventArgs e)
    {
        if (value != 0)
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
                login.CommandText = "INSERT INTO [dbo].[Ratings] VALUES (@ID, @accountID, @Rating,@Comment)";
                login.Parameters.AddWithValue("@ID", docID);
                login.Parameters.AddWithValue("@accountID", Session["accountID"].ToString());    //Must be loggin in or accountID = null
                login.Parameters.AddWithValue("@Rating", value);
                login.Parameters.AddWithValue("@Comment", txtComment3.Text);

                login.ExecuteNonQuery();
            }
            catch
            {
                lblStarVal.Text = "Error - Not signed in or no document name!";
            }
        }
        else { lblStarVal.Text = "Please Select a Rating"; }
        lblStarVal.Visible = true;
    }
    protected void btnSubmit4(object sender, EventArgs e)
    {
        if (value != 0)
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
                login.CommandText = "INSERT INTO [dbo].[Ratings] VALUES (@ID, @accountID, @Rating,@Comment)";
                login.Parameters.AddWithValue("@ID", docID);
                login.Parameters.AddWithValue("@accountID", Session["accountID"].ToString());    //Must be loggin in or accountID = null
                login.Parameters.AddWithValue("@Rating", value);
                login.Parameters.AddWithValue("@Comment", txtComment4.Text);

                login.ExecuteNonQuery();
            }
            catch
            {
                lblStarVal.Text = "Error - Not signed in or no document name!";
            }
        }
        else { lblStarVal.Text = "Please Select a Rating"; }
        lblStarVal.Visible = true;
    }
    protected void btnSubmit5(object sender, EventArgs e)
    {
        if (value != 0)
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
                login.CommandText = "INSERT INTO [dbo].[Ratings] VALUES (@ID, @accountID, @Rating,@Comment, @LastUpdated, @LastUpdatedBy)";
                login.Parameters.AddWithValue("@ID", docID);
                login.Parameters.AddWithValue("@accountID", Session["accountID"].ToString());    //Must be loggin in or accountID = null
                login.Parameters.AddWithValue("@Rating", value);
                login.Parameters.AddWithValue("@Comment", txtComment5.Text);
                login.Parameters.AddWithValue("@LastUpdated", DateTime.Now.ToString());
                login.Parameters.AddWithValue("@LastUpdatedBy", Session["accountID"].ToString());

                login.ExecuteNonQuery();
            }
            catch
            {
                lblStarVal.Text = "Error - Not signed in or no document name!";
            }
        }
        else { lblStarVal.Text = "Please Select a Rating"; }
        lblStarVal.Visible = true;
    }






}
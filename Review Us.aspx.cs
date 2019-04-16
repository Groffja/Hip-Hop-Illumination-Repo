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
    string conStr = @"Data Source=localhost;Database=hhidatabase;Integrated Security=true";
    int count = 0;
    System.Data.SqlClient.SqlConnection sc = new System.Data.SqlClient.SqlConnection();
    int ratingCount = 1;
    int id = 0;

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
    //protected void btnRead(object sender, EventArgs e)
    //{
    //    LinkButton lnk = (LinkButton)sender;
    //    GridViewRow gr = (GridViewRow)lnk.NamingContainer;

    //    int id = int.Parse(gvDocuments.DataKeys[gr.RowIndex].Value.ToString());
    //    Download(id);

    //    //try
    //    //{
    //    //    SqlConnection cn = new SqlConnection(conStr);
    //    //    cn.Open();
    //    //    SqlCommand cmd = new SqlCommand();
    //    //    cmd.Connection = cn;
    //    //    cmd.CommandText = "INSERT INTO Lessons VALUES (" + id + "," + Session["accountID"] + ",GETDATE(),GETDATE(),'" + Session["username"] + "');";
    //    //    cmd.ExecuteNonQuery();
    //    //    cn.Close();
    //    //}
    //    //catch
    //    //{

    //    //}

    //}
    //private void Download(int id)
    //{
    //    DataTable dt = new DataTable();
    //    using (SqlConnection cn = new SqlConnection(conStr))
    //    {
    //        SqlCommand cmd = new SqlCommand("GetDocument", cn);
    //        cmd.CommandType = CommandType.StoredProcedure;
    //        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;
    //        cn.Open();
    //        SqlDataReader reader = cmd.ExecuteReader();

    //        dt.Load(reader);
    //    }

    //    string name = dt.Rows[0]["Name"].ToString();



    //    byte[] documentBytes = (byte[])dt.Rows[0]["DocumentContent"];

    //    Response.ClearContent();
    //    Response.ContentType = "appliction/octetstream";
    //    Response.AddHeader("Content-Disposition", string.Format("attachment; filename=" + name));
    //    Response.AddHeader("Content-Length", documentBytes.Length.ToString());

    //    Response.BinaryWrite(documentBytes);
    //    Response.Flush();
    //    Response.Close();

    //}

    protected void btnSubmit1(object sender, EventArgs e)
    {

        lblStarVal.Text = "Rating Submitted!";
        sc.Open();
        SqlCommand login = new SqlCommand();
        login.Connection = sc;
        login.CommandText = "INSERT INTO [dbo].[Ratings] VALUES (@ID, @accountID, @Rating)";
        login.Parameters.AddWithValue("@ID", 1);  // document id
        login.Parameters.AddWithValue("@accountID", Session["accountID"].ToString());    //Must be loggin in or accountID = null
        login.Parameters.AddWithValue("@Rating", value);

        login.ExecuteNonQuery();
    }
    protected void btnSubmit2(object sender, EventArgs e)
    {

        lblStarVal.Text = "Rating Submitted!";
        sc.Open();
        SqlCommand login = new SqlCommand();
        login.Connection = sc;
        login.CommandText = "INSERT INTO [dbo].[Ratings] VALUES (@ID, @accountID, @Rating)";
        login.Parameters.AddWithValue("@ID", 2);
        login.Parameters.AddWithValue("@accountID", Session["accountID"].ToString());    //Must be loggin in or accountID = null
        login.Parameters.AddWithValue("@Rating", value);

        login.ExecuteNonQuery();
    }
    protected void btnSubmit3(object sender, EventArgs e)
    {
        id = 3;
        lblStarVal.Text = "Rating Submitted!";
        sc.Open();
        SqlCommand login = new SqlCommand();
        login.Connection = sc;
        login.CommandText = "INSERT INTO [dbo].[Ratings] VALUES (@ID, @accountID, @Rating)";
        login.Parameters.AddWithValue("@ID", 3);
        login.Parameters.AddWithValue("@accountID", Session["accountID"].ToString());    //Must be loggin in or accountID = null
        login.Parameters.AddWithValue("@Rating", value);

        login.ExecuteNonQuery();
    }
    protected void btnSubmit4(object sender, EventArgs e)
    {

        lblStarVal.Text = "Rating Submitted!";
        sc.Open();
        SqlCommand login = new SqlCommand();
        login.Connection = sc;
        login.CommandText = "INSERT INTO [dbo].[Ratings] VALUES (@ID, @accountID, @Rating)";
        login.Parameters.AddWithValue("@ID", 4);
        login.Parameters.AddWithValue("@accountID", Session["accountID"].ToString());    //Must be loggin in or accountID = null
        login.Parameters.AddWithValue("@Rating", value);

        login.ExecuteNonQuery();
    }
    protected void btnSubmit5(object sender, EventArgs e)
    {
        id = 5;
        lblStarVal.Text = "Rating Submitted!";
        sc.Open();
        SqlCommand login = new SqlCommand();
        login.Connection = sc;
        login.CommandText = "INSERT INTO [dbo].[Ratings] VALUES (@ID, @accountID, @Rating)";
        login.Parameters.AddWithValue("@ID", 5);
        login.Parameters.AddWithValue("@accountID", Session["accountID"].ToString());    //Must be loggin in or accountID = null
        login.Parameters.AddWithValue("@Rating", value);

        login.ExecuteNonQuery();
    }






}
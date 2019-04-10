using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;
using System.Data.SqlClient;

public partial class Review_Us : System.Web.UI.Page
{
    string conStr = @"Data Source=localhost;Database=hhidatabase;Integrated Security=true";
    int count = 0;


    protected void Page_Load(object sender, EventArgs e)
    {

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
            cmd.CommandText = "SELECT Name FROM[dbo].Lessons WHERE ID = (SELECT MAX(ID) FROM[dbo].[Documents]);";
            cn.Open();
            cmd.Connection = cn;
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                name = reader["Name"].ToString();

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
            cmd.CommandText = "SELECT Name FROM[dbo].Documents WHERE ID = (SELECT MAX(ID) - 1 FROM[dbo].[Documents]);";
            cn.Open();
            cmd.Connection = cn;
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                name = reader["Name"].ToString();

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
            cmd.CommandText = "SELECT Name FROM [dbo].Documents WHERE ID = (SELECT MAX(ID)-2 FROM [dbo].[Documents]);";
            cn.Open();
            cmd.Connection = cn;
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                name = reader["Name"].ToString();

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
            cmd.CommandText = "SELECT Name FROM [dbo].Documents WHERE ID = (SELECT MAX(ID)-3 FROM [dbo].[Documents]);";
            cn.Open();
            cmd.Connection = cn;
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                name = reader["Name"].ToString();

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
            cmd.CommandText = "SELECT Name FROM [dbo].Documents WHERE ID = (SELECT MAX(ID)-4 FROM [dbo].[Documents]);";
            cn.Open();
            cmd.Connection = cn;
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                name = reader["Name"].ToString();

            }
            cn.Close();
            doc5.InnerText = name;
        }
        //}

    }
    protected void OpenDocument(object sender, EventArgs e)
    {
        LinkButton lnk = (LinkButton)sender;
        GridViewRow gr = (GridViewRow)lnk.NamingContainer;

        int id = int.Parse(gvDocuments.DataKeys[gr.RowIndex].Value.ToString());
        Download(id);
    }
    private void Download(int id)
    {
        DataTable dt = new DataTable();
        using (SqlConnection cn = new SqlConnection(conStr))
        {
            SqlCommand cmd = new SqlCommand("GetDocument", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;
            cn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            dt.Load(reader);
        }

        string name = dt.Rows[0]["Name"].ToString();



        byte[] documentBytes = (byte[])dt.Rows[0]["DocumentContent"];

        Response.ClearContent();
        Response.ContentType = "appliction/octetstream";
        Response.AddHeader("Content-Disposition", string.Format("attachment; filename=" + name));
        Response.AddHeader("Content-Length", documentBytes.Length.ToString());

        Response.BinaryWrite(documentBytes);
        Response.Flush();
        Response.Close();

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


}
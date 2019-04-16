using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;
using System.Data.SqlClient;

public partial class Youtube : System.Web.UI.Page
{
    string conStr = @"server=hhidatabase.chi0h0eoorog.us-east-1.rds.amazonaws.com;database=hhidatabase;uid=hhi;password=hhidatabase;";
    string youtube = " ";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            FillData();
        }
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
            SqlCommand cmd = new SqlCommand("GetVideo", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@resourceID", SqlDbType.Int).Value = id;
            cn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            dt.Load(reader);
        }

        string name = dt.Rows[0]["title"].ToString();
        //byte[] documentBytes = (byte[])dt.Rows[0]["Hyperlink"];
        string video = dt.Rows[0]["Hyperlink"].ToString();
        youtube = video;
        Response.ClearContent();
        Response.ContentType = "appliction/octetstream";
        //Response.AddHeader("Content-Disposition", string.Format("attachment; filename=" + name));
        // Response.AddHeader("Content-Length", documentBytes.Length.ToString());

        //Response.BinaryWrite(documentBytes);
        Response.Flush();
        Response.Close();
    }
    private void FillData()
    {
        DataTable dt = new DataTable();
        using (SqlConnection cn = new SqlConnection(conStr))
        {
            SqlCommand cmd = new SqlCommand("GetVideos", cn);
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


    protected void Button1_Click(object sender, EventArgs e)
    {
        //FileInfo fi = new FileInfo(FileUpload1.FileName);
        //byte[] Hyperlink = FileUpload1.FileBytes;



        using (SqlConnection cn = new SqlConnection(conStr))
        {
            SqlCommand cmd = new SqlCommand("SaveVideos", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@title", SqlDbType.VarChar).Value = txtTitle.Text;
            cmd.Parameters.Add("@Hyperlink", SqlDbType.VarChar).Value = url.Text;
            cmd.Parameters.Add("@category", SqlDbType.VarChar).Value = txtCategory.Text;


            cn.Open();
            cmd.ExecuteNonQuery();
        }
        FillData();
        Response.Redirect("Youtube.aspx");
    }


}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;
using System.Data.SqlClient;

public partial class Uploading : System.Web.UI.Page
{
    
    string conStr = @"server=hhidatabase.chi0h0eoorog.us-east-1.rds.amazonaws.com;database=hhidatabase;uid=hhi;password=hhidatabase;";
    System.Data.SqlClient.SqlConnection sc = new System.Data.SqlClient.SqlConnection();

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
        try
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
        catch
        {

        }

    }




    private void FillData()
    {

        try
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
        catch
        {

        }

    }




    protected void save_Click(object sender, EventArgs e)
    {
        try
        {
            FileInfo fi = new FileInfo(FileUpload1.FileName);
            byte[] documentContent = FileUpload1.FileBytes;

            string name = fi.Name;
            string extn = fi.Extension;
            string category = TextBox2.Text;
            string category2 = txtCat2.Text;
            string category3 = txtCat3.Text;

            using (SqlConnection cn = new SqlConnection(conStr))
            {
                SqlCommand cmd = new SqlCommand("SaveDocument", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = name;
                cmd.Parameters.Add("@Content", SqlDbType.VarBinary).Value = documentContent;
                cmd.Parameters.Add("@Extn", SqlDbType.VarChar).Value = extn;
                cmd.Parameters.Add("@Category", SqlDbType.VarChar).Value = category;
                cmd.Parameters.Add("@Category2", SqlDbType.VarChar).Value = category2;
                cmd.Parameters.Add("@Category3", SqlDbType.VarChar).Value = category3;
                cn.Open();
                cmd.ExecuteNonQuery();
            }

            FillData();
            Response.Redirect("Uploading.aspx");

        }
        catch
        {

        }

    }



    protected void Row_Deleting(object sender, EventArgs e)
    {   
        
        sc.ConnectionString = @"server=hhidatabase.chi0h0eoorog.us-east-1.rds.amazonaws.com;database=hhidatabase;uid=hhi;password=hhidatabase;";

        sc.Open();
        System.Data.SqlClient.SqlCommand delete = new System.Data.SqlClient.SqlCommand();
        delete.Connection = sc;

        delete.CommandText = "DELETE FROM [Documents] WHERE [DocumentID]=@DocumentID";
        delete.ExecuteNonQuery();

    }

}
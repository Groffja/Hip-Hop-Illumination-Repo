﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;
using System.Data.SqlClient;
public partial class ReadPDFs : System.Web.UI.Page
{
    //System.Data.SqlClient.SqlConnection sc = new System.Data.SqlClient.SqlConnection();
    //string exception = string.Empty;
    string conStr = @"server=hhidatabase.chi0h0eoorog.us-east-1.rds.amazonaws.com;database=hhidatabase;uid=hhi;password=hhidatabase;";

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

    //protected void Button1_Click(object sender, EventArgs e)
    //{
    //    FileInfo fi = new FileInfo(FileUpload1.FileName);
    //    byte[] documentContent = FileUpload1.FileBytes;

    //    string name = fi.Name;
    //    string extn = fi.Extension;

    //    using (SqlConnection cn = new SqlConnection(conStr))
    //    {
    //        SqlCommand cmd = new SqlCommand("SaveDocument", cn);
    //        cmd.CommandType = CommandType.StoredProcedure;

    //        cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = name;
    //        cmd.Parameters.Add("@Content", SqlDbType.VarBinary).Value = documentContent;
    //        cmd.Parameters.Add("@Extn", SqlDbType.VarChar).Value = extn;

    //        cn.Open();
    //        cmd.ExecuteNonQuery();
    //    }
    //    FillData();
    //}
}
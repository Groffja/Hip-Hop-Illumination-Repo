﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Diagnostics;

public partial class Youtube : System.Web.UI.Page
{
    string conStr = @"Data Source=localhost;Database=hhidatabase;Integrated Security=true";
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



    protected void Button2_Click(object sender, EventArgs e)
    {       
        UrlIsValid(url.Text);
        

    }

    public bool UrlIsValid(string url)
    {
        Label5.Text = " ";
        try
        {
            System.Net.HttpWebRequest request = System.Net.HttpWebRequest.Create(url) as System.Net.HttpWebRequest;
            request.Timeout = 5000; //set the timeout to 5 seconds to keep the user from waiting too long for the page to load
            request.Method = "HEAD"; //Get only the header information -- no need to download any content

            using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
            {
                int statusCode = (int)response.StatusCode;
                if (statusCode >= 100 && statusCode < 400) //Good requests
                {
                    Button1.Enabled = true;
                    bool valid = true;
                    return valid;
                    

                }
                else if (statusCode >= 500 && statusCode <= 510) //Server Errors
                {
                    //log.Warn(String.Format("The remote server has thrown an internal error. Url is not valid: {0}", url));
                    Debug.WriteLine(String.Format("The remote server has thrown an internal error. Url is not valid: {0}", url));
                    return false;
                    
                }
            }
        }
        catch (WebException ex)
        {
            if (ex.Status == WebExceptionStatus.ProtocolError) //400 errors
            {
                return false;
            }
            else
            {
                //log.Warn(String.Format("Unhandled status [{0}] returned for url: {1}", ex.Status, url), ex);
                Label5.Text = "Invalid URL. Please Try Again.";
            }
        }
        catch (Exception ex)
        {
            //log.Error(String.Format("Could not test url {0}.", url), ex);
            Label5.Text = "Invalid URL. Please Try Again.";
        }
        return false;
        
    }
}
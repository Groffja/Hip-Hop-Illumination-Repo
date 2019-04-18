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
public partial class BrowseLessons : System.Web.UI.Page
{
    string conStr = @"server=hhidatabase.chi0h0eoorog.us-east-1.rds.amazonaws.com;database=hhidatabase;uid=hhi;password=hhidatabase;";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            FillData();
            this.BindGrid();
        }
        if (!IsPostBack)
        {
            SqlConnection sc = new SqlConnection(conStr);
            sc.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sc;
            cmd.CommandText = "SELECT ID FROM Documents";

            SqlDataReader reader1 = cmd.ExecuteReader();

            if (!reader1.HasRows)
            {
                noLessons.Visible = true;
            }
        }
    }

    protected void OpenDocument(object sender, EventArgs e)
    {
        LinkButton lnk = (LinkButton)sender;
        GridViewRow gr = (GridViewRow)lnk.NamingContainer;

        int id = int.Parse(gvDocuments.DataKeys[gr.RowIndex].Value.ToString());
        Download(id);

        try
        {
            SqlConnection cn = new SqlConnection(conStr);
            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "INSERT INTO Lessons VALUES (" + id + "," + Session["accountID"] + ",GETDATE(),GETDATE(),'" + Session["username"] + "');";
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        catch
        {
            noLessons.Text = "Not signed into account!!";
            noLessons.Visible = true;
        }



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

        //string documentCategory = dt.Rows[0]["DocumentCategory"].ToString();
        //new

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

 

    private void BindGrid()
    {
        using (SqlConnection cn = new SqlConnection(conStr))
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "SELECT ID, Name, DocumentCategory,DocumentCategory2,DocumentCategory3 FROM Documents WHERE Name LIKE '%' + @Name + '%'";
                cmd.Connection = cn;
                cmd.Parameters.AddWithValue("@Name", txtSearch.Text.Trim());
                DataTable dt = new DataTable();
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    sda.Fill(dt);
                    gvDocuments.DataSource = dt;
                    gvDocuments.DataBind();
                }
            }
        }
    }

    private void CategoryGridBind()
    {
        using (SqlConnection cn = new SqlConnection(conStr))
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "SELECT ID, Name, DocumentCategory,DocumentCategory2,DocumentCategory3 FROM Documents WHERE ((DocumentCategory LIKE '%' + @category + '%') OR (DocumentCategory2 LIKE '%' + @category + '%') OR (DocumentCategory3 LIKE '%' + @category + '%')";
                cmd.Connection = cn;
                cmd.Parameters.AddWithValue("@Name", txtCat.Text.Trim());
                DataTable dt = new DataTable();
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    sda.Fill(dt);
                    gvDocuments.DataSource = dt;
                    gvDocuments.DataBind();
                }
            }
        }
    }

    protected void OnPageIndexChanging(Object sender, GridViewPageEventArgs e)
    {
        gvDocuments.PageIndex = e.NewPageIndex;
        this.BindGrid();
    }

    protected void OnRowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Cells[0].Text = Regex.Replace(e.Row.Cells[0].Text, txtSearch.Text.Trim(), delegate (Match match)
            {
                return string.Format("<span style = 'background-color:#D9EDF7'>{0}</span>", match.Value);
            }, RegexOptions.IgnoreCase);
        }
    }



    protected void btnSearch_Click(object sender, EventArgs e)
    {
        BindGrid();
    }

    protected void btnCatSearch_Click(object sender, EventArgs e)
    {
        BindGrid();
    }

    protected void txtSearch_TextChanged(object sender, EventArgs e)
    {

    }

    protected void gvDocuments_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
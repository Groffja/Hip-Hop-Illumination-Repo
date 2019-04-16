using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdultTablau : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        gender.Visible = false;
        youthMap.Visible = false;
        adultMap.Visible = false;
        favoriteArtist.Visible = false;
        favoriteGenre.Visible = false;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        gender.Visible = false;
        favoriteGenre.Visible = false;
        favoriteArtist.Visible = false;
        youthMap.Visible = false;
        adultMap.Visible = true;
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        gender.Visible = false; ;
        favoriteGenre.Visible = false;
        favoriteArtist.Visible = false;
        adultMap.Visible = false;
        youthMap.Visible = true;
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        gender.Visible = false;
        favoriteGenre.Visible = false;
        adultMap.Visible = false;
        youthMap.Visible = false;
        favoriteArtist.Visible = true;
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        gender.Visible = false;
        adultMap.Visible = false;
        youthMap.Visible = false;
        favoriteArtist.Visible = false;
        favoriteGenre.Visible = true;
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        adultMap.Visible = false;
        youthMap.Visible = false;
        favoriteArtist.Visible = false;
        favoriteGenre.Visible = false;
        gender.Visible = true;
    }
}
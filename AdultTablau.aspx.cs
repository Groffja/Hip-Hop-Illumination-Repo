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
        // Check session is expire or timeout. 
        if (Session["adminLoggedIn"] == null)
        {
            Response.Redirect("Login.aspx?info=0");
        }

        lessonRatings.Visible = false;
        populationPyramid.Visible = false;
        gender.Visible = false;
        youthMap.Visible = false;
        adultMap.Visible = false;
        favoriteArtist.Visible = false;
        favoriteGenre.Visible = false;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        lessonRatings.Visible = false;
        populationPyramid.Visible = false;
        gender.Visible = false;
        favoriteGenre.Visible = false;
        favoriteArtist.Visible = false;
        youthMap.Visible = false;
        adultMap.Visible = true;
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        lessonRatings.Visible = false;
        populationPyramid.Visible = false;
        gender.Visible = false; ;
        favoriteGenre.Visible = false;
        favoriteArtist.Visible = false;
        adultMap.Visible = false;
        youthMap.Visible = true;
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        lessonRatings.Visible = false;
        populationPyramid.Visible = false;
        gender.Visible = false;
        favoriteGenre.Visible = false;
        adultMap.Visible = false;
        youthMap.Visible = false;
        favoriteArtist.Visible = true;
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        lessonRatings.Visible = false;
        populationPyramid.Visible = false;
        gender.Visible = false;
        adultMap.Visible = false;
        youthMap.Visible = false;
        favoriteArtist.Visible = false;
        favoriteGenre.Visible = true;
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        lessonRatings.Visible = false;
        populationPyramid.Visible = false;
        adultMap.Visible = false;
        youthMap.Visible = false;
        favoriteArtist.Visible = false;
        favoriteGenre.Visible = false;
        gender.Visible = true;
    }
    protected void Button6_Click(object sender, EventArgs e)
    {
        lessonRatings.Visible = false;
        adultMap.Visible = false;
        youthMap.Visible = false;
        favoriteArtist.Visible = false;
        favoriteGenre.Visible = false;
        gender.Visible = false;
        populationPyramid.Visible = true;
    }
    protected void Button7_Click(object sender, EventArgs e)
    {
        lessonRatings.Visible = true;
        adultMap.Visible = false;
        youthMap.Visible = false;
        favoriteArtist.Visible = false;
        favoriteGenre.Visible = false;
        gender.Visible = false;
        populationPyramid.Visible = false;
    }
}
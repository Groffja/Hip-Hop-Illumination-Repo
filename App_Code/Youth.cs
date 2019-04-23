using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Youth
/// </summary>
public class Youth : User
{

    private string firstName;
    private string lastName;
    private string state;
    private string country;
    private string email;
    private string dateOfBirth;
    private string gender;
    private string userName;
    private string password;
    private string favoriteArtist;
    private string favoriteMusic;
    private int lessonID;
    private string dateCreated = DateTime.Now.ToString("yyyy-MM-dd");

    public Youth(string firstName, string lastName, string state, string country, string email, string dateOfBirth, string gender, string favoriteArtist, string favoriteMusic, string userName, string password)
    {
        setFirstName(firstName);
        setLastName(lastName);
        setState(state);
        setCountry(country);
        setEmail(email);
        setDateOfBirth(dateOfBirth);
        setGender(gender);
        setFavoriteArtist(favoriteArtist);
        setFavoriteMusic(favoriteMusic);
        setUserName(userName);
        setPassword(password);
    }

    //Setters
    protected void setFavoriteArtist(string favoriteArtist)
    {
        this.favoriteArtist = favoriteArtist;
    }
    protected void setFavoriteMusic(string favoriteMusic)
    {
        this.favoriteMusic = favoriteMusic;
    }
    protected void setUserName(string userName)
    {
        this.userName = userName;
    }
    protected void setGender(string gender)
    {
        this.gender = gender;
    }

    //getters     
    
    public string getFavoriteArtist()
    {
        return this.favoriteArtist;
    }
    public string getFavoriteMusic()
    {
        return this.favoriteMusic;
    }
    public string getUserName()
    {
        return this.userName;
    }
    public string getGender()
    {
        return this.gender;
    }
}
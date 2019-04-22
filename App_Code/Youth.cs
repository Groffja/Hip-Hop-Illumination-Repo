using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Youth
/// </summary>
public class Youth
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

    protected void setFirstName(string firstName)
    {
        this.firstName = firstName;
    }
    protected void setLastName(string lastName)
    {
        this.lastName = lastName;
    }
    protected void setState(string state)
    {
        this.state = state;
    }
    protected void setCountry(string country)
    {
        this.country = country;
    }
 
    protected void setEmail(string email)
    {
        this.email = email;
    }
    protected void setDateOfBirth(string dateOfBirth)
    {
        this.dateOfBirth = dateOfBirth;
    }
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
    protected void setPassword(string password)
    {
        this.password = password;
    }
    protected void setGender(string gender)
    {
        this.gender = gender;
    }

    //getters     
    public string getFirstName()
    {
        return this.firstName;
    }
    public string getLastName()
    {
        return this.lastName;
    }
    public string getState()
    {
        return this.state;
    }
    public string getCountry()
    {
        return this.country;
    }

    public string getEmail()
    {
        return this.email;
    }
    public string getDateOfBirth()
    {
        return this.dateOfBirth;
    }
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
    public string getPassword()
    {
        return this.password;
    }
    public string getGender()
    {
        return this.gender;
    }
    public string getDateCreated()
    {
        return this.dateCreated;
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for YouthWorker
/// </summary>
public class YouthWorker
{
    private string firstName;
    private string middleName;
    private string lastName;
    private string street;
    private string city;
    private string state;
    private string zipCode;
    private string country;
    private string email;
    private string dateOfBirth;
    private string username;
    private string password;
    private int lessonID;
    private int adultID;
    private int schoolID;
    private string gender;
    private string dateCreated = DateTime.Now.ToString("yyyy-MM-dd");


    public YouthWorker(string firstName, string middleName, string lastName, string street, string city, string state, string zipCode, string country, string email, string dateOfBirth,
        string username, string password, string gender)
    {
        setFirstName(firstName);
        setLastName(lastName);
        setMiddleName(middleName);
        setStreet(street);
        setCity(city);
        setState(state);
        setZipCode(zipCode);
        setCountry(country);
        setEmail(email);
        setDateOfBirth(dateOfBirth);
        setUsername(username);
        setPassword(password);
        setGeneder(gender);

    }

    protected void setFirstName(string firstName)
    {
        this.firstName = firstName;
    }

    protected void setMiddleName(string middleName)
    {
        this.middleName = middleName;
    }

    protected void setLastName(string lastName)
    {
        this.lastName = lastName;
    }

    protected void setCity(string city)
    {
        this.city = city;
    }

    protected void setState(string state)
    {
        this.state = state;
    }

    protected void setStreet(string street)
    {
        this.street = street;
    }

    protected void setCountry(string country)
    {
        this.country = country;
    }

    protected void setZipCode(string zipCode)
    {
        this.zipCode = zipCode;
    }

    protected void setEmail(string email)
    {
        this.email = email;
    }

    protected void setDateOfBirth(string dateOfBirth)
    {
        this.dateOfBirth = dateOfBirth;
    }

    protected void setUsername(string username)
    {
        this.username = username;
    }

    protected void setPassword(string password)
    {
        this.password = password;
    }


    protected void setLessonID(int lessonID)
    {
        this.lessonID = lessonID;
    }

    protected void setAdultID(int adultID)
    {
        this.adultID = adultID;
    }

    protected void setSchoolID(int schoolID)
    {
        this.schoolID = schoolID;
    }

    protected void setGeneder(String gender)
    {
        this.gender = gender;
    }

    public string getFirstName()
    {
        return this.firstName;
    }

    public string getMiddleName()
    {
        return this.middleName;
    }

    public string getLastName()
    {
        return this.lastName;
    }

    public string getCity()
    {
        return this.city;
    }

    public string getState()
    {
        return this.state;
    }

    public string getStreet()
    {
        return this.street;
    }

    public string getCountry()
    {
        return this.country;
    }

    public string getZipCode()
    {
        return this.zipCode;
    }

    public string getEmail()
    {
        return this.email;
    }

    public string getDateOfBirth()
    {
        return this.dateOfBirth;
    }

    public string getUsername()
    {
        return this.username;
    }

    public string getPassword()
    {
        return this.password;
    }


    public int getLessonID()
    {
        return this.lessonID;
    }

    public int getAdultID()
    {
        return this.adultID;
    }

    public int getSchoolID()
    {
        return this.schoolID;
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
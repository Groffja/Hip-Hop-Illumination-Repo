using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Adult
{
    private string firstName;
    private string middleName;
    private string lastName;
    private string street;
    private string city;
    private string state;
    private string zip;
    private string country;
    private string adultType;
    private string email;
    private string dateOfBirth;
    private string gender;
    private string userName;
    private string password;
    private int lessonID;
    private string dateCreated = DateTime.Now.ToString("yyyy-MM-dd");

    public Adult(string firstName, string middleName, string lastName, string street, string city, string state, string zip, string country, string adultType, string email, string dateOfBirth, string gender, string userName, string password)
    {
        setFirstName(firstName);
        setMiddleName(middleName);
        setLastName(lastName);
        setStreet(street);
        setCity(city);
        setState(state);
        setZip(zip);
        setCountry(country);
        setAdultType(adultType);
        setEmail(email);
        setDateOfBirth(dateOfBirth);
        setGender(gender);
        setUserName(userName);
        setPassword(password);        
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
    protected void setStreet(string street)
    {
        this.street = street;
    }
    protected void setCity(string city)
    {
        this.city = city;
    }
    protected void setState(string state)
    {
        this.state = state;
    }
    protected void setZip(string zip)
    {
        this.zip = zip;
    }
    protected void setCountry(string country)
    {
        this.country = country;
    }
    protected void setAdultType(string adultType)
    {
        this.adultType = adultType;
    }
    protected void setEmail(string email)
    {
        this.email = email;
    }
    protected void setDateOfBirth(string dateOfBirth)
    {
        this.dateOfBirth = dateOfBirth;
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
    public string getMiddleName()
    {
        return this.middleName;
    }
    public string getLastName()
    {
        return this.lastName;
    }
    public string getStreet()
    {
        return this.street;
    }
    public string getCity()
    {
        return this.city;
    }
    public string getZipCode()
    {
        return this.zip;
    }
    public string getState()
    {
        return this.state;
    }
    public string getCountry()
    {
        return this.country;
    }
    public string getAdultType()
    {
        return this.adultType;
    }
    public string getEmail()
    {
        return this.email;
    }
    public string getDateOfBirth()
    {
        return this.dateOfBirth;
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
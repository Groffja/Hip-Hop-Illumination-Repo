using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class User
{
    // Constructor for both youth and adult

    private string firstName;
    private string lastName;
    private string state;
    private string country;
    private string email;
    private string dateOfBirth;
    private string password;
    private string dateCreated = DateTime.Now.ToString("yyyy-MM-dd");

    public User()
    {

    }

    // Setters

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

    protected void setPassword(string password)
    {
        this.password = password;
    }

    // Getters

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

    public string getPassword()
    {
        return this.password;
    }

    public string getDateCreated()
    {
        return this.dateCreated;
    }

}
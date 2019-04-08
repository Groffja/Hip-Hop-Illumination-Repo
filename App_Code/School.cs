using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for School
/// </summary>
public class School
{
    private int schoolID;
    private string schoolName;
    private string schoolNickname;
    private string street;
    private string city;
    private string state;
    private string zip;
    private string country;

    public School(int schoolID, string schoolName, string schoolNickname, string street, string city, string state, string zip, string country)
    {
        setSchoolID(schoolID);
        setSchoolName(schoolName);
        setSchoolNickname(schoolNickname);        
        setStreet(street);
        setCity(city);
        setState(state);
        setZip(zip);
        setCountry(country);
    }


    //SETTERS
    protected void setSchoolID(int schoolID)
    {
        this.schoolID = schoolID;
    }
    protected void setSchoolName(string schoolName)
    {
        this.schoolName = schoolName;
    }
    protected void setSchoolNickname(string schoolNickname)
    {
        this.schoolNickname = schoolNickname;
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

    //GETTERS
    protected int getSchoolID()
    {
        return this.schoolID;
    }
    protected string getSchoolName()
    {
        return this.schoolName;
    }
    protected string getSchoolNickname()
    {
        return this.schoolNickname;
    }
    protected string getStreet()
    {
        return this.street;
    }
    protected string getCity()
    {
        return this.city;
    }
    protected string getState()
    {
        return this.state;
    }
    protected string getZip()
    {
        return this.zip;
    }
    protected string getCountry()
    {
        return this.country;
    }
}
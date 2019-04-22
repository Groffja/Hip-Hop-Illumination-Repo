using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Class1
/// </summary>
public class BrowseLesson
{
    private int lessonID;
    private int accountID;
    private string dateStarted;
    private string lastUpdated;
    private string lastUpdatedBy;

    public BrowseLesson(int lessonID, int accountID, string dateStarted, string lastUpdated)
    {
        setLessonID(lessonID);
        setAccountID(accountID);
        setDateStarted(dateStarted);
        setLastUpdated(lastUpdated);
        //setLastUpdatedBy(lastUpdatedBy);

    }
    
    //SETTERS
    protected void setLessonID(int lessonID)
    {
        this.lessonID = lessonID;
    }
    protected void setAccountID(int accountID)
    {
        this.accountID = accountID;
    }
    protected void setDateStarted(string dateStarted)
    {
        this.dateStarted = dateStarted;
    }
    protected void setLastUpdated(string lastUpdated)
    {
        this.lastUpdated = lastUpdated;
    }
   


    //GETTERS
    public int getLessonID()
    {
        return this.lessonID;
    }
    public int getaccountID()
    {
        return this.lessonID;
    }
    public string getDateStarted()
    {
        return DateTime.Now.ToString();
    }
    public string getLastUpdated()
    {
        return DateTime.Now.ToString();
    }
    

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class Feedback
{
    private int accountID;
    private string message;
    private string lastUpdated;
    private string lastUpdatedBy;

    public Feedback(int accountID, string message, string lastUpdated, string lastUpdatedBy)
    {
        setAccountID(accountID);
        setMessage(message);
        setLastUpdated(lastUpdated);
        setLastUpdatedBy(lastUpdatedBy);
    }

    //Setters
    protected void setAccountID(int accountID)
    {
        this.accountID = accountID;
    }
    protected void setMessage(string message)
    {
        this.message = message;
    }
    protected void setLastUpdated(string lastUpdated)
    {
        this.lastUpdated = lastUpdated;
    }
    protected void setLastUpdatedBy(string lastUpdatedBy)
    {
        this.lastUpdatedBy = lastUpdatedBy;
    }

    //Getters
    public int getAccountID()
    {
        return this.accountID;
    }
    public string getMessage()
    {
        return this.message;
    }
    public string getLastUpdated()
    {
        return this.lastUpdated;
    }
    public string getLastUpdatedBy()
    {
        return this.lastUpdatedBy;
    }
}
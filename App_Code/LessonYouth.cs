using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for LessonYouth
/// </summary>
public class LessonYouth
{
    private int lessonID;
    private int youthID;
    private string dateBegin = DateTime.Now.ToString("yyyy-MM-dd");

    public LessonYouth(int lessonID, int youthID)
    {
        setLessonID(lessonID);
        setYouthID(youthID);
    }

    protected void setLessonID(int lessonID)
    {
        this.lessonID = lessonID;
    }

    protected void setYouthID(int youthID)
    {
        this.youthID = youthID;
    }

    public int getLessonID()
    {
        return this.lessonID;
    }

    public int getYouthID()
    {
        return this.youthID;
    }

    public string getBeginDate()
    {
        return this.dateBegin;
    }

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for LessonYouthWorker
/// </summary>
public class LessonYouthWorker
{
    private int lessonID;
    private int youthID;
    private string dateBegin = DateTime.Now.ToString("yyyy-MM-dd");

    public LessonYouthWorker(int lessonID, int youthID)
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
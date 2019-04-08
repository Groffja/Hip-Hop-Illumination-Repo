using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Lesson
/// </summary>
public class Lesson
{
    private int lessonID;
    private string lessonName;
    private string lessonDescription;
    private string lessonPDF;
    private string lessonType;
    private string lessonPicture;

    public Lesson(int lessonID, string lessonName, string lessonDescription, string lessonPDF, string lessonType, string lessonPicture)
    {
        setLessonID(lessonID);
        setLessonName(lessonName);
        setLessonDescription(lessonDescription);
        setLessonPDF(lessonPDF);
        setLessonType(lessonType);
        setLessonPicture(lessonPicture);
    }

    //SETTERS
    protected void setLessonID(int lessonID)
    {
        this.lessonID = lessonID;
    }
    protected void setLessonName(string lessonName)
    {
        this.lessonName = lessonName;
    }
    protected void setLessonDescription(string lessonDescription)
    {
        this.lessonDescription = lessonDescription;
    }
    protected void setLessonPDF(string lessonPDF)
    {
        this.lessonPDF = lessonPDF;
    }
    protected void setLessonType(string lessonType)
    {
        this.lessonType = lessonType;
    }
    protected void setLessonPicture(string lessonPicture)
    {
        this.lessonPicture = lessonPicture;
    }

    //GETTERS
    protected int getLessonID()
    {
        return this.lessonID;
    }
    protected string getLessonName()
    {
        return this.lessonName;
    }
    protected string getLessonDescription()
    {
        return this.lessonDescription;
    }
    protected string getLessonPDF()
    {
        return this.lessonPDF;
    }
    protected string getLessonType()
    {
        return this.lessonType;
    }
    protected string getLessonPicture()
    {
        return this.lessonPicture;
    }
}
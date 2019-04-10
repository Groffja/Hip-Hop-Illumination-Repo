using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections.Specialized;

public partial class _Default : System.Web.UI.Page
{
    String message2 = "";
    String message = "";
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void MessageButton_Click(object sender, EventArgs e)
    {

       
       
        message = Request.Form["messageTextArea"];

        int number = 9;



    }


}
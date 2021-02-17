using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsStaff
        clsStaff AnStaff = new clsStaff();
        //get dat from the session object
        AnStaff = (clsStaff) Session["AnStaff"];
        //display the data for the Address
        Response.Write(AnStaff.Address);
        //display the data for the availability
        Response.Write(AnStaff.Available);
        //display the data for the date of birth
        Response.Write(AnStaff.DoB);
        //display the data for the name
        Response.Write(AnStaff.Name);
        //display the data for the post code
        Response.Write(AnStaff.PostCode);
        //display the data for the staff id
        Response.Write(AnStaff.StaffId);
    }
}
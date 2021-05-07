using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class DeleteStaff : System.Web.UI.Page
{
    Int32 StaffId;

    //event handler for the load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be deleted from the session object
        StaffId = Convert.ToInt32(Session["StaffId"]);
    }

    protected void btnYesDelete_Click(object sender, EventArgs e)
    {
        //create a new instance fo the address book
        clsStaffCollection StaffBook = new clsStaffCollection();
        //find the record to delete
        StaffBook.ThisStaff.Find(StaffId);
        //delete the record
        StaffBook.Delete();
        //redirect back to the main page
        Response.Redirect("StaffList.aspx");
    }
}
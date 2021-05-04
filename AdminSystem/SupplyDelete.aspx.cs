using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Delete : System.Web.UI.Page
{
        //var to store the primary key value of the record to be deleted
        Int32 PhoneCaseId;

    //event handler for the load event 
    protected void Page_Load(object sender, EventArgs e)

    { 
        //get the number of the supply to be deleted from the session object 
        PhoneCaseId = Convert.ToInt32(Session["PhoneCaseId"]);

    }

    protected void BtnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the supply 
        clsSupplyCollection SupplyBook = new clsSupplyCollection();
        //find the record to delete 
        SupplyBook.ThisSupply.Find(PhoneCaseId);
        //delete the record 
        SupplyBook.Delete();
        //redirect back to the main page 
        Response.Redirect("SupplyList.aspx");
    }
}
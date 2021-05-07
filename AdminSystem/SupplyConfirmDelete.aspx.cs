using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Testing5;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //var to store the primary key value of the record to be deleted
    Int32 PhoneCaseID;

    //get the number of the address to be deleted from the session object 
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the customers to be deleted from the session object 
        PhoneCaseID = Convert.ToInt32(Session["PhoneCaseID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the customer 
        clsSupplyCollection Customer = new clsSupplyCollection();
        //find the record to delete
        Customer.ThisSupply.Find(PhoneCaseID);
        //delete the record
        Customer.Delete();
        //redirect back to the main page
        Response.Redirect("SupplyList.aspx");
    }
}
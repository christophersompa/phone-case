using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //var to store the primary key value of the record to be deleted
    Int32 CustomerNo;

    //get the number of the address to be deleted from the session object 
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the customers to be deleted from the session object 
        CustomerNo = Convert.ToInt32(Session["CustomerNo"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the customer 
        clsCustomerCollection Customer = new clsCustomerCollection();
        //find the record to delete
        Customer.ThisCustomer.Find(CustomerNo);
        //delete the record
        Customer.Delete();
        //redirect back to the main page
        Response.Redirect("CustomerList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerList.aspx");
    }
}
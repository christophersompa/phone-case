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
    Int32 OrderNo;

    //get the number of the address to be deleted from the session object 
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the customers to be deleted from the session object 
        OrderNo = Convert.ToInt32(Session["OrderNo"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the customer 
        clsOrderCollection Customer = new clsOrderCollection();
        //find the record to delete
        Order.ThisOrder.Find(OrderNo);
        //delete the record
        Order.Delete();
        //redirect back to the main page
        Response.Redirect("OrderList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrderList.aspx");
    }
}
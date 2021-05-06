using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class DeleteOrder : System.Web.UI.Page
{
    //var to store the primary key value of the record to be deleted
    Int32 OrderNo;

    //event handler for the load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the order to be deleted from the session object
        OrderNo = Convert.ToInt32(Session["OrderNo"]);

    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the order 
        clsOrderCollection Order = new clsOrderCollection();
        //find the record to delete
        Order.ThisOrder.Find(OrderNo);
        //delete the record
        Order.Delete();
        //redirect back to the main page
        Response.Redirect("OrderList.aspx");
    }
}
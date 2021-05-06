using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _Default : System.Web.UI.Page
{
    //this function handles the load event for the page
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayOrders();
        }

    }
    void DisplayOrders()
    {
        //create an instance of the TrackingNo Collection
        clsOrderCollection Orders = new clsOrderCollection();
        //set the data source to the list of TrackingNos in the collection
        lstOrdersList.DataSource = Orders.OrderList;
        //set the name of the primary key
        lstOrdersList.DataValueField = "OrderNo";
        //set the data field to display
        lstOrdersList.DataTextField = "TrackingNo";
        //bind the data to the list
        lstOrdersList.DataBind();
    }

    //event handler for the add button
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["OrderNo"] = -1;
        //redirect to the data entry page
        Response.Redirect("AnOrder.aspx");

    }
}
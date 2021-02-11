using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class OrderViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        //get the data from the session object
        AnOrder = (clsOrder)Session["AnOrder"];
        //display the customer name for this entry 
        Response.Write(AnOrder.CustomerName);
        //display the customer email for this entry
        Response.Write(AnOrder.CustomerEmail);
        //display the product code for this entry 
        Response.Write(AnOrder.ProductNo);
        //display the quantity
        Response.Write(AnOrder.Quantity);
        //display the total price
        Response.Write(AnOrder.TotalPrice);
        //display the order date 
        Response.Write(AnOrder.OrderDate);
        //display the tracking number 
        Response.Write(AnOrder.TrackingNo);
    }
}
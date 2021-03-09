using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        //capture the customer name
        AnOrder.CustomerName = txtCustomerName.Text;
        //capture the customer email
        AnOrder.CustomerEmail = txtCustomerEmail.Text;
        //capture the product code
        AnOrder.ProductNo = int.Parse(txtProductCode.Text);
        //capture the quantity
        AnOrder.Quantity = int.Parse(txtQuantity.Text);
        //capture the total price
        AnOrder.TotalPrice = int.Parse(txtTotalPrice.Text);
        //capture the order date
        AnOrder.OrderDate = DateTime.Parse(txtOrderDate.Text);
        //capture the tracking number
        AnOrder.TrackingNo = int.Parse(txtTrackingNo.Text);
        //store the order in the seesion object
        Session["AnOrder"] = AnOrder;
        //navigate to the viewer page
        Response.Redirect("OrderViewer.aspx");
    }


    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the address class 
        clsOrder AnOrder = new clsOrder();
        //variable to store the primary key
        Int32 OrderNo;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        OrderNo = Convert.ToInt32(txtOrderNo.Text);
        //find the record 
        Found = AnOrder.Find(OrderNo);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtOrderNo.Text = AnOrder.OrderNo.ToString();
            txtCustomerName.Text = AnOrder.CustomerName;
            txtCustomerEmail.Text = AnOrder.CustomerEmail;
            txtProductCode.Text = AnOrder.ProductNo.ToString();
            txtQuantity.Text = AnOrder.Quantity.ToString();
            txtTotalPrice.Text = AnOrder.TotalPrice.ToString();
            txtTrackingNo.Text = AnOrder.TrackingNo.ToString();
            txtOrderDate.Text = AnOrder.OrderDate.ToString();
        }
    }
}
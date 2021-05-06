﻿using System;
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
        //capture the order no
        string OrderNo = txtOrderNo.Text;
        //capture the customer name
        string CustomerName = txtCustomerName.Text;
        //capture the customer email
        string CustomerEmail = txtCustomerEmail.Text;
        //capture the product code
        string ProductNo = txtProductNo.Text;
        //capture the quantity
        string Quantity = txtQuantity.Text;
        //capture the total price
        string TotalPrice = txtTotalPrice.Text;
        //capture the order date
        string OrderDate = txtOrderDate.Text;
        //capture the tracking number
        string TrackingNo = txtTrackingNo.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data
       // Error = AnOrder.Valid(OrderNo, CustomerName, CustomerEmail, ProductNo, Quantity, TotalPrice, OrderDate, TrackingNo);
        if (Error == "")
        {
            //capture the customer name
            AnOrder.CustomerName = CustomerName;
            //capture the customer email
            AnOrder.CustomerEmail = CustomerEmail;
            //capture the product code
            AnOrder.ProductNo = Convert.ToInt32(ProductNo);
            //capture the quantity
            AnOrder.Quantity = Convert.ToInt32(Quantity);
            //capture the total price
            AnOrder.TotalPrice = Convert.ToInt32(TotalPrice);
            //capture the order date
            AnOrder.OrderDate = Convert.ToDateTime(OrderDate);
            //capture the tracking number
            AnOrder.TrackingNo = Convert.ToInt32(TrackingNo);
            //capture dispatched
            AnOrder.Dispatched = chkDispatched.Checked;
            //create a new instance of the order collection
            clsOrderCollection OrderList = new clsOrderCollection();
            //set the ThisOrder property
            OrderList.ThisOrder = AnOrder;
            //add the new record
            OrderList.Add();
            //redirect back to the listpage
            Response.Redirect("OrderList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
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
            txtProductNo.Text = AnOrder.ProductNo.ToString();
            txtQuantity.Text = AnOrder.Quantity.ToString();
            txtTotalPrice.Text = AnOrder.TotalPrice.ToString();
            txtTrackingNo.Text = AnOrder.TrackingNo.ToString();
            txtOrderDate.Text = AnOrder.OrderDate.ToString();
        }
    }
}
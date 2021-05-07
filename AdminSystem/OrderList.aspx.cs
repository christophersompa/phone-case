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
        //create an instance of the Order Collection
        clsOrderCollection Orders = new clsOrderCollection();
        //set the data source to the list of CustomerNames in the collection
        lstOrdersList.DataSource = Orders.OrderList;
        //set the name of the primary key
        lstOrdersList.DataValueField = "OrderNo";
        //set the data field to display
        lstOrdersList.DataTextField = "CustomerName";
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

  

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to edited
        Int32 OrderNo;

        //if a record has been selected from the list 
        if (lstOrdersList.SelectedIndex != -1)
        {
            // get the primary key value of the record to edit
            OrderNo = Convert.ToInt32(lstOrdersList.SelectedValue);
            //store the data in the session object  
            Session["OrderNo"] = OrderNo;
            //redirect to the edit page
            Response.Redirect("OrderDataEntry.aspx");
        }
        else //if no record has been selected 
        {
            //display error 
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 OrderNo;

        //if a record has been selected from the list 
        if (lstOrdersList.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            OrderNo = Convert.ToInt32(lstOrdersList.SelectedValue);
            //store the data in the session object
            Session["OrderNo"] = OrderNo;
            //redirect to the delete page
            Response.Redirect("DeleteOrder.aspx");
        }
        else //if no record has been selected
        {
            //display error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //create an instance of the order collection
        clsOrderCollection Orders = new clsOrderCollection();
        Orders.ReportByCustomerName(txtCustomerName.Text);
        lstOrdersList.DataSource = Orders.OrderList;
        //set the name of the primaey key 
        lstOrdersList.DataValueField = "OrderNo";
        //set the name of the field to display 
        lstOrdersList.DataTextField = "CustomerName";
        //bind the data to the list 
        lstOrdersList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        //create an instance of the order collection 
        clsOrderCollection Orders = new clsOrderCollection();
        Orders.ReportByCustomerName("");
        //clear any existing filter to tidy up the interface
        txtCustomerName.Text = "";
        lstOrdersList.DataSource = Orders.OrderList;
        //set the name of the primary kwy 
        lstOrdersList.DataValueField = "OrderNo";
        //set the name of the field to display 
        lstOrdersList.DataTextField = "CustomerEmail";
        //bind the data to the list
        lstOrdersList.DataBind();
    }
}
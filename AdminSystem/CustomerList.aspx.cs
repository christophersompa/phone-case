using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    //this function handles the load event for the page
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayCustomers();
        }
    }

    void DisplayCustomers()
    {
        //create an instance of the Collection 
        ClassLibrary.clsCustomerCollection Customers = new ClassLibrary.clsCustomerCollection();

        //set the data source to the list of customers in the collection
        lstCustomersList.DataSource = Customers.CustomerList;
        //set the name of the primary key 
        lstCustomersList.DataValueField = "CustomerNo";
        //set the data field to display 
        lstCustomersList.DataTextField = "FirstName";
        
        //bind the data to the date list
        lstCustomersList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store - 1 into the session object to indicate this is a new record
        Session["CustomerNo"] = -1;
        //redirect to the data entry page
        Response.Redirect("CustomerDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to edited
        Int32 CustomerNo;

        //if a record has been selected from the list 
        if (lstCustomersList.SelectedIndex != 1)
        {
            // get the primary key value of the record to edit
            CustomerNo = Convert.ToInt32(lstCustomersList.SelectedIndex);
            //store the data in the session object  
            Session["CustomerNo"] = CustomerNo;
            //redirect to the edit page
            Response.Redirect("CustomerDataEntry.aspx");
        }
        else //if no record has been selected 
        {
            //display error 
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 CustomerNo;

        //if a record has been selected from the list 
        if (lstCustomersList.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            CustomerNo = Convert.ToInt32(lstCustomersList.SelectedValue);
            //store the data in the session object
            Session["CustomerNo"] = CustomerNo;
            //redirect to the delete page
            Response.Redirect("CustomerConfirmDelete.aspx");
        }
        else //if no record has been selected
        {
            //display error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //create an instance of the customer collection
        clsCustomerCollection Customers = new clsCustomerCollection();
        Customers.ReportBySurname(txtbox_eSurname.Text);
        lstCustomersList.DataSource = Customers.CustomerList;
        //set the name of the primaey key 
        lstCustomersList.DataValueField = "CustomerNo";
        //set the name of the field to display 
        lstCustomersList.DataTextField = "Surname";
        //bind the data to the list 
        lstCustomersList.DataBind();

    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        //create an instance of the custmer collection 
        clsCustomerCollection Customers = new clsCustomerCollection();
        Customers.ReportBySurname("");
        //clear any existing filter to tidy up the interface
        txtbox_eSurname.Text = "";
        lstCustomersList.DataSource = Customers.CustomerList;
        //set the name of the primary kwy 
        lstCustomersList.DataTextFormatString = "CustomerNo";
        //set the name of the field to display 
        lstCustomersList.DataTextField = "Surname";
        //bind the data to the list
        lstCustomersList.DataBind();
    }
}
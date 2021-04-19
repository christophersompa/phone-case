using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 CustomerNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the numbger of the customer to be processed
        CustomerNo = Convert.ToInt32(Session["CustomerNo"]);
        if (IsPostBack == false)
        {
            //if this is not a new record 
            if (CustomerNo != 1)
            {
                //display the current data for the record 
                DisplayCustomer();
            }
        }
    }

    void DisplayCustomer()
    {
        //create an instance of the customer
        clsCustomerCollection Customer = new clsCustomerCollection();
        // find the record to update
        Customer.ThisCustomer.Find(CustomerNo);
        //display the data for this record
        txtCustomerNo.Text = Customer.ThisCustomer.CustomerNo.ToString();
        txtFirstName.Text = Customer.ThisCustomer.FirstName;
        txtSurname.Text = Customer.ThisCustomer.Surname;
        txtAddress.Text = Customer.ThisCustomer.Address;
        txtDateAdded.Text = Customer.ThisCustomer.DateAdded.ToString();
        chkOver18.Checked = Customer.ThisCustomer.Over18;
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer AnCustomer = new clsCustomer();
        //capture the first name
        string FirstName = txtFirstName.Text;
        //capture the surname
        string Surname = txtSurname.Text;   
        //capture the address
        string Address = txtAddress.Text;
        //capture the date of birth
        string DateAdded = txtDateAdded.Text;
        //variable to store any error messages
        string Error = "";

        //validate the data
        Error = AnCustomer.Valid(FirstName, Surname, Address, DateAdded);
        if (Error == "")
        {
            //caputure the customer no 
            AnCustomer.CustomerNo = CustomerNo;
            //capture the first name
            AnCustomer.FirstName = FirstName;
            //capture the surname
            AnCustomer.Surname = Surname;
            //capture the address
            AnCustomer.Address = Address;
            //capture the date of birth
            AnCustomer.DateAdded = Convert.ToDateTime(DateAdded);
            //capture active
            AnCustomer.Over18 = chkOver18.Checked;
            //create a new instance of the address collection 
            clsCustomerCollection CustomerList = new clsCustomerCollection();

            //if this is a new record i.e. CustomerNo = -1 then add the data 
            if (CustomerNo == -1)
            {

                //set the ThisCustomer property
                CustomerList.ThisCustomer = AnCustomer;
                //add the new record
                CustomerList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to updat e
                CustomerList.ThisCustomer.Find(CustomerNo);
                //set the ThisCustomer property
                CustomerList.ThisCustomer = AnCustomer;
                //update the record
                CustomerList.Update();
            }
            //redirect back to the listpage
            Response.Redirect("CustomerList.aspx");
        }

        else
        {
            //display the error message
            lblError.Text = Error;
        }

    }

    protected void txtCustomerNo_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the customer class
        clsCustomer AnCustomer = new clsCustomer();

        //variable to store the primary key
        Int32 CustomerNo;

        //variable to store the result of the find operation
        Boolean Found = false;

        //get the primary key entered by the user
        CustomerNo = Convert.ToInt32(txtCustomerNo.Text);

        //find record
        Found = AnCustomer.Find(CustomerNo);

        //if found
        if (Found == true)
        {
            //display the value of the properties in the form
            txtFirstName.Text = AnCustomer.FirstName;
            txtSurname.Text = AnCustomer.Surname;
            txtAddress.Text = AnCustomer.Address;
            txtDateAdded.Text = AnCustomer.DateAdded.ToShortDateString();
        }
    }

    protected void txtDateAdded_TextChanged(object sender, EventArgs e)
    {

    }
}

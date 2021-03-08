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
        //create a new instance of clsCustomer
        clsCustomer AnCustomer = new clsCustomer();     
        
        //capture the first name
        string FirstName = txtFirstName.Text;
        
        //capture the surname
        string Surname = txtSurname.Text;

        //capture the address
        string Address = txtAddress.Text;
        
        //capture the date of birth 
        string DateOfBirth = txtDateOfBirth.Text;

        //variable to store any error messages
        string Error = "";

        //validate the data
        Error = AnCustomer.Valid(FirstName, Surname, Address, DateOfBirth);
        if (Error == "")
        {
            //capture the first name
            AnCustomer.FirstName = FirstName;

            //capture the surname
            AnCustomer.Surname = Surname;

            //capture the address
            AnCustomer.Address = Address;

            //capture the date of birth
            AnCustomer.DateOfBirth = Convert.ToDateTime(DateOfBirth);
        
            //store the customer in the session object
            Session["AnCustomer"] = AnCustomer;
        
            //navigate to the viewer page
            Response.Redirect("CustomerViewer.aspx");
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
            txtDateOfBirth.Text = AnCustomer.DateOfBirth.ToString();
        }
    }
}
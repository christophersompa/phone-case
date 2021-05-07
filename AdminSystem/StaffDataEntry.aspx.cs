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
    Int32 StaffId;

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    void DisplayCustomer()
    {
        //create an instance of the customer
        clsStaffCollection Staff = new clsStaffCollection();
        // find the record to update
        Staff.ThisStaff.Find(StaffId);
        //display the data for this record
        txtStaffId.Text = Staff.ThisStaff.StaffId.ToString();
        txtAddress.Text = Staff.ThisStaff.Address;
        chkAvailable.Checked = Staff.ThisStaff.Available;
        txtDoB.Text = Staff.ThisStaff.DoB.ToString();
        txtName.Text = Staff.ThisStaff.Name;
        txtPostCode.Text = Staff.ThisStaff.PostCode;

    }
        protected void btnOk_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStaff
        clsStaff AnStaff = new clsStaff();
        //capture the address
        string Address = txtAddress.Text;
        //capture the date of birth
        string DoB = txtDoB.Text;
        //capture the name
        string Name = txtName.Text;
        //capture the post code
        string PostCode = txtPostCode.Text;
        //variable to store any error mesages
        string Error = "";
        //validate the data
        Error = AnStaff.Valid(Name, PostCode, Address, DoB);
        if (Error == "")
        {
            //capture the staff ID
            AnStaff.StaffId = StaffId;
            //capture the Name
            AnStaff.Name = Name;
            //capture the Post Code
            AnStaff.PostCode = PostCode;
            //capture the Address
            AnStaff.Address = Address;
            //capture the Date of Birth
            AnStaff.DoB = Convert.ToDateTime(txtDoB.Text);
            //capture available
            AnStaff.Available = chkAvailable.Checked;
            //create a new instance fo the address collection
            clsStaffCollection StaffList = new clsStaffCollection();
            //if this is a new record i.e. StaffId = -1 then add the data
            if (StaffId == -1)
            {
                //set the ThisStaff property
                StaffList.ThisStaff = AnStaff;
                //add the new record
                StaffList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                StaffList.ThisStaff.Find(StaffId);
                //set the ThisStaff property
                StaffList.ThisStaff = AnStaff;
                //update the record
                StaffList.Update();
            }
            //redirect back to the listpage
            Response.Redirect("StaffList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }



    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the address class
        clsStaff AnStaff = new clsStaff();
        //variable to store the primary key 
        Int32 StaffId;
        //varibale to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        StaffId = Convert.ToInt32(txtStaffId.Text);
        //find the record
        Found = AnStaff.Find(StaffId);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtName.Text = AnStaff.Name;
            txtAddress.Text = AnStaff.Address;
            txtPostCode.Text = AnStaff.PostCode;
            txtDoB.Text = AnStaff.DoB.ToString();
        }
        //
    }
}
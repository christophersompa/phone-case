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

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStaff
        clsStaff AnStaff = new clsStaff();
        //capture the address
        AnStaff.Address = txtAddress.Text;
        //capture the availability
        AnStaff.Available = chkAvailable.AutoPostBack;
        //capture the date of birth
        AnStaff.DoB = DateTime.Parse(txtDoB.Text);
        //capture the name
        AnStaff.Name = txtName.Text;
        //capture the post code
        AnStaff.PostCode = txtPostCode.Text;
        //capture the staff id
        AnStaff.StaffId = int.Parse(txtStaffId.Text);
        //store the data in the session object
        Session["AnStaff"] = AnStaff;
        //navigate to the viewer page
        Response.Redirect("StaffViewer.aspx");
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
    }
}
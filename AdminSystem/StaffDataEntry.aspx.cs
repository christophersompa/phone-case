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
}
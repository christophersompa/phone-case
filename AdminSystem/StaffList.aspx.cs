using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    //var to store the primary key
    Int32 StaffId;

    //this function handles the load event for the page
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the staff members to be process
        StaffId = Convert.ToInt32(Session["StaffId"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (StaffId != -1)
            {
                //display the current data for the record
                DisplayStaff();
            }
        }
    }
    void DisplayStaff()
    {
        //create an instance fo the Staff Collection
        clsStaffCollection Staff = new clsStaffCollection();
        //set the data source to the list of staff in the collection
        lstStaffList.DataSource = Staff.StaffList;
        //set the name of the primary key
        lstStaffList.DataValueField = "StaffId";
        //set the data field to display
        lstStaffList.DataTextField = "PostCode";
        //bind the data to the list
        lstStaffList.DataBind(); 
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["StaffId"] = -1;
        //redirect to the data entry page
        Response.Redirect("AnStaff.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 StaffId;
        //if a record has been selected from the list
        if (lstStaffList.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            StaffId = Convert.ToInt32(lstStaffList.SelectedValue);
            //store the data in the session object
            Session["StaffId"] = StaffId;
            //redirect to the delete page
            Response.Redirect("DeleteStaff.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 StaffId;
        //if a record has been selected from the list
        if (lstStaffList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            StaffId = Convert.ToInt32(lstStaffList.SelectedValue);
            //store the dat in the session object
            Session["StaffId"] = StaffId;
            //redirect to the edit page
            Response.Redirect("AnStaff.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to del";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //create an instance of the address collection
        clsStaffCollection Staff = new clsStaffCollection();
        Staff.ReportByName(txtFilter.Text);
        lstStaffList.DataSource = Staff.StaffList;
        //set the name of the primary key
        lstStaffList.DataValueField = "StaffId";
        //set the name of the field to display
        lstStaffList.DataTextField = "Name";
        //bind the data to the list
        lstStaffList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        //create an instance of the staff collection
        clsStaffCollection Staff = new clsStaffCollection();
        Staff.ReportByName("");
    }
}
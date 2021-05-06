using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_List : System.Web.UI.Page
{
    //this function handles the load event for the page 
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed 
        if (IsPostBack == false)
        {
            //update the list box
            DisplaySupply();
        }
    }

    void DisplaySupply()
    {
        //create an instance of the collection 
        clsSupplyCollection Suppliers = new clsSupplyCollection();
        //set the data source to the list of **** in the collection
        lstSupplyList.DataSource = Suppliers.SupplyList;
        //set the name of the primary key 
        lstSupplyList.DataValueField = "PhoneCaseID";
        //set the data field to display 
        lstSupplyList.DataTextField = "PhoneModel";
        //bind the data to the list
        lstSupplyList.DataBind();
    }

    protected void BtnEdit_Click(object sender, EventArgs e)
    {
        //var to store teh primary key value of the record to be edited 
        Int32 PhoneCaseId;
        //if a record has been selected from this list 
        if (lstSupplyList.SelectedIndex != -1)
        {
            //get the primary value of the record to edit 
            PhoneCaseId = Convert.ToInt32(lstSupplyList.SelectedValue);
            //store the data in the session object 
            Session["PhoneCaseId"] = PhoneCaseId;
            //redirect to the edit page 
            Response.Redirect("AnSupply.aspx");

        }
        else //if no record has been selected 
        {
            //display an error 
            lblError.Text = "Please select a record to delete from the list";
        }
    }



    protected void BtnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record 
        Session["PhoneCaseId"] = -1;
        //redirect to the data entry page 
        Response.Redirect("SupplyDataEntry.aspx");
    }

    protected void BtnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deletd 
        Int32 PhoneCaseId;
        //if a record has been selected from the list 
        if (lstSupplyList.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete 
            PhoneCaseId = Convert.ToInt32(lstSupplyList.SelectedValue);
            //store the data in the session object 
            Session["PhoneCaseId"] = PhoneCaseId;
            //redirect to the delet page 
            Response.Redirect("SupplyDelete.aspx");

        }
        else //if no record has been selected 
        {
            //display an error 
            lblError.Text = "Please select a record to delete drom the list";
        }
    }

    protected void ApplyBtn_Click(object sender, EventArgs e)
    {
        //create an instance of the address collection 
        clsSupplyCollection Supplies = new clsSupplyCollection();
        Supplies.ReportBySupplierName(txtFilter.Text);
        lstSupplyList.DataSource = Supplies.SupplyList;
        //set the name of the primary 
        lstSupplyList.DataValueField = "PhoneCaseId";
        //set the name of the field to display 
        lstSupplyList.DataTextField = "SupplierName";
        //bind the data to the list 
        lstSupplyList.DataBind();
    }



    protected void ClearBtn_Click(object sender, EventArgs e)
    {
        //create an instance of the address collection
        clsSupplyCollection Supplies = new clsSupplyCollection();
        Supplies.ReportBySupplierName("");
        //clear any existing filter to tidy up the interface 
        txtFilter.Text = "";
        lstSupplyList.DataSource = Supplies.SupplyList;
        //set the name of the primary key 
        lstSupplyList.DataValueField = "PhoneCaseId";
        //set the name of the field to display 
        lstSupplyList.DataTextField = "SupplierName";
        //bind the data to the list 
        lstSupplyList.DataBind();
    }
}
   



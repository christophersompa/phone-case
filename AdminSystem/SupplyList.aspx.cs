using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;
using Testing5;

public partial class _1_List : System.Web.UI.Page
{
 
    //this function handles the load event for the page 
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed 
        if (IsPostBack == false)
        {
            //update the list box 
            DisplaySuppliers();
        }
    }

    void DisplaySuppliers()
    {
        //create an instance of the Supply Collection
        clsSupplyCollection Suppliers = new clsSupplyCollection();
        //set the data source to the list of suppliers in the collection 
        lstSupplierList.DataSource = Suppliers.SupplierList;
        //set the name of the primary key 
        lstSupplierList.DataValueField = "PhoneCaseId";
        //set the data field to display 
        lstSupplierList.DataTextField = "SupplierName";
        //bind the data to the list  
        lstSupplierList.DataBind();


    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store - 1 into the session object to indicate this is a new record
        Session["PhoneCaseID"] = -1;
        //redirect to the data entry page
        Response.Redirect("SupplyDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to edited
        Int32 PhoneCaseID;

        //if a record has been selected from the list 
        if (lstSupplierList.SelectedIndex != 1)
        {
            // get the primary key value of the record to edit
            PhoneCaseID = Convert.ToInt32(lstSupplierList.SelectedIndex);
            //store the data in the session object  
            Session["PhoneCaseID"] = PhoneCaseID;
            //redirect to the edit page
            Response.Redirect("SupplyDataEntry.aspx");
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
        Int32 PhoneCaseID;

        //if a record has been selected from the list 
        if (lstSupplierList.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            PhoneCaseID = Convert.ToInt32(lstSupplierList.SelectedValue);
            //store the data in the session object
            Session["PhoneCaseID"] = PhoneCaseID;
            //redirect to the delete page
            Response.Redirect("SupplyConfirmDelete.aspx");
        }
        else //if no record has been selected
        {
            //display error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //create an instance of the supply collection
        clsSupplyCollection Suppliers = new clsSupplyCollection();
        Suppliers.ReportBySupplierName(txtbox_eSupplierName.Text);
        lstSupplierList.DataSource = Suppliers.SupplierList;
        //set the name of the primaey key 
        lstSupplierList.DataValueField = "PhoneCaseID";
        //set the name of the field to display 
        lstSupplierList.DataTextField = "SupplierName";
        //bind the data to the list 
        lstSupplierList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        //create an instance of the supply collection 
        clsSupplyCollection Suppliers = new clsSupplyCollection();
        Suppliers.ReportBySupplierName("");
        //clear any existing filter to tidy up the interface
        txtbox_eSupplierName.Text = "";
        lstSupplierList.DataSource = Suppliers.SupplierList;
        //set the name of the primary kwy 
        lstSupplierList.DataTextFormatString = "PhoneCaseID";
        //set the name of the field to display 
        lstSupplierList.DataTextField = "SupplierName";
        //bind the data to the list
        lstSupplierList.DataBind();
    }







    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox_TextChanged(object sender, EventArgs e)
    {

    }
}
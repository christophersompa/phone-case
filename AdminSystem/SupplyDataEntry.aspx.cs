using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsSupply
        clsSupply AnSupply = new clsSupply();
        //capture the Phone Model 
        string PhoneModel = txtPhoneModel.Text;
        //capture the Supplier Name
        string SupplierName = txtSupplierName.Text;
        //capture Date Ordered 
        string DateOrdered = txtDateOrdered.Text;
        //capture Price 
        string Price = txtPrice.Text;
        //variable to store error message 
        string Error = "";
        //validate the data 
        Error = AnSupply.Valid(PhoneModel, DateOrdered, SupplierName, Price);
        if (Error == "")
        {
            //capture the Phone Model
            AnSupply.PhoneModel = PhoneModel;
            //capture the Supplier Name
            AnSupply.SupplierName = SupplierName;
            //capture the Date Ordered
            AnSupply.DateOrdered = Convert.ToDateTime(DateOrdered);
            //capture the Price
            AnSupply.Price = Convert.ToDecimal(Price);
            //store the address in the session object 
            Session["AnSupply"] = AnSupply;
            //redirect to the viewer page 
            Response.Write("SupplyViewer.aspx");
        }
        else
        {
            //display the error message 
            lblError.Text = Error; 
        }
       
    }



    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the supply class
        clsSupply AnSupply = new clsSupply();
        //variable to store the primary key 
        Int32 PhoneCaseId;
        //variable to store the result of the find operation 
        Boolean Found = false;
        //get the primary key entered by the user 
        PhoneCaseId = Convert.ToInt32(txtPhoneCaseId.Text);
        //find the record 
        Found = AnSupply.Find(PhoneCaseId);
        //if found 
        if (Found == true)
        {
            //display the values of the property in the form 
            txtPhoneModel.Text = AnSupply.PhoneModel;
            txtDateOrdered.Text =AnSupply.DateOrdered.ToString();
            txtSupplierName.Text = AnSupply.SupplierName;
            txtPrice.Text = AnSupply.Price.ToString();
           

           
           


        }
    }
}
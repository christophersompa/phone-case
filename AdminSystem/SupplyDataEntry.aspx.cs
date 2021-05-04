using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    
        //variable to store the primary key with page level scope 
        Int32 PhoneCaseId;
    void Page_Load(object sender, EventArgs e)
    {
        //get number of the phone case to be processed 
        PhoneCaseId = Convert.ToInt32(Session["PhoneCaseId"]);
        if (IsPostBack == false)
        {
            //if this is not a new record 
            if (PhoneCaseId != -1)
            {
                //display the current data for the record 
                DisplaySupply();
            }
        }
   

            void DisplaySupply()
            {
                //create an isntance of the address book 
                clsSupplyCollection SupplyList = new clsSupplyCollection();
                //find the record to update
                SupplyList.ThisSupply.Find(PhoneCaseId);
                //display the data for this record
                txtPhoneCaseId.Text = SupplyList.ThisSupply.PhoneCaseId.ToString();
                txtPhoneModel.Text = SupplyList.ThisSupply.PhoneModel;
                txtSupplierName.Text = SupplyList.ThisSupply.SupplierName;
                txtPrice.Text = SupplyList.ThisSupply.Price.ToString();
                txtDateOrdered.Text = SupplyList.ThisSupply.DateOrdered.ToString();
                chkAvaliableStock.Checked = SupplyList.ThisSupply.AvaliableStock;



            }

        }

         void BtnOK_Click(object sender, EventArgs e)
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
                //capture avalible stock
                AnSupply.AvaliableStock = chkAvaliableStock.Checked;
                //create a new instance of the supply collection 
                clsSupplyCollection SupplyList = new clsSupplyCollection();

                //if this is a new record i.e. PhoneCaseId -1 then add the data 
                if (PhoneCaseId == -1)
                {
                    //set the ThisSupply case
                    SupplyList.ThisSupply = AnSupply;
                    //add the new record 
                    SupplyList.Add();
                }

                //otherwise it must be an update 
                else
                {
                    //find the record to update 
                    SupplyList.ThisSupply.Find(PhoneCaseId);
                    //set the ThisSupply case 
                    SupplyList.ThisSupply = AnSupply;
                    //update the record 
                    SupplyList.Update();

                }
                //redirect back to the listpage 
                Response.Redirect("SupplyList.aspx");
            }
            else
            {
                //display the error message 
                lblError.Text = Error;
            }

        }



         void BtnFind_Click(object sender, EventArgs e)
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
                txtDateOrdered.Text = AnSupply.DateOrdered.ToString();
                txtSupplierName.Text = AnSupply.SupplierName;
                txtPrice.Text = AnSupply.Price.ToString();






            }
        }


    }

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
        //create a new instance of clsProduct
        clsProduct AnProduct = new clsProduct();
        //capture the product ID
        AnProduct.ProductId = int.Parse(txtProductId.Text);
        //Store the Product ID in the session object
        Session["AnProduct"] = AnProduct;
        //Navigate to the viewer page
        Response.Redirect("ProductViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the address class
        clsProduct AnProduct = new clsProduct();
        //variable to store the primary key
        Int32 ProductId;
        //variable to store the result of the find operation
        Boolean Found=false;
        //get the primary key entered by the user
        ProductId = Convert.ToInt32(txtProductId.Text);
        //find the record
        Found = AnProduct.Find(ProductId);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtProductName.Text = AnProduct.ProductName;
            txtSmartphoneBrand.Text = AnProduct.SmartPhoneBrand;
            txtSmartphoneModel.Text = AnProduct.SmartPhoneModel;
        }
    }
}
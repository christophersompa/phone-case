﻿using System;
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
}
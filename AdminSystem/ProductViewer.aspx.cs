﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsProduct
        clsProduct AnProduct = new clsProduct();
        //get the data from the session object
        AnProduct = (clsProduct)Session["AnProduct"];
        //display the Product ID for this entry
        Response.Write(AnProduct.ProductId);
    }
}
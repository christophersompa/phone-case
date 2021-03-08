using System;
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
        //create a new instance of clsSupply
        clsSupply AnSupply = new clsSupply();
        //get the data from the session object 
        AnSupply = (clsSupply)Session["AnSupply"];
        //display the Phone Case Id for this entry 
        Response.Write(AnSupply.PhoneModel);
        Response.Write(AnSupply.DateOrdered);
        Response.Write(AnSupply.SupplierName);
        Response.Write(AnSupply.Price);

    }
}
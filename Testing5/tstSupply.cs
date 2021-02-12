using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing5
{
    [TestClass]
    public class tstSupply
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsSupply AnSupply = new clsSupply();
            //test to see that it exists 
            Assert.IsNotNull(AnSupply);
        }
    }
}

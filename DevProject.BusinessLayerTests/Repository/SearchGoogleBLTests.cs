using Microsoft.VisualStudio.TestTools.UnitTesting;
using DevProject.BusinessLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevProject.BusinessLayer.Repository.Tests
{
    [TestClass()]
    public class SearchGoogleBLTests
    {
        [TestMethod()]
        public void GetHtmlDocumentTest()
        {
            SearchGoogleBL search = new SearchGoogleBL();
            string expected = "46,47";
            string actual = search.GetHtmlDocument("conveyancing software", "www.smokeball.com.au");
            Assert.AreEqual<string>(expected, actual);
        }
    }
}
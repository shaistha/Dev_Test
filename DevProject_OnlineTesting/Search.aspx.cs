using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevProject.BusinessLayer.Repository;

namespace DevProject_OnlineTesting
{
    public partial class Search : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            ISearchGoogleBL repository = new SearchGoogleBL();
            string keys = repository.GetHtmlDocument(txtKeyword.Text, txtUrl.Text);
            result.InnerText = keys;
        }
    }
}
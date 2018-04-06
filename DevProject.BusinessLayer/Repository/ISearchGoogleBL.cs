using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevProject.BusinessLayer.Repository
{
    public interface ISearchGoogleBL
    {
        string GetHtmlDocument(string keyword, string url);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevProject.DataAccessLayer.Repository
{
    public interface ISearchGoogle
    {
        string GetHtmlDocument(string keyword, string url);
    }
}

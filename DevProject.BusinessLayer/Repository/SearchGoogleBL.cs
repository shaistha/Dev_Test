using System.Collections.Generic;
using DevProject.DataAccessLayer.Repository;
using HtmlAgilityPack;
using DevProject.BusinessLayer.Utilities;

namespace DevProject.BusinessLayer.Repository
{
    public class SearchGoogleBL : ISearchGoogleBL
    {
        private ISearchGoogle dataRepo;
       
        public SearchGoogleBL()
        {
            dataRepo = new SearchGoogle();
        }
        public string GetHtmlDocument(string keyword, string url)
        {
            int count = 1;
            Dictionary<int, string> myDictionary = new Dictionary<int, string>();

            string htmlCOntent = dataRepo.GetHtmlDocument(keyword, url);
            List<LinkItem> items = FindLinks.LinkFinder(htmlCOntent);
            foreach (var i in items)
            {
                if (i.href.Contains(url))
                {
                    myDictionary.Add(count, i.href);
                }
                count++;
            }

            string keys = string.Format("{0}", string.Join(",", myDictionary.Keys));
            return keys;


            //HtmlWeb web = new HtmlWeb();
            //HtmlDocument doc = web.Load("https://www.google.com.au/search?num=100&q=conveyance+software");

            //var linksOnPage = from links in doc.DocumentNode.Descendants()
            //                  where links.Name == "a" &&
            //                  links.Attributes["href"] != null &&
            //                  links.InnerText.Trim().Length > 0
            //                  select new
            //                  {
            //                      Url = links.Attributes["href"].Value,
            //                      Text = links.InnerText
            //                  };
            //foreach (var i in linksOnPage)
            //{
            //    if (i.Url.Contains(url))
            //    {
            //        myDictionary.Add(count, i.Url);
            //    }
            //    count++;
            //}

            //string keys = string.Format("{0}", string.Join(",", myDictionary.Keys));
            //return keys;

        }
    }
}

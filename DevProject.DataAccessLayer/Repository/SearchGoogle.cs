using System;
using System.IO;
using System.Net;

namespace DevProject.DataAccessLayer.Repository
{
    public class SearchGoogle : ISearchGoogle
    {
        private const string googleUrl = "https://www.google.com.au/search?num=100&q=";
        public string GetHtmlDocument(string keyword, string url)
        {
            string search = googleUrl + keyword.Trim();
            string html = string.Empty;
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(search);
                request.KeepAlive = false;
                request.AutomaticDecompression = DecompressionMethods.GZip;
                request.Credentials = CredentialCache.DefaultCredentials;
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    Stream stream = response.GetResponseStream();
                    StreamReader reader = new StreamReader(stream, System.Text.Encoding.UTF8);
                    html = reader.ReadToEnd();
                }
                return html;
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}

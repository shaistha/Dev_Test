using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DevProject.BusinessLayer.Utilities
{
    public class FindLinks
    {
        public static List<LinkItem> LinkFinder(string htmlContent)
        {
            List<LinkItem> list = new List<LinkItem>();
            MatchCollection matchCollection = Regex.Matches(htmlContent, @"(<a.*?>.*?</a>)", RegexOptions.IgnorePatternWhitespace);
            foreach (Match collect in matchCollection)
            {
                string value = collect.Groups[1].Value;
                LinkItem link = new LinkItem();
                Match match = Regex.Match(value, @"href=\""(.*?)\""", RegexOptions.IgnorePatternWhitespace);
                if (match.Success)
                {
                    link.href = match.Groups[1].Value;
                }
                string t = Regex.Replace(value, @"\s*<.*?>\s*", "", RegexOptions.IgnorePatternWhitespace);
                link.Text = t;
                list.Add(link);
            }
            return list;
        }
    }


    public struct LinkItem
    {
        public string href;
        public string Text;
        public override string ToString()
        {
            return href + "\n\t" + Text;
        }
    }
}

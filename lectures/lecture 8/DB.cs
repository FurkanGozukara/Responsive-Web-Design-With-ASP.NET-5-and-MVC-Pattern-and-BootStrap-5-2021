using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lecture_6
{
    public static class DB
    {
        private static Dictionary<Tuple<string,string>, string> dicArticles;
        static DB()
        {
            dicArticles = new Dictionary<Tuple<string, string>, string>();
            dicArticles.Add(new Tuple<string, string>("routing", "routing-templates"), "article.cshtml");
            dicArticles.Add(new Tuple<string, string>("routing", "routing-v2"), "routing.cshtml");
            dicArticles.Add(new Tuple<string, string>("routing", "routing/v2"), "routing.cshtml");

            dicArticles.Add(new Tuple<string, string>("routing", null), "routing.cshtml");
        }
        
        public static string returnContent(string srKey1, string srKey2)
        {
            Tuple<string, string> vrKey = new Tuple<string, string>(srKey1, srKey2);
            if (dicArticles.ContainsKey(vrKey))
                return dicArticles[vrKey];
            else
                return null;
        }
    }
}

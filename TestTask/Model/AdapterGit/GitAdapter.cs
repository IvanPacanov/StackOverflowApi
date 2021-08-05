using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestTask.Model.AdapterGit
{
    public abstract class GitAdapter
    {
        protected HttpClient client;
        private string url = "https://api.stackexchange.com/";

        protected GitAdapter()
        {
            FindVersion();
            this.client = new HttpClient();

            client.BaseAddress = new Uri(url);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json; charset=utf-8");   
        }

        private void FindVersion()
        {
            using WebClient web1 = new WebClient();            

            string pattern = @"\bv\d{1}.\d{1}";
            Regex r = new Regex(pattern);
            Match m = r.Match(web1.DownloadString(url));
            if (m.Success)
            {
                url += m.Value.Remove(0,1) +"/";
            } 
            else
            {
                url +=  "2.3/";
            }
        }
    }
}

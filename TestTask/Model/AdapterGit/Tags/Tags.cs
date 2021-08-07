using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TestTask.Entities.GitTag;

namespace TestTask.Model.AdapterGit.Tags
{
    public class Tags : GitAdapter
    {



        private int page = 1;
        
        ConfigureToSearch Configure = new ConfigureToSearch()
        { order = "desc", size = 100, sort = "popular" };

        public Tags() : base()
        {

        }    
     

        public async Task<IEnumerable<ElementToReturn>> GetResponse(ConfigureToSearch configure = null)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            List<ElementToReturn> returnList = new List<ElementToReturn>();

            configure = configure != null ? 
            ((configure.order != "desc" || configure.sort != "popular") ? 
            Configure : configure) : Configure;

            GetResponseFromAPI(ref response, configure); 

            if (response != null && response.IsSuccessStatusCode)
               await GetDataFromAPI(response, returnList, configure);
            else
                GetRawData(returnList);
            return (await Task.FromResult(returnList));
        }

        private void GetResponseFromAPI(ref HttpResponseMessage response, ConfigureToSearch configure)
        {
            try
            {
                response = client.GetAsync($"tags?page={page++}&pagesize={configure.size}&order={configure.order}&sort={configure.sort}&site=stackoverflow").Result;
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private async Task GetDataFromAPI(HttpResponseMessage response, List<ElementToReturn> el, ConfigureToSearch configure)
        {
            do
            {
                Stream streamGZIP = await response.Content.ReadAsStreamAsync();
                using Stream stream = new GZipStream(streamGZIP, CompressionMode.Decompress);
                using MemoryStream ms = new MemoryStream();

                stream.CopyTo(ms);
                Change(JsonConvert.DeserializeObject<Root>(Encoding.Default.GetString(ms.ToArray())), ref el);
                string c = Encoding.Default.GetString(ms.ToArray());

                GetResponseFromAPI(ref response, configure);
            }
            while (el.Count < 1000);
        } 
        
        private void GetRawData(List<ElementToReturn> el)
        {            
            for (int i = 0; i < 10; i++)
            {
                Change(((i % 2 == 0) ? ExampleData.root1 : ExampleData.root2), ref el, true);
            }
        }

     
        private void Change(Root root, ref List<ElementToReturn> el, bool isError = false)
        {         
                          
                double sum = root.items.Sum(x => x.count);
                el.AddRange(root.items.Select(tagStackOverflow =>
                {
                    return new ElementToReturn
                    {
                        nameTag = tagStackOverflow.name,
                        popular = tagStackOverflow.count,
                        popularPercent = Math.Round((tagStackOverflow.count / sum) * 100, 2),
                        IsError = isError
                    };
                }));
           
        }


       
    }

}
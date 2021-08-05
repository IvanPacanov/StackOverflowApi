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



        private string order = "desc";
        private string sort = "popular";
        private int page = 1;
        private int pageSize = 100;

        public Tags() : base()
        {

        }
        public async Task<IEnumerable<ElementToReturn>> GetTags()
        {
            List<ElementToReturn> el = new List<ElementToReturn>();

            for (int i = 0; i < 10; i++)
            {
                Root root = (i % 2 == 0) ? await Get1000TagsAsync() : await Get1000TagsAsync1();
                double sum = root.items.Sum(x => x.count);
                el.AddRange(root.items.Select(i =>
                {
                    return new ElementToReturn
                    {
                        nameTag = i.name,
                        popular = i.count,
                        popularPercent = Math.Round((i.count / sum) * 100, 2)
                    };
                }));
            }

            return el;
        }

        internal Task<IEnumerable<ElementToReturn>> GetTagsBySize(int size)
        {
            pageSize = size;
            return null;
        }

        private async Task<Root> GetTagsAsync()
        {
            //HttpResponseMessage response = await client.GetAsync($"tags?page={page}&pagesize={pageSize}&order={order}&sort={sort}&site=stackoverflow");
            //if (response.IsSuccessStatusCode)
            //{
            //    Stream streamGZIP = await response.Content.ReadAsStreamAsync();
            //    using Stream stream = new GZipStream(streamGZIP, CompressionMode.Decompress);
            //    using MemoryStream ms = new MemoryStream();
            //    stream.CopyTo(ms);
            //    string jsonFromStream = Encoding.Default.GetString(ms.ToArray());
            //    return JsonConvert.DeserializeObject<Root>(jsonFromStream);
            //}
            //else
            //{
            //    string test = "{\"items\":[{\"has_synonyms\":true,\"is_moderator_only\":false,\"is_required\":false,\"count\":2251695,\"name\":\"javascript\"},{\"has_synonyms\":true,\"is_moderator_only\":false,\"is_required\":false,\"count\":1790917,\"name\":\"java\"},{\"has_synonyms\":true,\"is_moderator_only\":false,\"is_required\":false,\"count\":1770300,\"name\":\"python\"},{\"collectives\":[{\"tags\":[\"audio\",\"c#\"],\"external_links\":[{\"type\":\"website\",\"link\":\"https:\/\/example.com\"},{\"type\":\"support\",\"link\":\"mailto:support@example.com\"},{\"type\":\"twitter\",\"link\":\"https:\/\/twitter.com\/stackoverflow\"},{\"type\":\"github\",\"link\":\"https:\/\/github.com\/stackoverflow\"},{\"type\":\"facebook\",\"link\":\"https:\/\/facebook.com\/stackoverflow\"},{\"type\":\"instagram\",\"link\":\"https:\/\/instagram.com\/stackoverflow\"}],\"description\":\"Official Q&A support for AudioBubble\",\"link\":\"\/collectives\/audiobubble\",\"name\":\"AudioBubble\",\"slug\":\"audiobubble\"}],\"has_synonyms\":true,\"is_moderator_only\":false,\"is_required\":false,\"count\":1491251,\"name\":\"c#\"},{\"has_synonyms\":true,\"is_moderator_only\":false,\"is_required\":false,\"count\":1410620,\"name\":\"php\"},{\"has_synonyms\":true,\"is_moderator_only\":false,\"is_required\":false,\"count\":1343693,\"name\":\"android\"},{\"has_synonyms\":true,\"is_moderator_only\":false,\"is_required\":false,\"count\":1083691,\"name\":\"html\"},{\"has_synonyms\":true,\"is_moderator_only\":false,\"is_required\":false,\"count\":1015576,\"name\":\"jquery\"},{\"has_synonyms\":true,\"is_moderator_only\":false,\"is_required\":false,\"count\":733239,\"name\":\"c++\"},{\"has_synonyms\":true,\"is_moderator_only\":false,\"is_required\":false,\"count\":726916,\"name\":\"css\"},{\"has_synonyms\":true,\"is_moderator_only\":false,\"is_required\":false,\"count\":659173,\"name\":\"ios\"},{\"has_synonyms\":true,\"is_moderator_only\":false,\"is_required\":false,\"count\":629436,\"name\":\"mysql\"},{\"has_synonyms\":true,\"is_moderator_only\":false,\"is_required\":false,\"count\":599648,\"name\":\"sql\"},{\"has_synonyms\":true,\"is_moderator_only\":false,\"is_required\":false,\"count\":413472,\"name\":\"r\"},{\"has_synonyms\":true,\"is_moderator_only\":false,\"is_required\":false,\"count\":396720,\"name\":\"node.js\"},{\"has_synonyms\":true,\"is_moderator_only\":false,\"is_required\":false,\"count\":369355,\"name\":\"arrays\"},{\"has_synonyms\":true,\"is_moderator_only\":false,\"is_required\":false,\"count\":363967,\"name\":\"asp.net\"},{\"has_synonyms\":false,\"is_moderator_only\":false,\"is_required\":false,\"count\":362649,\"name\":\"c\"},{\"has_synonyms\":true,\"is_moderator_only\":false,\"is_required\":false,\"count\":327425,\"name\":\"ruby-on-rails\"},{\"has_synonyms\":true,\"is_moderator_only\":false,\"is_required\":false,\"count\":323150,\"name\":\"json\"},{\"has_synonyms\":true,\"is_moderator_only\":false,\"is_required\":false,\"count\":322017,\"name\":\"reactjs\"},{\"has_synonyms\":true,\"is_moderator_only\":false,\"is_required\":false,\"count\":309992,\"name\":\".net\"},{\"has_synonyms\":true,\"is_moderator_only\":false,\"is_required\":false,\"count\":307226,\"name\":\"sql-server\"},{\"has_synonyms\":true,\"is_moderator_only\":false,\"is_required\":false,\"count\":299960,\"name\":\"swift\"},{\"has_synonyms\":true,\"is_moderator_only\":false,\"is_required\":false,\"count\":291869,\"name\":\"objective-c\"},{\"has_synonyms\":true,\"is_moderator_only\":false,\"is_required\":false,\"count\":291134,\"name\":\"python-3.x\"},{\"has_synonyms\":false,\"is_moderator_only\":false,\"is_required\":false,\"count\":272036,\"name\":\"django\"},{\"has_synonyms\":true,\"is_moderator_only\":false,\"is_required\":false,\"count\":262239,\"name\":\"angularjs\"},{\"has_synonyms\":true,\"is_moderator_only\":false,\"is_required\":false,\"count\":258716,\"name\":\"angular\"},{\"has_synonyms\":true,\"is_moderator_only\":false,\"is_required\":false,\"count\":249431,\"name\":\"excel\"}],\"has_more\":true,\"quota_max\":10000,\"quota_remaining\":9974}";
            //}
            //return null; 

            //  return JsonConvert.DeserializeObject < Root >( "{\"items\":[{\"has_synonyms\":true,\"is_moderator_only\":false,\"is_required\":false,\"count\":2251695,\"name\":\"javascript\"},{\"has_synonyms\":true,\"is_moderator_only\":false,\"is_required\":false,\"count\":1790917,\"name\":\"java\"},{\"has_synonyms\":true,\"is_moderator_only\":false,\"is_required\":false,\"count\":1770300,\"name\":\"python\"},{\"collectives\":[{\"tags\":[\"audio\",\"c#\"],\"external_links\":[{\"type\":\"website\"},{\"type\":\"support\",\"link\":\"mailto:support@example.com\"},{\"type\":\"twitter\"},{\"type\":\"github\"},{\"type\":\"facebook\"},{\"type\":\"instagram\"}],\"description\":\"Official Q&A support for AudioBubble\",\"name\":\"AudioBubble\",\"slug\":\"audiobubble\"}],\"has_synonyms\":true,\"is_moderator_only\":false,\"is_required\":false,\"count\":1491251,\"name\":\"c#\"},{\"has_synonyms\":true,\"is_moderator_only\":false,\"is_required\":false,\"count\":1410620,\"name\":\"php\"},{\"has_synonyms\":true,\"is_moderator_only\":false,\"is_required\":false,\"count\":1343693,\"name\":\"android\"},{\"has_synonyms\":true,\"is_moderator_only\":false,\"is_required\":false,\"count\":1083691,\"name\":\"html\"},{\"has_synonyms\":true,\"is_moderator_only\":false,\"is_required\":false,\"count\":1015576,\"name\":\"jquery\"},{\"has_synonyms\":true,\"is_moderator_only\":false,\"is_required\":false,\"count\":733239,\"name\":\"c++\"},{\"has_synonyms\":true,\"is_moderator_only\":false,\"is_required\":false,\"count\":726916,\"name\":\"css\"},{\"has_synonyms\":true,\"is_moderator_only\":false,\"is_required\":false,\"count\":659173,\"name\":\"ios\"},{\"has_synonyms\":true,\"is_moderator_only\":false,\"is_required\":false,\"count\":629436,\"name\":\"mysql\"},{\"has_synonyms\":true,\"is_moderator_only\":false,\"is_required\":false,\"count\":599648,\"name\":\"sql\"},{\"has_synonyms\":true,\"is_moderator_only\":false,\"is_required\":false,\"count\":413472,\"name\":\"r\"},{\"has_synonyms\":true,\"is_moderator_only\":false,\"is_required\":false,\"count\":396720,\"name\":\"node.js\"},{\"has_synonyms\":true,\"is_moderator_only\":false,\"is_required\":false,\"count\":369355,\"name\":\"arrays\"},{\"has_synonyms\":true,\"is_moderator_only\":false,\"is_required\":false,\"count\":363967,\"name\":\"asp.net\"},{\"has_synonyms\":false,\"is_moderator_only\":false,\"is_required\":false,\"count\":362649,\"name\":\"c\"},{\"has_synonyms\":true,\"is_moderator_only\":false,\"is_required\":false,\"count\":327425,\"name\":\"ruby-on-rails\"},{\"has_synonyms\":true,\"is_moderator_only\":false,\"is_required\":false,\"count\":323150,\"name\":\"json\"},{\"has_synonyms\":true,\"is_moderator_only\":false,\"is_required\":false,\"count\":322017,\"name\":\"reactjs\"},{\"has_synonyms\":true,\"is_moderator_only\":false,\"is_required\":false,\"count\":309992,\"name\":\".net\"},{\"has_synonyms\":true,\"is_moderator_only\":false,\"is_required\":false,\"count\":307226,\"name\":\"sql-server\"},{\"has_synonyms\":true,\"is_moderator_only\":false,\"is_required\":false,\"count\":299960,\"name\":\"swift\"},{\"has_synonyms\":true,\"is_moderator_only\":false,\"is_required\":false,\"count\":291869,\"name\":\"objective-c\"},{\"has_synonyms\":true,\"is_moderator_only\":false,\"is_required\":false,\"count\":291134,\"name\":\"python-3.x\"},{\"has_synonyms\":false,\"is_moderator_only\":false,\"is_required\":false,\"count\":272036,\"name\":\"django\"},{\"has_synonyms\":true,\"is_moderator_only\":false,\"is_required\":false,\"count\":262239,\"name\":\"angularjs\"},{\"has_synonyms\":true,\"is_moderator_only\":false,\"is_required\":false,\"count\":258716,\"name\":\"angular\"},{\"has_synonyms\":true,\"is_moderator_only\":false,\"is_required\":false,\"count\":249431,\"name\":\"excel\"}],\"has_more\":true,\"quota_max\":10000,\"quota_remaining\":9974}");

            return await Get1000TagsAsync();//JsonConvert.DeserializeObject<Root>("{\"items\":[{\"has_synonyms\":true,\"is_moderator_only\":false,\"is_required\":false,\"count\":2251695,\"name\":\"javascript\"},{\"has_synonyms\":true,\"is_moderator_only\":false,\"is_required\":false,\"count\":1790917,\"name\":\"java\"},{\"has_synonyms\":true,\"is_moderator_only\":false,\"is_required\":false,\"count\":1770300,\"name\":\"python\"},{\"collectives\":[{\"tags\":[\"audio\",\"c#\"],\"external_links\":[{\"type\":\"website\"},{\"type\":\"support\",\"link\":\"mailto:support@example.com\"},{\"type\":\"twitter\"},{\"type\":\"github\"},{\"type\":\"facebook\"},{\"type\":\"instagram\"}],\"description\":\"Official Q&A support for AudioBubble\",\"name\":\"AudioBubble\",\"slug\":\"audiobubble\"}],\"has_synonyms\":true,\"is_moderator_only\":false,\"is_required\":false,\"count\":1491251,\"name\":\"c#\"},{\"has_synonyms\":true,\"is_moderator_only\":false,\"is_required\":false,\"count\":1410620,\"name\":\"php\"},{\"has_synonyms\":true,\"is_moderator_only\":false,\"is_required\":false,\"count\":1343693,\"name\":\"android\"},{\"has_synonyms\":true,\"is_moderator_only\":false,\"is_required\":false,\"count\":1083691,\"name\":\"html\"},{\"has_synonyms\":true,\"is_moderator_only\":false,\"is_required\":false,\"count\":1015576,\"name\":\"jquery\"},{\"has_synonyms\":true,\"is_moderator_only\":false,\"is_required\":false,\"count\":733239,\"name\":\"c++\"},{\"has_synonyms\":true,\"is_moderator_only\":false,\"is_required\":false,\"count\":726916,\"name\":\"css\"},{\"has_synonyms\":true,\"is_moderator_only\":false,\"is_required\":false,\"count\":659173,\"name\":\"ios\"},{\"has_synonyms\":true,\"is_moderator_only\":false,\"is_required\":false,\"count\":629436,\"name\":\"mysql\"},{\"has_synonyms\":true,\"is_moderator_only\":false,\"is_required\":false,\"count\":599648,\"name\":\"sql\"},{\"has_synonyms\":true,\"is_moderator_only\":false,\"is_required\":false,\"count\":413472,\"name\":\"r\"},{\"has_synonyms\":true,\"is_moderator_only\":false,\"is_required\":false,\"count\":396720,\"name\":\"node.js\"},{\"has_synonyms\":true,\"is_moderator_only\":false,\"is_required\":false,\"count\":369355,\"name\":\"arrays\"},{\"has_synonyms\":true,\"is_moderator_only\":false,\"is_required\":false,\"count\":363967,\"name\":\"asp.net\"},{\"has_synonyms\":false,\"is_moderator_only\":false,\"is_required\":false,\"count\":362649,\"name\":\"c\"},{\"has_synonyms\":true,\"is_moderator_only\":false,\"is_required\":false,\"count\":327425,\"name\":\"ruby-on-rails\"},{\"has_synonyms\":true,\"is_moderator_only\":false,\"is_required\":false,\"count\":323150,\"name\":\"json\"},{\"has_synonyms\":true,\"is_moderator_only\":false,\"is_required\":false,\"count\":322017,\"name\":\"reactjs\"},{\"has_synonyms\":true,\"is_moderator_only\":false,\"is_required\":false,\"count\":309992,\"name\":\".net\"},{\"has_synonyms\":true,\"is_moderator_only\":false,\"is_required\":false,\"count\":307226,\"name\":\"sql-server\"},{\"has_synonyms\":true,\"is_moderator_only\":false,\"is_required\":false,\"count\":299960,\"name\":\"swift\"},{\"has_synonyms\":true,\"is_moderator_only\":false,\"is_required\":false,\"count\":291869,\"name\":\"objective-c\"},{\"has_synonyms\":true,\"is_moderator_only\":false,\"is_required\":false,\"count\":291134,\"name\":\"python-3.x\"},{\"has_synonyms\":false,\"is_moderator_only\":false,\"is_required\":false,\"count\":272036,\"name\":\"django\"},{\"has_synonyms\":true,\"is_moderator_only\":false,\"is_required\":false,\"count\":262239,\"name\":\"angularjs\"},{\"has_synonyms\":true,\"is_moderator_only\":false,\"is_required\":false,\"count\":258716,\"name\":\"angular\"},{\"has_synonyms\":true,\"is_moderator_only\":false,\"is_required\":false,\"count\":249431,\"name\":\"excel\"}],\"has_more\":true,\"quota_max\":10000,\"quota_remaining\":9974}");
        }


        private Task<Root> Get1000TagsAsync()
        {
            List<Item> items = new List<Item>();
            items.AddRange(ExampleData.root1.items);
            //items.AddRange(ExampleData.root2.items);
            //items.AddRange(ExampleData.root1.items);
            //items.AddRange(ExampleData.root2.items);
            //items.AddRange(ExampleData.root1.items);
            //items.AddRange(ExampleData.root2.items);
            //items.AddRange(ExampleData.root1.items);
            //items.AddRange(ExampleData.root2.items);
            //items.AddRange(ExampleData.root1.items);
            //items.AddRange(ExampleData.root2.items);
            return Task.FromResult(new Root() { items = items});
        }
        private Task<Root> Get1000TagsAsync1()
        {
            List<Item> items = new List<Item>();
            //items.AddRange(ExampleData.root1.items);
            items.AddRange(ExampleData.root2.items);
            //items.AddRange(ExampleData.root1.items);
            //items.AddRange(ExampleData.root2.items);
            //items.AddRange(ExampleData.root1.items);
            //items.AddRange(ExampleData.root2.items);
            //items.AddRange(ExampleData.root1.items);
            //items.AddRange(ExampleData.root2.items);
            //items.AddRange(ExampleData.root1.items);
            //items.AddRange(ExampleData.root2.items);
            return Task.FromResult(new Root() { items = items });
        }


    }

}
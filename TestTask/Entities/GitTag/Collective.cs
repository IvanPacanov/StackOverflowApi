using System.Collections.Generic;

namespace TestTask.Entities.GitTag
{
    public class Collective
    {
        public IEnumerable<string> tags { get; set; }
        public IEnumerable<ExternalLink> external_links { get; set; }
        public string description { get; set; }
        public string link { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
    }
}

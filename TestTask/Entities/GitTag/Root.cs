
using System.Collections.Generic;

namespace TestTask.Entities.GitTag
{
    public class Root
    {
        public IEnumerable<Item> items { get; set; }
        public bool has_more { get; set; }
        public int quota_max { get; set; }
        public int quota_remaining { get; set; }
    }
}

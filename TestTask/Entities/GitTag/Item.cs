using System.Collections.Generic;

namespace TestTask.Entities.GitTag
{
    public class Item
    {
        public bool has_synonyms { get; set; }
        public bool is_moderator_only { get; set; }
        public bool is_required { get; set; }
        public int count { get; set; }
        public string name { get; set; }
        public IEnumerable<Collective> collectives { get; set; }
    }
}

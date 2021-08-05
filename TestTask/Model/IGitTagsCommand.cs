using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTask.Entities;
using TestTask.Entities.GitTag;

namespace TestTask.Model
{
   
        public interface IGitTagsCommand
    {
        Task<IEnumerable<ElementToReturn>> GetMostPopularTag();
        Task<IEnumerable<ElementToReturn>> GetMostPopularTagBySize(int size);
    }
   
}

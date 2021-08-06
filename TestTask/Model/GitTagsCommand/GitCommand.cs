using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTask.Entities.GitTag;
using TestTask.Model.AdapterGit;
using TestTask.Model.AdapterGit.Tags;

namespace TestTask.Model.GitTagsCommand
{
    public class GitCommand : IGitTagsCommand
    {
        private GitAdapter gitAdapter;
        private readonly ILogger<GitCommand> logger;

        public GitCommand(ILogger<GitCommand> logger)
        {
            this.logger = logger;
        }

        public Task<IEnumerable<ElementToReturn>> GetMostPopularTag()
        {
            gitAdapter = new Tags();
            return (gitAdapter as Tags).GetTags();
        }

        public Task<IEnumerable<ElementToReturn>> GetMostPopularTagByFilter(ConfigureToSearch configure)
        {
            gitAdapter = new Tags();
            return (gitAdapter as Tags).GetTagsBySize(configure);
        }
    }
}

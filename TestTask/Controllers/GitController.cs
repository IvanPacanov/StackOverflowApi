﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using TestTask.Entities.GitTag;
using TestTask.Model;

namespace TestTask.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GitController : ControllerBase
    {

        private readonly ILogger<GitController> _logger;
        private readonly IGitTagsCommand gitTagsCommand;

        public GitController(ILogger<GitController> logger, IGitTagsCommand gitTagsCommand)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            this.gitTagsCommand = gitTagsCommand ?? throw new ArgumentNullException(nameof(gitTagsCommand));
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Item>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<Item>>> Get()
        {
            return Ok(await gitTagsCommand.GetMostPopularTag());
        }

        [HttpGet("{size}", Name = "GetOfSizeTag")]
        [ProducesResponseType(typeof(IEnumerable<Item>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<Item>>> Get(int size)
        {
            return Ok(await gitTagsCommand.GetMostPopularTag());
        }
    }
}

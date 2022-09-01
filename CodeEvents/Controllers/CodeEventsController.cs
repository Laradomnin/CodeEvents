﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CodeEvents.Api.Core.Entities;
using CodeEvents.Api.Data;
using CodeEvents.Api.Data.Repositories;

namespace CodeEvents.Api.Controllers
{
    [Route("api/events")]
    [ApiController]
    public class CodeEventsController : ControllerBase
    {
        private readonly CodeEventsApiContext db;

        public CodeEventsController(CodeEventsApiContext context)
        {
            db = context;
            var uof = new UnitOfWork(db);
        }

        // GET: api/CodeEvents
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CodeEvent>>> GetCodeEvent()
        {
            return null;
        }

       
    }
}

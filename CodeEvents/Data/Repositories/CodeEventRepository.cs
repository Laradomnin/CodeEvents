﻿using CodeEvents.Api.Controllers.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace CodeEvents.Api.Data.Repositories
{
    public class CodeEventRepository
    {
        private CodeEventsApiContext db;

        public CodeEventRepository(CodeEventsApiContext db)
        {
            this.db = db;

        }

        internal async Task <IEnumerable<CodeEvent>> GetAsync()
        {
            return await db.CodeEvent
                .Include(c=>c.Location)
                .ToListAsync();

        }
    }
}

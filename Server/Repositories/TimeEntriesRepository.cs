﻿using Stroom.Server.Contexts;
using Stroom.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Stroom.Server.Repositories
{
    public class TimeEntriesRepository : ITimeEntriesRepository
    {
        private readonly ApplicationDbContext ApplicationDbContext;

        public TimeEntriesRepository(ApplicationDbContext taskContext)
        {
            ApplicationDbContext = taskContext;
        }

        public TimeEntry Add(TimeEntry timeEntry)
        {
            throw new NotImplementedException();
        }

        public TimeEntry Delete(TimeEntry timeEntry)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TimeEntry> Get()
        {
            var timeEntries = ApplicationDbContext.TimeEntries.ToList();
            foreach (var timeEntry in timeEntries)
            {
                timeEntry.Task = ApplicationDbContext.Tasks.AsNoTracking().IgnoreAutoIncludes().Include(e => e.Project).First(e => e.TaskID == timeEntry.TaskID);
            }

            return timeEntries;
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}

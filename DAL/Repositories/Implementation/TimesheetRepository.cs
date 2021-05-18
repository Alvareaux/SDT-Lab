using System;
using System.Collections.Generic;
using System.Text;

using Lab.DAL.Entities;
using Lab.DAL.Repositories.Interfaces;
using Lab.DAL.EF;

using Microsoft.EntityFrameworkCore;
using System.Linq;


namespace Lab.DAL.Repositories.Implementation
{
    public class TimesheetRepository
         : BaseRepository<Timesheet>, ITimesheetRepository
    {

        internal TimesheetRepository(TimesheetContext context)
            : base(context)
        {

        }
    }
}

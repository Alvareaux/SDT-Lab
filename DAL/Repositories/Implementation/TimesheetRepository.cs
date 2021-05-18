using Lab.DAL.EF;
using Lab.DAL.Entities;
using Lab.DAL.Repositories.Interfaces;


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

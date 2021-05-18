using Lab.DAL.EF;
using Lab.DAL.Entities;
using Lab.DAL.Repositories.Interfaces;


namespace Lab.DAL.Repositories.Implementation
{
    public class RecordRepository
         : BaseRepository<Record>, IRecordRepository
    {

        internal RecordRepository(TimesheetContext context)
            : base(context)
        {

        }
    }
}

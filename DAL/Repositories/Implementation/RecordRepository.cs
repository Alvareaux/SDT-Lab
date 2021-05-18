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
    public class RecordRepository
         : BaseRepository<Record>, IRecordRepository
    {

        internal RecordRepository(TimesheetContext context)
            : base(context)
        {

        }
    }
}

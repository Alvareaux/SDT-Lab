using Lab.DAL.EF;
using Lab.DAL.Repositories.Implementation;
using Lab.DAL.Repositories.Interfaces;
using Lab.DAL.UnitOfWork;
using System;

namespace Catalog.DAL.EF
{
    public class EFUnitOfWork
        : IUnitOfWork
    {
        private TimesheetContext db;
        private TimesheetRepository timesheetRepository;
        private RecordRepository recordRepository;

        public EFUnitOfWork(TimesheetContext context)
        {
            db = context;
        }
        public ITimesheetRepository OSBBs
        {
            get
            {
                if (timesheetRepository == null)
                    timesheetRepository = new TimesheetRepository(db);
                return timesheetRepository;
            }
        }

        public IRecordRepository Streets
        {
            get
            {
                if (recordRepository == null)
                    recordRepository = new RecordRepository(db);
                return recordRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
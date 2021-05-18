using Lab.DAL.Repositories.Interfaces;
using System;

namespace Lab.DAL.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        ITimesheetRepository OSBBs { get; }
        IRecordRepository Streets { get; }
        void Save();
    }
}
using Lab.DAL.Entities;
using Lab.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab.DAL.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        ITimesheetRepository OSBBs { get; }
        IRecordRepository Streets { get; }
        void Save();
    }
}
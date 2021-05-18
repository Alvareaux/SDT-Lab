using System;
using System.Collections.Generic;
using System.Text;

namespace Lab.DAL.Entities
{
    public class Timesheet
    {
        public int timesheet_id { get; set; }
        public IEnumerable<Record> Records { get; set; }
    }
}

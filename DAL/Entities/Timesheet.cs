using System.Collections.Generic;

namespace Lab.DAL.Entities
{
    public class Timesheet
    {
        public int timesheet_id { get; set; }
        public IEnumerable<Record> Records { get; set; }
    }
}
